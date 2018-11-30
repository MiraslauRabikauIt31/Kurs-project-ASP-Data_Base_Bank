using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Data_Base_Bank.Models;
using Data_Base_Bank.ViewModels;
using Data_Base_Bank.ViewModels.DepositsViewModel;

namespace Data_Base_Bank.Controllers
{
    public class DepositsController : Controller
    {
        private BankContext db;
        public DepositsController(BankContext _db)
        {
            db = _db;
        }

        private DepositViewModel _deposit = new DepositViewModel
        {
            NameCurrency = "",
            NameDep = "",
            NameType = "",
            NameEmpl = ""
        };
        public IActionResult Index(int? currency, int? typedeposit, int page = 1, SortState sortOrder = SortState.DespositIDAsc)
        {
            int pageSize = 10;
            IQueryable<Deposit> source = db.Deposits.Include(d => d.Currency)
                .Include(d => d.Depositor)
                .Include(d => d.Typedeposit)
                .Include(d => d.Employee);
            if (currency != null && currency != 0)
                source = source.Where(p => p.CurrencyID == currency);
            if (typedeposit != null && typedeposit != 0)
                source = source.Where(p => p.TypedepositID == typedeposit);

            switch (sortOrder)
            {
                case SortState.DespositIDDesc:
                    source = source.OrderByDescending(s => s.DespositID);
                    break;
                case SortState.TypeOfCurrencyAsc:
                    source = source.OrderBy(s => s.Currency.NameCurrency);
                    break;
                case SortState.TypeOfCurrencyDesc:
                    source = source.OrderByDescending(s => s.Currency.NameCurrency);
                    break;
                case SortState.TypeOfDepositorAsc:
                    source = source.OrderBy(s => s.Depositor.NameDep);
                    break;
                case SortState.TypeOfDepositorDesc:
                    source = source.OrderByDescending(s => s.Depositor.NameDep);
                    break;
                case SortState.TypeOfTypedepositAsc:
                    source = source.OrderBy(s => s.Typedeposit.NameType);
                    break;
                case SortState.TypeOfTypedepositDesc:
                    source = source.OrderByDescending(s => s.Typedeposit.NameType);
                    break;
                case SortState.TypeOfEmployeeAsc:
                    source = source.OrderBy(s => s.Employee.NameEmpl);
                    break;
                case SortState.TypeOfEmployeeDesc:
                    source = source.OrderByDescending(s => s.Employee.NameEmpl);
                    break;
                case SortState.DepositsumAsc:
                    source = source.OrderBy(s => s.Depositsum);
                    break;
                case SortState.DepositsumDesc:
                    source = source.OrderByDescending(s => s.Depositsum);
                    break;
                case SortState.DatedepositAsc:
                    source = source.OrderBy(s => s.Datedeposit);
                    break;
                case SortState.DatedepositDesc:
                    source = source.OrderByDescending(s => s.Datedeposit);
                    break;
                case SortState.RefundamountAsc:
                    source = source.OrderBy(s => s.Refundamount);
                    break;
                case SortState.RefundamountDesc:
                    source = source.OrderByDescending(s => s.Refundamount);
                    break;
                case SortState.DatereturnAsc:
                    source = source.OrderBy(s => s.Datereturn);
                    break;
                case SortState.DatereturnDesc:
                    source = source.OrderByDescending(s => s.Datereturn);
                    break;
                default:
                    source = source.OrderBy(s => s.DespositID);
                    break;
            }
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            DepositsFilterViewModel depositsFilterViewModel = new DepositsFilterViewModel(db.Currencies.ToList(), db.Typesdeposits.ToList(), currency, typedeposit);
            DepositsViewModel deposits = new DepositsViewModel
            {
                Deposits = items,
                DepositViewModel = _deposit,
                PageViewModel = pageViewModel,
                SortViewModel = new DepositsSortViewModel(sortOrder),
                FilterViewModel = depositsFilterViewModel
            };
            return View(deposits);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var depositcontext = db.Deposits.Include(c => c.Currency).Include(d => d.Depositor).Include(t => t.Typedeposit).Include(e => e.Employee);
            var items = depositcontext.Where(d => d.DespositID == id).ToList();
            var currencies = new SelectList(db.Currencies, "CurrencyID", "NameCurrency", items.First().CurrencyID);
            var depositors = new SelectList(db.Depositors, "DepositorID", "NameDep", items.First().DepositorID);
            var typedeposits = new SelectList(db.Typesdeposits, "TypedepositID", "NameType", items.First().TypedepositID);
            var emloyees = new SelectList(db.Employees, "EmployeeID", "NameEmpl", items.First().EmployeeID);
            DepositsViewModel deposits = new DepositsViewModel
            {
                Deposits = items,
                DepositViewModel = _deposit,
                CurrenciesList = currencies,
                DepositorsList = depositors,
                TypedepositsList = typedeposits,
                EmployeesList = emloyees
            };
            return View(deposits);
        }
        [HttpPost]
        public IActionResult Edit(Deposit deposit)
        {
            db.Deposits.Update(deposit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            var currencies = new SelectList(db.Currencies, "CurrencyID", "NameCurrency");
            var depositors = new SelectList(db.Depositors, "DepositorID", "NameDep");
            var typedeposits = new SelectList(db.Typesdeposits, "TypedepositID", "NameType");
            var emloyees = new SelectList(db.Employees, "EmployeeID", "NameEmpl");
            ViewBag.CurrencyID = currencies;
            ViewBag.DepositorID = depositors;
            ViewBag.TypedepositID = typedeposits;
            ViewBag.EmployeeID = emloyees;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Deposit deposit)
        {
            db.Deposits.Add(deposit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var depositcontext = db.Deposits.Include(c => c.Currency).Include(d => d.Depositor).Include(t => t.Typedeposit).Include(e => e.Employee);
            var items = depositcontext.Where(d => d.DespositID == id).ToList();
            var currencies = new SelectList(db.Currencies, "CurrencyID", "NameCurrency");
            var depositors = new SelectList(db.Depositors, "DepositorID", "NameDep");
            var typedeposits = new SelectList(db.Typesdeposits, "TypedepositID", "NameType");
            var emloyees = new SelectList(db.Employees, "EmployeeID", "NameEmpl");
            DepositViewModel depositView = new DepositViewModel
            {
                DespositID = items.First().DespositID,
                NameCurrency = items.First().Currency.NameCurrency,
                NameDep = items.First().Depositor.NameDep,
                NameType = items.First().Typedeposit.NameType,
                NameEmpl = items.First().Employee.NameEmpl,
                Depositsum = items.First().Depositsum,
                Datedeposit = items.First().Datedeposit,
                Refundamount = items.First().Refundamount,
                Datereturn = items.First().Datereturn
            };
            DepositsViewModel deposit = new DepositsViewModel
            {
                Deposits = items,
                DepositViewModel = _deposit,
                CurrenciesList = currencies,
                DepositorsList = depositors,
                TypedepositsList = typedeposits,
                EmployeesList = emloyees
            };
            if (items == null)
                return View("NotFound");
            else
                return View(deposit);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var deposit = db.Deposits.FirstOrDefault(d => d.DespositID == id);
                db.Deposits.Remove(deposit);
                db.SaveChanges();
            }
            catch { }
            return RedirectToAction("index");
        }

        public IActionResult Details(int? id)
        {
            var depositcontext = db.Deposits.Include(c => c.Currency).Include(d => d.Depositor).Include(t => t.Typedeposit).Include(e => e.Employee);
            var items = depositcontext.Where(d => d.DespositID == id).ToList();
            var currencies = new SelectList(db.Currencies, "CurrencyID", "NameCurrency");
            var depositors = new SelectList(db.Depositors, "DepositorID", "NameDep");
            var typedeposits = new SelectList(db.Typesdeposits, "TypedepositID", "NameType");
            var emloyees = new SelectList(db.Employees, "EmployeeID", "NameEmpl");
            DepositViewModel depositView = new DepositViewModel
            {
                DespositID = items.First().DespositID,
                NameCurrency = items.First().Currency.NameCurrency,
                NameDep = items.First().Depositor.NameDep,
                NameType = items.First().Typedeposit.NameType,
                NameEmpl = items.First().Employee.NameEmpl,
                Depositsum = items.First().Depositsum,
                Datedeposit = items.First().Datedeposit,
                Refundamount = items.First().Refundamount,
                Datereturn = items.First().Datereturn
            };
            DepositsViewModel deposit = new DepositsViewModel
            {
                Deposits = items,
                DepositViewModel = _deposit,
                CurrenciesList = currencies,
                DepositorsList = depositors,
                TypedepositsList = typedeposits,
                EmployeesList = emloyees
            };
            if (items == null)
                return View("NotFound");
            else
                return View(deposit);
        }
    }
}