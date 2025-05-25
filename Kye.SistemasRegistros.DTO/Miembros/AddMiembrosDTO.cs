using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.DTO.Miembros;

public class AddMiembrosDTO
{
    public string NombreCompleto { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string Fotografia { get; set; }
    public string Celular { get; set; }
    public string WhatsApp { get; set; }
    public string CorreoElectronico { get; set; }
    public DateTime FechaRegistro { get; set; }
    public byte[] Idhuella { get; set; }
    public int IdUsuarioRegistro { get; set; }
}
