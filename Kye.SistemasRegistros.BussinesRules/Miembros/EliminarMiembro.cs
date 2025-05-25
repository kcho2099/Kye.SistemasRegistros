using Kye.SistemasRegistros.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.CasosUso.Miembros
{
    public class EliminarMiembro
    {
        DBSistemasRegistrosContext _context;

        public EliminarMiembro(DBSistemasRegistrosContext context)
        {
            _context = context;
        }

        public async Task<(string Mensaje,bool Accion)> Eliminar(int idMiembro)
        {
            var miembro = await _context.Miembros.FindAsync(idMiembro);
            if (miembro == null)
            {
                return new ("El cliente no existe", false);
            }
            miembro.StatusActivo = false;
            await _context.SaveChangesAsync();
            return new("Cliente actualizado", true); ;
        }
    }
}
