using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandingApp.ViewModels;
using Microsoft.AspNetCore.Mvc;



namespace LandingApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Start()
        {
            HomeViewModel obj = new HomeViewModel();
            return View(obj);
        }


    }
}

