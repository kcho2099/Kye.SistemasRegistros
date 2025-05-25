using Kye.SistemasRegistros.DTO.Usuarios;
using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Kye.SistemasRegistros.CasosUso.Usuarios;
public class BuscarUsuarios
{
    DBSistemasRegistrosContext _context;

    public BuscarUsuarios(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<IList<Usuario>> Consultar(ListUsuariosDTO consultaUsuarios)
    {
        try
        {
            var query = await _context.
                Usuarios.
                Where(
                x => (
                consultaUsuarios.NombreUsuario == string.Empty ||
                x.NombreUsuario == consultaUsuarios.NombreUsuario) &&
                (
                consultaUsuarios.Rol == string.Empty ||
                x.Rol == consultaUsuarios.Rol) &&
                (
                consultaUsuarios.Status == null ||
                x.StatusActivo == consultaUsuarios.Status)
                ).ToListAsync();

            return query;
        }
        catch (Exception ex)
        {
            return new List<Usuario>();
        }
    }


}
