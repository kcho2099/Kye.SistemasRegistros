using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Kye.SistemasRegistros.CasosUso.Contactos;

public class ConsultarContactos
{
    DBSistemasRegistrosContext _context;
    public ConsultarContactos(DBSistemasRegistrosContext context)
    {
        _context = context;
    }
    public async Task<(string Mensaje, bool Accion, List<ContactosEmergencia> Contactos)> Get(int idmiembro)
    {
        try
        {
            var contactos = await _context.ContactosEmergencias.AsNoTracking().Where(x => x.Idmiembro == idmiembro).ToListAsync();
            return ("Contactos encontrados", true, contactos);
        }
        catch (Exception ex)
        {
            return ($"Error al consultar los contactos : {ex.Message ?? ex.ToString()}", false, null);
        }
    }
}
