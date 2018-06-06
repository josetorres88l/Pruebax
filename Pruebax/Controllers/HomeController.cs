using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pruebax.Models;
using Pruebax.Services;

namespace Pruebax.Controllers
{
    public class HomeController : Controller
    {
        public IMascotaRepositorio Repositorio { get;}
        public HomeController(IMascotaRepositorio repositorio)
        {
            Repositorio = repositorio;
        }
        public IActionResult Index()
        {
            var Perros = Repositorio.ObtenerTodos();
            return View(Perros);

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
