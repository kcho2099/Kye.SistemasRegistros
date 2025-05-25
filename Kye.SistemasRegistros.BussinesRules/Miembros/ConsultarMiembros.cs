using Kye.SistemasRegistros.DTO.Miembros;
using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Kye.SistemasRegistros.CasosUso.Miembros;

public class ConsultarMiembros
{
    private readonly DBSistemasRegistrosContext _context;


    public ConsultarMiembros(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<IList<ConsultarMiembrosDTO>> ConsultarClientes(string filtro)
    {
        int? idMiembro = int.TryParse(filtro, out int parsedId) ? parsedId : (int?)null;

        var consultaClientes = await _context.Miembros
            .Include(x=>x.Membresia)
            .ThenInclude(x => x.IdplanNavigation)
            .AsNoTracking()
            .Where(x =>
            (!idMiembro.HasValue && x.Idmiembro == idMiembro) ||
            (string.IsNullOrEmpty(filtro) && x.NombreCompleto.Contains(filtro)) &&
            x.StatusActivo
            )
            .Select(x=>new ConsultarMiembrosDTO {
                Clave = x.Idmiembro,
                NombreCompleto = x.NombreCompleto,
                FechaRegistro= x.FechaRegistro.ToString(),
                FechaNacimiento = x.FechaNacimiento.ToString(),
                CorreoElectronico = x.CorreoElectronico,
                Celular = x.Celular,
                WhatsApp = x.WhatsApp,
                NombrePlan= x.Membresia
                .Where(y=>y.StatusActivo)
                .OrderBy(x=>x.FechaInicio)
                .FirstOrDefault()
                .IdplanNavigation
                .NombrePlan            
            })
            .ToListAsync();

        return consultaClientes;
    }

}
