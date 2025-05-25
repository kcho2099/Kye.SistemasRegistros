using Kye.SistemasRegistros.Repositorio.Models;

namespace Kye.SistemasRegistros.CasosUso.Usuarios;

public class ConsultaUsuarioById
{
    DBSistemasRegistrosContext _context;

    public ConsultaUsuarioById(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<(Usuario, bool)> Consultar(int id)
    {
        try
        {
            var query = await _context.
                Usuarios.
                FindAsync(id);
            return (query, true);
        }
        catch (Exception ex)
        {
            return (null, false);
        }
    }
}
