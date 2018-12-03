using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data_Base_Bank.Models;
using Data_Base_Bank.ViewModels;
using Data_Base_Bank.ViewModels.EmployeesViewModel;
using Microsoft.AspNetCore.Authorization;

namespace Data_Base_Bank.Controllers
{
    [Authorize(Roles = "user, moder")]
    public class EmployeesController : Controller
    {
        private BankContext db;
        public EmployeesController(BankContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string name, string surname, string patronymic, int page = 1, SortState sortOrder = SortState.EmployeeIDAsc)
        {
            int pageSize = 10;
            IQueryable<Employee> source = db.Employees;
            if (!String.IsNullOrEmpty(name))
            {
                source = source.Where(p => p.NameEmpl.Contains(name));
            }
            if (!String.IsNullOrEmpty(surname))
            {
                source = source.Where(p => p.SurnameEmpl.Contains(surname));
            }
            if (!String.IsNullOrEmpty(patronymic))
            {
                source = source.Where(p => p.MiddlenameEmpl.Contains(patronymic));
            }
            switch (sortOrder)
            {
                case SortState.EmployeeIDDesc:
                    source = source.OrderByDescending(s => s.EmployeeID);
                    break;
                case SortState.NameOfEmplAsc:
                    source = source.OrderBy(s => s.NameEmpl);
                    break;
                case SortState.NameOfEmplDesc:
                    source = source.OrderByDescending(s => s.NameEmpl);
                    break;
                case SortState.SurnameOfEmplAsc:
                    source = source.OrderBy(s => s.SurnameEmpl);
                    break;
                case SortState.SurnameOfEmplDesc:
                    source = source.OrderByDescending(s => s.SurnameEmpl);
                    break;
                case SortState.MiddlenameOfEmplAsc:
                    source = source.OrderBy(s => s.MiddlenameEmpl);
                    break;
                case SortState.MiddlenameOfEmplDesc:
                    source = source.OrderByDescending(s => s.MiddlenameEmpl);
                    break;
                case SortState.PatronymicAsc:
                    source = source.OrderBy(s => s.Patronymic);
                    break;
                case SortState.PatronymicDesc:
                    source = source.OrderByDescending(s => s.Patronymic);
                    break;
                case SortState.DateofBirthAsc:
                    source = source.OrderBy(s => s.DateofBirth);
                    break;
                case SortState.DateofBirthDesc:
                    source = source.OrderByDescending(s => s.DateofBirth);
                    break;
                default:
                    source = source.OrderBy(s => s.EmployeeID);
                    break;
            }
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            EmployeesFilterViewModel employeesFilterViewModel = new EmployeesFilterViewModel(name, surname, patronymic);
            EmployeesViewModel employees = new EmployeesViewModel
            {
                Employees = items,
                PageViewModel = pageViewModel,
                SortViewModel = new EmployeesSortViewModel(sortOrder),
                FilterViewModel = employeesFilterViewModel
            };
            //var employees = db.Employees.ToList();
            return View(employees);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = db.Employees.Find(id);
            if (employee != null)
            {
                return View(employee);
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
                return View("NotFound");
            else
                return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == id);
                db.Employees.Remove(employee);
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
            Employee employee = db.Employees.Find(id);
            if (employee != null)
            {
                return View(employee);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}