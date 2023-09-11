using Elev8WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elev8WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Context _context;
        public EmployeeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Employees.Add(new Employee()
                    {
                        Name = employee.Name,
                        DateOfEmployment = employee.DateOfEmployment,
                    });

                    _context.SaveChanges();

                    ViewBag.SuccessMessage = "Save was successfull!";
                    return View("Index");
                }
            }
            catch (Exception e)
            {

            }

            return View("Index", employee);
        }

        [HttpGet]
        public IActionResult EmployeeList()
        {
            try
            {
                var employeeList = _context.Employees.ToList();

                ViewBag.employeeList = employeeList;

                return View();
            }
            catch (Exception ex)
            {

                
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var employee = _context.Employees.Where(x => x.Id == id).FirstOrDefault();

                _context.Employees.Remove(employee);
                _context.SaveChanges();

                var employeeList = _context.Employees.ToList();

                ViewBag.employeeList = employeeList;

                return View("EmployeeList");
            }
            catch (Exception ex)
            {

                
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee requestModel)
        {
            try
            {
                var employee = _context.Employees.Where(x => x.Id == requestModel.Id).First();

                employee.Name = requestModel.Name;
                employee.DateOfEmployment = requestModel.DateOfEmployment;

                _context.Update(employee);
                _context.SaveChanges();

                var employeeList = _context.Employees.ToList();

                ViewBag.employeeList = employeeList;

                return View("EmployeeList");
            }
            catch (Exception ex)
            {

            }

            return View("Index");
        }
    }
}
