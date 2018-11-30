using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data_Base_Bank.Models;
using Data_Base_Bank.ViewModels;
using Data_Base_Bank.ViewModels.TypedepositsViewModel;

namespace Data_Base_Bank.Controllers
{
    public class TypesdepositsController : Controller
    {
        private BankContext db;
        public TypesdepositsController(BankContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string type, string depositamount, int page = 1, SortState sortOrder = SortState.TypedepositIDAsc)
        {
            int pageSize = 10;
            IQueryable<Typedeposit> source = db.Typesdeposits;
            if (!String.IsNullOrEmpty(type))
            {
                source = source.Where(p => p.NameType.Contains(type));
            }
            if (depositamount != null)
            {
                decimal tmp;
                if(Decimal.TryParse(depositamount, out tmp))
                {
                    source = source.Where(p => p.Minimumdepositamount == tmp);
                }
            }
            switch (sortOrder)
            {
                case SortState.TypedepositIDDesc:
                    source = source.OrderByDescending(s => s.TypedepositID);
                    break;
                case SortState.NameOfTypeAsc:
                    source = source.OrderBy(s => s.NameType);
                    break;
                case SortState.NameOfTypeDesc:
                    source = source.OrderByDescending(s => s.NameType);
                    break;
                case SortState.MinimumTermOfdepositAsc:
                    source = source.OrderBy(s => s.Minimumtermofdeposit);
                    break;
                case SortState.MinimumTermOfdepositDesc:
                    source = source.OrderByDescending(s => s.Minimumtermofdeposit);
                    break;
                case SortState.MinimumDepositAmountAsc:
                    source = source.OrderBy(s => s.Minimumdepositamount);
                    break;
                case SortState.MinimumDepositAmountDesc:
                    source = source.OrderByDescending(s => s.Minimumdepositamount);
                    break;
                case SortState.InterestrateAsc:
                    source = source.OrderBy(s => s.Interestrate);
                    break;
                case SortState.InterestrateDesc:
                    source = source.OrderByDescending(s => s.Interestrate);
                    break;
                case SortState.AdditionalconditionsAsc:
                    source = source.OrderBy(s => s.Additionalconditions);
                    break;
                case SortState.AdditionalconditionsDesc:
                    source = source.OrderByDescending(s => s.Additionalconditions);
                    break;
                default:
                    source = source.OrderBy(s => s.TypedepositID);
                    break;
            }
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            TypedepositsFilterViewModel typedepositsFilterViewModel = new TypedepositsFilterViewModel(type, depositamount);
            TypedepositsViewModel typesdeposits = new TypedepositsViewModel
            {
                Typedeposits = items,
                PageViewModel = pageViewModel,
                SortViewModel = new TypedepositsSortViewModel(sortOrder),
                FilterViewModel = typedepositsFilterViewModel
            };
            //var typesdeposits = db.Typesdeposits.ToList();
            return View(typesdeposits);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Typedeposit typedeposit)
        {
            db.Typesdeposits.Add(typedeposit);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Typedeposit typedeposit = db.Typesdeposits.Find(id);
            if (typedeposit != null)
            {
                return View(typedeposit);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Typedeposit typedeposit = db.Typesdeposits.Find(id);
            if (typedeposit != null)
            {
                return View(typedeposit);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Typedeposit typedeposit)
        {
            db.Entry(typedeposit).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            Typedeposit typedeposit = db.Typesdeposits.Find(id);
            if (typedeposit == null)
                return View("NotFound");
            else
                return View(typedeposit);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var typedeposit = db.Typesdeposits.FirstOrDefault(t => t.TypedepositID == id);
                db.Typesdeposits.Remove(typedeposit);
                db.SaveChanges();
            }
            catch { }
            return RedirectToAction("Index");
        }
    }
}