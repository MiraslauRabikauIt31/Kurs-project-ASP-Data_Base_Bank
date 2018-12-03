using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data_Base_Bank.Models;
using Data_Base_Bank.ViewModels;
using Data_Base_Bank.ViewModels.DepositsViewModel;

namespace Data_Base_Bank.Controllers
{
    public class HomeController : Controller
    {
        private BankContext _db;
        public HomeController(BankContext db)
        {
            _db = db;
        }

        private DepositViewModel _deposit = new DepositViewModel
        {
            NameCurrency="",
            NameDep="",
            NameType="",
            NameEmpl=""
        };
        public IActionResult Index(int page = 1)
        {
            int pageSize = 10;
            IQueryable<Deposit> source = _db.Deposits.Include(d => d.Currency)
                .Include(d => d.Depositor)
                .Include(d => d.Typedeposit)
                .Include(d => d.Employee);
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Deposits = items,
                DepositViewModel = _deposit,
                PageViewModel = pageViewModel
            };
            return View(homeViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
