using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppTourist.Models;

namespace WebAppTourist.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DBToutisrContext db = new DBToutisrContext();
            List < Attraction > list = db.Attraction.ToList();
         
            return View(list);
        }
    }
}
