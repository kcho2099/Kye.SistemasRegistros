using Kye.SistemasRegistros.DTO;
using Kye.SistemasRegistros.Repositorio.Models;

namespace Kye.SistemasRegistros.CasosUso.Miembros
{
    public class ActualizarMiembro
    {
        DBSistemasRegistrosContext _context;

        public ActualizarMiembro(DBSistemasRegistrosContext context)
        {
            _context = context;
        }

        public async Task<(string mensaje, bool accion)> Update(UpdateMiembroDTO update)
        {

            var buscar = await _context.Miembros.FindAsync(update.Id);

            if (buscar is null)
                return ("No existe el miembro", false);

            buscar.NombreCompleto = update.NombreCompleto == buscar.NombreCompleto ? buscar.NombreCompleto : update.NombreCompleto;
            buscar.FechaNacimiento = update.FechaNacimiento == buscar.FechaNacimiento ? buscar.FechaNacimiento : update.FechaNacimiento;
            buscar.Fotografia = update.Fotografia == buscar.Fotografia ? buscar.Fotografia : update.Fotografia;
            buscar.Celular = update.Celular == buscar.Celular ? buscar.Celular : update.Celular;
            buscar.WhatsApp = update.WhatsApp == buscar.WhatsApp ? buscar.WhatsApp : update.WhatsApp;
            buscar.CorreoElectronico = update.CorreoElectronico == buscar.CorreoElectronico ? buscar.CorreoElectronico : update.CorreoElectronico;
            buscar.Idhuella = update.Idhuella == buscar.Idhuella ? buscar.Idhuella : update.Idhuella;

            await _context.SaveChangesAsync();

            return ("Cliente actualizado", true);
        }
    }
}
