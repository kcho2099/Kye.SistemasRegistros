using Kye.SistemasRegistros.Repositorio.Models;

namespace Kye.SistemasRegistros.CasosUso.Logos;

public class ConsultarLogosById
{
    DBSistemasRegistrosContext _context;
    public ConsultarLogosById(DBSistemasRegistrosContext context)
    {
        _context = context;
    }
    public async Task<(Logo,bool)> Consultar(int id)
    {
        try
        {
            var query = await _context.Logos.FindAsync(id);
            return (query,false);
        }
        catch (Exception ex)
        {
            return (new Logo(),false);
        }
    }
}
