using Kye.SistemasRegistros.DTO.Planes;
using Kye.SistemasRegistros.Repositorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Kye.SistemasRegistros.CasosUso.Planes;

public class ConsultarPlanes
{
    private readonly DBSistemasRegistrosContext _context;

    public ConsultarPlanes(DBSistemasRegistrosContext context)
    {
        _context = context;
    }

    public async Task<(string Mensaje, bool Accion, List<ConsultaPlanesDTO> Planes)> Get(string filtro)
    {
        try
        {
            var query = _context.Planes.AsNoTracking()
                .Where(x => x.StatusActivo == true);

            // Aplicar filtro solo si no es nulo ni vacío
            if (!string.IsNullOrEmpty(filtro))
            {
                query = query.Where(x => x.NombrePlan.Contains(filtro));
            }

            // Filtrar por fechas si los valores existen
            query = query.Where(x =>
                (x.FechaInicioPromocion == null || EF.Functions.DateDiffDay(x.FechaInicioPromocion, DateTime.Now) >= 0) &&
                (x.FechaFinPromocion == null || EF.Functions.DateDiffDay(x.FechaFinPromocion, DateTime.Now) <= 0)
            );

            var planes = await query
                .OrderBy(x => x.NombrePlan)
                .Select(x => new ConsultaPlanesDTO
                {
                    Idplan = x.Idplan,
                    NombrePlan = x.NombrePlan,
                    CostoBase = x.CostoBase,
                    DescripcionPromocion = x.DescripcionPromocion,
                    DuracionMeses = x.DuracionMeses,
                    FechaFinPromocion = x.FechaFinPromocion,
                    FechaInicioPromocion = x.FechaInicioPromocion,
                    StatusActivo = x.StatusActivo,
                    TienePromocion = !x.TienePromocion?"NO":"SI",
                    TipoDescuento = x.TipoDescuento,
                    ValorDescuento = x.ValorDescuento,
                }).ToListAsync();

            return ("Planes consultados", true, planes);
        }
        catch (Exception ex)
        {
            return ($"Error al consultar los planes : {ex.Message ?? ex.ToString()}", false, null);
        }
    }
}
