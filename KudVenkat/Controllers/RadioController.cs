using KudVenkat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KudVenkat.Controllers
{
    public class RadioController : Controller
    {
        public RadioController()
        {
                
        }
        // GET: Radio
        [HttpGet]
        public ActionResult Index()
        {
            Company company = new Company("pragim");
            return View(company);
        }


        [HttpPost]
        public string Index(Company company)
        {
            if (string.IsNullOrEmpty(company.SelectedDepartment))
            {
                return "Please select Department";
            }
            else
            {
                return "You selected dept with Id " + company.SelectedDepartment;
            }
        }
    }
}