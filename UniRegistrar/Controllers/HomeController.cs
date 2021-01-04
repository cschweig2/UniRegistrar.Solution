using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniRegistrar.Models;

namespace UniRegistrar.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}