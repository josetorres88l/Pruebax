using Microsoft.AspNetCore.Mvc;
using Pruebax.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pruebax.ViewComponents
{
    public class MascotasViewComponent:ViewComponent
    {
        public MascotasViewComponent(IMascotaRepositorio repositorioMascota)
        {
            RepositorioMascota = repositorioMascota;
        }

        public IMascotaRepositorio RepositorioMascota { get; }

        public IViewComponentResult Invoke()
        {
            var Mascotas = RepositorioMascota.ObtenerTodos();
            return View(Mascotas);
        }
    }
}
