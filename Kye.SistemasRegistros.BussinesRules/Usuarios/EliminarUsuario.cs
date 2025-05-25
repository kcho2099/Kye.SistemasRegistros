using Kye.SistemasRegistros.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.CasosUso.Usuarios;

public class EliminarUsuario
{
    DBSistemasRegistrosContext _context;

    public EliminarUsuario(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<(string, bool)> Eliminar(int id)
    {
        try
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario is null)
                return new("Usuario no existe", false);
            usuario.StatusActivo = false;
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return new("Eliminado Correctamente", true);
        }
        catch (Exception ex)
        {
            return new($"Error Usuarios : {ex.Message ?? ex.ToString()}", false); ;
        }
    }
}
