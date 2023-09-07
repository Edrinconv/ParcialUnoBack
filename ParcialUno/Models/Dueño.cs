using System;
using System.Collections.Generic;

namespace ParcialUno.Models;

public partial class Dueño
{
    public int IdDueño { get; set; }

    public string? NombreDueño { get; set; }

    public int? TelefonoDueño { get; set; }

    public string? CorreoDueño { get; set; }

    public string? DireccionDueño { get; set; }
}
