using Kye.SistemasRegistros.DTO.Miembros;
using Kye.SistemasRegistros.Repositorio.Models;

namespace Kye.SistemasRegistros.CasosUso.Miembros;

public class AgregarMiembro
{
    DBSistemasRegistrosContext _context;

    public AgregarMiembro(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<(string Mensaje, bool Accion, Miembro Cliente)> Add(AddMiembrosDTO miembro)
    {
        try
        {
            var cliente = new Miembro
            {
                NombreCompleto = miembro.NombreCompleto,
                Celular = miembro.Celular,
                CorreoElectronico = miembro.CorreoElectronico,
                Fotografia = miembro.Fotografia,
                FechaRegistro = DateTime.Now,
                Idhuella = miembro.Idhuella,
                FechaNacimiento = miembro.FechaNacimiento,
                WhatsApp = miembro.WhatsApp,
                StatusActivo = true,
                IdusuarioRegistro = miembro.IdUsuarioRegistro,
            };

            _context.Miembros.Add(cliente);
            await _context.SaveChangesAsync();
            return ("Miembro agregado", true, cliente);
        }
        catch (Exception ex)
        {
            return ($"Error al agregar el miembro : {ex.Message ?? ex.ToString()}", false, null);
        }
    }
}
