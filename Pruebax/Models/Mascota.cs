using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pruebax.Models
{
    public class Mascota
    {
        public Mascota()
        {
        }
        public Mascota(string nombre)
        {
            Nombre = nombre;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
