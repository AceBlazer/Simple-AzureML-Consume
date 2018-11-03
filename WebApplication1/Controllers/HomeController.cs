using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using azureMLtest.Services.CreditService;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services.CreditService;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var guaranteed = new CreditPredictionService().PreApproveCredit().Result.Split('"')[7];
            double pred = Double.Parse(new CreditPredictionService().PreApproveCredit().Result.Split('"')[11]);

            if ((guaranteed.Equals("true") && pred>0.5) || (guaranteed.Equals("false") && pred < 0.5)) {
                ViewData["Message1"] = "Guaranteed :)";
            }
            else
            {
                ViewData["Message1"] = "not guaranteed :(";
            }

            ViewData["Message2"] = "i am " + ((1 - pred) * 100).ToString() + " % sure ";

            return View();
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
