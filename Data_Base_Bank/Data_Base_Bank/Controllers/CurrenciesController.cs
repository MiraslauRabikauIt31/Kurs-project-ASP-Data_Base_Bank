using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data_Base_Bank.Models;
using Microsoft.EntityFrameworkCore;
using Data_Base_Bank.ViewModels;
using Data_Base_Bank.ViewModels.CurrenciesViewModel;
using Microsoft.AspNetCore.Authorization;

namespace Data_Base_Bank.Controllers
{
    [Authorize(Roles = "user, moder")]
    public class CurrenciesController : Controller
    {
        private BankContext db;

        public CurrenciesController(BankContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string type, string exchangerate, int page = 1, SortState sortOrder = SortState.CurrencyIDAsc)
        {
            int pageSize = 10;
            IQueryable<Currency> source = db.Currencies;
            if (!String.IsNullOrEmpty(type))
            {
                source = source.Where(p => p.NameCurrency.Contains(type));
            }
            if (exchangerate != null)
            {
                decimal tmp;
                if(Decimal.TryParse(exchangerate, out tmp))
                {
                    source = source.Where(p => p.Exchangerate == tmp);
                } 
            }
            switch (sortOrder)
            {
                case SortState.CurrencyIDDesc:
                    source = source.OrderByDescending(s => s.CurrencyID);
                    break;
                case SortState.NameOfCurrencyAsc:
                    source = source.OrderBy(s => s.NameCurrency);
                    break;
                case SortState.NameOfCurrencyDesc:
                    source = source.OrderByDescending(s => s.NameCurrency);
                    break;
                case SortState.ExchangerateOfCurrencyAsc:
                    source = source.OrderBy(s => s.Exchangerate);
                    break;
                case SortState.ExchangerateOfCurrencyDesc:
                    source = source.OrderByDescending(s => s.Exchangerate);
                    break;
                case SortState.DateOfCurrencyAsc:
                    source = source.OrderBy(s => s.date_);
                    break;
                case SortState.DateOfCurrencyDesc:
                    source = source.OrderByDescending(s => s.date_);
                    break;
                default:
                    source = source.OrderBy(s => s.CurrencyID);
                    break;
            }
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            CurrenciesFilterViewModel currenciesFilterViewModel = new CurrenciesFilterViewModel(type, exchangerate);
            CurrenciesViewModel currencies = new CurrenciesViewModel
            {
                Currencies = items,
                PageViewModel = pageViewModel,
                SortViewModel = new CurrenciesSortViewModel(sortOrder),
                FilterViewModel = currenciesFilterViewModel
            };
            return View(currencies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Currency currency)
        {
            if (ModelState.IsValid)
            {
                db.Currencies.Add(currency);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            Currency currency = db.Currencies.Find(id);
            if (currency == null)
                return View("NotFound");
            else
                return View(currency);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var currency = db.Currencies.FirstOrDefault(c => c.CurrencyID == id);
                db.Currencies.Remove(currency);
                db.SaveChanges();
            }
            catch { }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            Currency currency = db.Currencies.Find(id);
            if(currency!=null)
            {
                return View(currency);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            Currency currency = db.Currencies.Find(id);
            if (currency != null)
            {
                return View(currency);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Currency currency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(currency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}