using System;
using System.Collections.Generic;

namespace EFCoreScaffoldDatabase.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Rate { get; set; }
}
