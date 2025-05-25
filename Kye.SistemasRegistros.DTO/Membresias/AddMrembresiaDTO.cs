using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.DTO.Membresias;

public class AddMrembresiaDTO
{
    public int IdMiembro { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; }
    public DateTime FechaProximoPago { get; set; }
    public int IdPlan { get; set; }
    public int Idusuario { get; set; }
}
