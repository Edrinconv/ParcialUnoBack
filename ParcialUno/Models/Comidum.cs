using System;
using System.Collections.Generic;

namespace ParcialUno.Models;

public partial class Comidum
{
    public int IdComida { get; set; }

    public string? NombreComida { get; set; }

    public int? PresentacionComidaKg { get; set; }

    public double? PrecioComida { get; set; }

    public int? StockComida { get; set; }
}
