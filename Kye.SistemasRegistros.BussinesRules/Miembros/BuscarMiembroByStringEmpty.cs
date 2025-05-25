using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Kye.SistemasRegistros.CasosUso.Miembros;


public class BuscarMiembroByStringEmpty
{
    private readonly DBSistemasRegistrosContext _context;

    public BuscarMiembroByStringEmpty(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<Miembro> Buscar(string filtro)
    {
        try
        {
            var query = await _context.Miembros
                .Where(
                x => (               
                x.NombreCompleto == filtro) &&
                (                                        
                x.Celular == filtro) &&                
                (                                         
                x.FechaNacimiento == null)                
                ).FirstOrDefaultAsync();
            return query;
        }
        catch (Exception ex)
        {
            return null;
        }
    }


}
