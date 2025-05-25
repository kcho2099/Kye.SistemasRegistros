namespace Kye.SistemasRegistros.DTO.Planes;

public class ConsultaPlanesDTO
{
    public int Idplan { get; set; }
    public string NombrePlan { get; set; }
    public decimal CostoBase { get; set; }
    public int? DuracionMeses { get; set; }
    public string TienePromocion { get; set; }
    public string DescripcionPromocion { get; set; }
    public DateTime? FechaInicioPromocion { get; set; }
    public DateTime? FechaFinPromocion { get; set; }
    public string TipoDescuento { get; set; }
    public decimal? ValorDescuento { get; set; }
    public bool StatusActivo { get; set; }  
}
