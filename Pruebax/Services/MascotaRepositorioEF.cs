using Pruebax.Data;
using Pruebax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pruebax.Services
{
    public class MascotaRepositorioEF:IMascotaRepositorio
    {
        public MascotaRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }

        public List<Mascota> ObtenerTodos()
        {
            return DbContext.Mascotas.ToList();
        }

    }
}
