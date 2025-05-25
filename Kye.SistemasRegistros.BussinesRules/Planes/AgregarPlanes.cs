using Kye.SistemasRegistros.DTO.Planes;
using Kye.SistemasRegistros.Repositorio.Models;

namespace Kye.SistemasRegistros.CasosUso.Planes;

public class AgregarPlanes(DBSistemasRegistrosContext _context)
{

    public async Task<(string mensaje, bool accion)> Agregar(PlanesDTO planes)
    {
        try
        {
            await _context.Planes.AddAsync(
                new Plane
                {
                    NombrePlan = planes.NombrePlan,
                    DescripcionPromocion = planes.DescripcionPromocion,
                    CostoBase = planes.CostoBase,
                    DuracionMeses = planes.DuracionMeses,
                    FechaFinPromocion = planes.FechaFinPromocion,
                    FechaInicioPromocion = planes.FechaInicioPromocion,
                    StatusActivo = true,
                    TienePromocion = planes.TienePromocion,
                    TipoDescuento = planes.TipoDescuento,
                    ValorDescuento = planes.ValorDescuento
                });
            await _context.SaveChangesAsync();
            return ("Plan agregado correctamente", true);
        }
        catch (Exception ex)
        {
            return (ex.Message, false);

        }

    }
}
