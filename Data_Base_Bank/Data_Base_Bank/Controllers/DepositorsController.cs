using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data_Base_Bank.Models;
using Data_Base_Bank.ViewModels;
using Data_Base_Bank.ViewModels.DepositorsViewModel;
using Microsoft.AspNetCore.Authorization;

namespace Data_Base_Bank.Controllers
{
    [Authorize(Roles = "user, moder")]
    public class DepositorsController : Controller
    {
        private BankContext db;
        public DepositorsController(BankContext _db)
        {
            db = _db;
        }

        public IActionResult Index(string name, string surname, string patronymic, int page = 1, SortState sortOrder = SortState.DepositorIDAsc)
        {
            int pageSize = 10;
            IQueryable<Depositor> source = db.Depositors;
            if (!String.IsNullOrEmpty(name))
            {
                source = source.Where(p => p.NameDep.Contains(name));
            }
            if (!String.IsNullOrEmpty(surname))
            {
                source = source.Where(p => p.SurnameDep.Contains(surname));
            }
            if (!String.IsNullOrEmpty(patronymic))
            {
                source = source.Where(p => p.MiddlenameDep.Contains(patronymic));
            }
            switch (sortOrder)
            {
                case SortState.DepositorIDDesc:
                    source = source.OrderByDescending(s => s.DepositorID);
                    break;
                case SortState.NameOfDepAsc:
                    source = source.OrderBy(s => s.NameDep);
                    break;
                case SortState.NameOfDepDesc:
                    source = source.OrderByDescending(s => s.NameDep);
                    break;
                case SortState.SurnameOfDepAsc:
                    source = source.OrderBy(s => s.SurnameDep);
                    break;
                case SortState.SurnameOfDepDesc:
                    source = source.OrderByDescending(s => s.SurnameDep);
                    break;
                case SortState.MiddlenameOfDepAsc:
                    source = source.OrderBy(s => s.MiddlenameDep);
                    break;
                case SortState.MiddlenameOfDepDesc:
                    source = source.OrderByDescending(s => s.MiddlenameDep);
                    break;
                case SortState.AddresAsc:
                    source = source.OrderBy(s => s.Addres);
                    break;
                case SortState.AddresDesc:
                    source = source.OrderByDescending(s => s.Addres);
                    break;
                case SortState.PhoneAsc:
                    source = source.OrderBy(s => s.Phone);
                    break;
                case SortState.PhoneDesc:
                    source = source.OrderByDescending(s => s.Phone);
                    break;
                case SortState.PassportdataAsc:
                    source = source.OrderBy(s => s.Passportdata);
                    break;
                case SortState.PassportdataDesc:
                    source = source.OrderByDescending(s => s.Passportdata);
                    break;
                default:
                    source = source.OrderBy(s => s.DepositorID);
                    break;
            }
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            DepositorsFilterViewModel depositorsFilterViewModel = new DepositorsFilterViewModel(name, surname, patronymic);
            DepositorsViewModel depositors = new DepositorsViewModel
            {
                Depositors = items,
                PageViewModel = pageViewModel,
                SortViewModel = new DepositorsSortViewModel(sortOrder),
                FilterViewModel = depositorsFilterViewModel
            };
            return View(depositors);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Depositor depositor = db.Depositors.Find(id);
            if (depositor != null)
            {
                return View(depositor);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Depositor depositor)
        {
            db.Depositors.Add(depositor);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            Depositor depositor = db.Depositors.Find(id);
            if (depositor == null)
                return View("NotFound");
            else
                return View(depositor);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var depositor = db.Depositors.FirstOrDefault(d => d.DepositorID == id);
                db.Depositors.Remove(depositor);
                db.SaveChanges();
            }
            catch { }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Depositor depositor = db.Depositors.Find(id);
            if (depositor != null)
            {
                return View(depositor);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Depositor depositor)
        {
            db.Entry(depositor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}