﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KudVenkat.Models;

namespace KudVenkat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Company company = new Company("Pragim");

            ViewBag.Departments = new SelectList(company.Departments, "Id", "Name");
            ViewBag.CompanyName = company.CompanyName;

            return View();
        }

        public ActionResult Index1()
        {
            Company company = new Company("Pragim");

            return View(company);
        }

        [HttpGet]
        public ActionResult RaioButton()
        {
            Company company = new Company("pragim");
            return View(company);
        }

        [HttpPost]
        public string RaioButton(Company company)
        {
            if(string.IsNullOrEmpty(company.SelectedDepartment))
            {
                return "Please select Department";
            }
            else
            {
                return "You selected dept with Id " + company.SelectedDepartment;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}