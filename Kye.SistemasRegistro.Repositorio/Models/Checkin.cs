﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Kye.SistemasRegistros.Repositorio.Models;

public partial class Checkin
{
    public int IdcheckIn { get; set; }

    public int Idmiembro { get; set; }

    public DateTime FechaHoraEntrada { get; set; }

    public DateTime? FechaHoraSalida { get; set; }

    public string MetodoEntrada { get; set; }

    public bool StatusActivo { get; set; }

    public virtual Miembro IdmiembroNavigation { get; set; }
}