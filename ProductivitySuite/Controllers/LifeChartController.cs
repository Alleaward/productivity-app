using ProductivitySuite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductivitySuite.Controllers
{
    public class LifeChartController : Controller
    {
        // GET: LifeChart
        public ActionResult Index()
        {
            // Create a view allowing user to select time period (Day, Week, Month, Year)

            // Highlight time past, green if goals achieved, red if not achieved
            // 
            return View();
        }
    }
}