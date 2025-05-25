using Kye.SistemasRegistros.DTO;
using Kye.SistemasRegistros.DTO.Usuarios;
using Kye.SistemasRegistros.Entities;
using Kye.SistemasRegistros.Repositorio.Models;

namespace Kye.SistemasRegistros.CasosUso.Usuarios;

public class UpdateUsuario
{
    DBSistemasRegistrosContext _context;
    
    public UpdateUsuario(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<(string,bool)> Update(UsuarioDTO usuario)
    {
        try
        {
            var query = await _context.
                Usuarios.
                FindAsync(usuario.Idusuario);

            if(query is null)
                return ("No existe el usuario",false);

            query.NombreUsuario = usuario.NombreUsuario == query.NombreUsuario ? usuario.NombreUsuario : usuario.NombreUsuario;
            query.ContraseñaHash = string.IsNullOrEmpty(usuario.ContraseñaHash) ? query.ContraseñaHash : usuario.ContraseñaHash.EncriptarCadena()  ;
            query.Rol = usuario.Rol == query.Rol ? usuario.Rol : usuario.Rol;
            
            await _context.SaveChangesAsync();

            return ("Usuario actualizado",true);
        }
        catch (Exception ex)
        {
            return ($"Error al aactualizar el usuario :{ex.Message??ex.ToString()}",false);
        }
    }
}
