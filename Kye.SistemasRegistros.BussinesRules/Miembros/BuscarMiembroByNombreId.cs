using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.CasosUso.Miembros
{
    public class BuscarMiembroByNombreId
    {
        DBSistemasRegistrosContext _context;

        public BuscarMiembroByNombreId(DBSistemasRegistrosContext context)
        {
            _context = context;
        }

        public async Task<(Miembro miembro, bool accion)> Buscar(string filtro)
        {
            try
            {
                int tryId = int.TryParse(filtro, out int id) ? id : 0;

                var miembro = await _context.Miembros
                    .FirstOrDefaultAsync(
                    m =>
                    m.NombreCompleto.Equals(filtro) ||
                    (tryId > 0 && m.Idmiembro == tryId));

                if (miembro is null)
                    return (null, false);

                return (miembro, true);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar miembros", ex);
            }
        }
    }
}
