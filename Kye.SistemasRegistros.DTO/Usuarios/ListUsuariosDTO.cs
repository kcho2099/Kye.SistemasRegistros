using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.DTO.Usuarios
{
    public class ListUsuariosDTO
    {
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
        public bool? Status { get; set; }
    }
}
