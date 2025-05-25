using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.DTO.Logo
{
    public class AddLogoDTO
    {
        public string NombreLogo { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public byte[] Imagen { get; set; }
        public string Descripcion { get; set; }
        public bool StatusActivo { get; set; }
    }
}
