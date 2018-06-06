using Pruebax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pruebax.Services
{
    public class MascotaRepositorio:IMascotaRepositorio
    {
        public List<Mascota> ObtenerTodos()
        {
            List<Mascota> perros = new List<Mascota>()
            { new Mascota("Lucero"),
              new Mascota("Lola")
            }; //{ "Lucero", "Lola" };
            return perros;
        }
    }
}
