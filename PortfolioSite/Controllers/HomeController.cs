using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerpetuumSoft.Knockout;
using PortfolioSite.Models;

namespace PortfolioSite.Controllers
{
    public class HomeController: KnockoutController
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome...";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Projects";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Title = "Projects";
            return View(new ProjectsModel
            {
                Section_Current = "default"
            });
        }

        public ActionResult Resume()
        {
            return View();
        }
    }
}