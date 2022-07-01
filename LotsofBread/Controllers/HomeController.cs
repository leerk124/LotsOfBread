using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LotsofBread.Models;

namespace LotsofBread.Controllers
{
    public class HomeController : Controller //HomeController is inheriting the Controller Class
    {
        public ViewResult Index()
        {
            return View("HomePage");
        }

        public ViewResult Info()
        {
            return View("BusinessInfo");
        }

        public ViewResult Policies()
        {
            return View("BusinessPolicies");
        }

        public ViewResult News()
        {
            return View("NewsReleases");
        }

        public ViewResult Faq()
        {
            return View("Faq");
        }
    }
}
