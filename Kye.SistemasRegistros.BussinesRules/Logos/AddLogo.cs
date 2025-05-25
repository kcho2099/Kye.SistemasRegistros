using Kye.SistemasRegistros.DTO.Logo;
using Kye.SistemasRegistros.Repositorio.Models;

namespace Kye.SistemasRegistros.CasosUso.Logos;

public class AddLogo
{
    DBSistemasRegistrosContext _context;

    public AddLogo(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<(string,bool)> Add(AddLogoDTO logo)
    {
        try
        {
            _context.Logos.Add(new Logo
            {
                NombreLogo = logo.NombreLogo,
                Alto = logo.Alto,
                Ancho = logo.Ancho,
                Descripcion = logo.Descripcion,
                Imagen = logo.Imagen,
                StatusActivo = true
            });
            await _context.SaveChangesAsync();
            return  ("Logo agregado",true);
        }
        catch (Exception ex)
        {
            return ($"Error al agregar el logo : {ex.Message??ex.ToString()}", false);
        }
    }
}
