using Kye.SistemasRegistros.DTO.Usuarios;
using Kye.SistemasRegistros.Entities;
using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Kye.SistemasRegistros.CasosUso.Usuarios
{
    public class AgregarUsuario
    {
        private readonly DBSistemasRegistrosContext _context;

        public AgregarUsuario(DBSistemasRegistrosContext context)
        {
            _context = context;
        }

        public async Task<(string, bool)> Agregar(AddUsuarioDTO addUsuario)
        {
            try
            {
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.NombreUsuario == addUsuario.NombreUsuario);

                if (usuario is not null)
                    return new("Usuario ya existe", false);

                _context
                    .Usuarios
                    .Add(
                    new Usuario
                    {
                        NombreUsuario = addUsuario.NombreUsuario,
                        ContraseñaHash = addUsuario.Password.EncriptarCadena(),
                        Rol = addUsuario.Rol,
                        StatusActivo = true
                    });

                await _context.SaveChangesAsync().ConfigureAwait(false);

                return new("Guardado Correctamente", true);
            }
            catch (Exception ex)
            {
                return new($"Error Usuarios : {ex.Message ?? ex.ToString()}", false); ;
            }

        }

    }
}
