using Pruebax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pruebax.Services
{
    public interface IMascotaRepositorio
    {
        List<Mascota> ObtenerTodos();
    }
}
