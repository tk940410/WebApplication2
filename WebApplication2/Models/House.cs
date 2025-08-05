using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class House
{
    public int HouseID { get; set; }

    public string Name { get; set; } = null!;

    public int Year { get; set; }

    public int Floor { get; set; }

    public int Price { get; set; }

    public bool Enable { get; set; }
}
