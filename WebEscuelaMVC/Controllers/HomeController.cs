using Microsoft.AspNetCore.Mvc;
using System;

namespace WebEscuelaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenidos a la escuela";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
    }
}
