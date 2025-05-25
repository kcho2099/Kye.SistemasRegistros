using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.DTO.Planes
{
    public class PlanesDTO
    {
        public int Idplan { get; set; }

        public string NombrePlan { get; set; }

        public decimal CostoBase { get; set; }

        public int? DuracionMeses { get; set; }

        public bool TienePromocion { get; set; }

        public string DescripcionPromocion { get; set; }

        public DateTime? FechaInicioPromocion { get; set; }

        public DateTime? FechaFinPromocion { get; set; }

        public string TipoDescuento { get; set; }

        public decimal? ValorDescuento { get; set; }

        public bool StatusActivo { get; set; }
    }
}
