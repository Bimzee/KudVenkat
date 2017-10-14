using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KudVenkat.Models;


namespace KudVenkat.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            KudVenkatMVCDataModel datamodel = new KudVenkatMVCDataModel();
            var dept = datamodel.tblDepartments;
            return View(employees);
        }

        public ActionResult Department()
        {
            KudVenkatMVCDataModel datamodel = new KudVenkatMVCDataModel();
            var dept = datamodel.tblDepartments;

            ViewBag.Departments1 = new SelectList(datamodel.tblDepartments, "Id", "Name");
            return View();
        }

    }
}