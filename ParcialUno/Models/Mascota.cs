using System;
using System.Collections.Generic;

namespace ParcialUno.Models;

public partial class Mascota
{
    public int IdMascota { get; set; }

    public string? NombreMascota { get; set; }

    public double? PesoMascota { get; set; }

    public double? TamañoMascota { get; set; }

    public string? RazaMascota { get; set; }
}
