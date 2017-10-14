using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KudVenkat.Models;
using System.Text;

namespace KudVenkat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public ActionResult CheckBox()
        {
            MVCDataModel dataModel = new MVCDataModel();

            return View(dataModel.Cities);
        }
        [HttpPost]
        public string CheckBox(IEnumerable<City> cities)
        {
            if(cities.Count(x=>x.IsSelected)==0)
            {
                return "Please select city";

            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("selected cities are ");

                foreach (var item in cities)
                {
                    if(item.IsSelected)
                    {
                        sb.Append(item.Name + ",");

                    }
                }
                sb.Remove(sb.ToString().LastIndexOf(','), 1);
                return sb.ToString();
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