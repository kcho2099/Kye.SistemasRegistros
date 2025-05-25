using Kye.SistemasRegistros.Entities;
using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Kye.SistemasRegistros.CasosUso.Usuarios;

public class Login
{
    DBSistemasRegistrosContext _context;

    public Login(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<(Usuario usuario, bool accion)> Autenticar(string nombreUsuario, string password)
    {
        try
        {
            password = password.EncriptarCadena();

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u =>
                u.NombreUsuario == nombreUsuario &&
                u.ContraseñaHash == password &&
                u.StatusActivo == true
                );

            if (usuario is null)
            {
                return (null, false);
            }

            SesionUsuario.IdUsuario = usuario.Idusuario;
            SesionUsuario.NombreUsuario = usuario.NombreUsuario;
            SesionUsuario.Rol = usuario.Rol;

            return (usuario, true);
        }
        catch (Exception ex)
        {
            throw new Exception("Error al autenticar usuario", ex);

        }

    }
}