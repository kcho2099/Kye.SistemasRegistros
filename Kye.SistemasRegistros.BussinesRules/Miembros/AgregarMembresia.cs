using Kye.SistemasRegistros.DTO.Membresias;
using Kye.SistemasRegistros.Entities.Enum;
using Kye.SistemasRegistros.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.CasosUso.Miembros;

public class AgregarMembresia
{
    private readonly DBSistemasRegistrosContext _context;
    public AgregarMembresia(DBSistemasRegistrosContext context)
    {
        _context = context;
    }
    public async Task<(string mensaje, bool accion)> Add(AddMrembresiaDTO datosMembresia)
    {
        try
        {
            var miembro = await _context.Miembros.FindAsync(datosMembresia.IdMiembro);
            if (miembro is null)
                return ("No existe el miembro", false);

            var membresia = new Membresia
            {
                Idmiembro = datosMembresia.IdMiembro,
                FechaInicio = datosMembresia.FechaInicio,
                FechaFin = datosMembresia.FechaFin,
                Idplan = datosMembresia.IdPlan,
                FechaProximoPago = datosMembresia.FechaProximoPago,
                StatusActivo = true,
                Observaciones = string.Empty,
                ColorSemaforo = SemaforoEnum.Verde.ToString(),


            };
            _context.Membresias.Add(membresia);
            await _context.SaveChangesAsync();
            return ("Membresia agregada", true);
        }
        catch (Exception ex)
        {
            return (ex.Message, false);
        }
    }
}
