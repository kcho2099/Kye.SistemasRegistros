using Kye.SistemasRegistros.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.CasosUso.Contactos
{
    public class EliminarContacto
    {
        DBSistemasRegistrosContext _context;

        public EliminarContacto(DBSistemasRegistrosContext context)
        {
            _context = context;
        }

        public async Task<(string Mensaje, bool Accion)> Delete(int id)
        {
            try
            {
                var contacto = await _context.ContactosEmergencias.FindAsync(id);
                if (contacto is null)
                    return ("No existe el contacto", false);
                _context.ContactosEmergencias.Remove(contacto);
                await _context.SaveChangesAsync();
                return ("Contacto eliminado", true);
            }
            catch (Exception ex)
            {
                return ($"Error al eliminar el contacto : {ex.Message ?? ex.ToString()}", false);
            }
        }
    }
}
