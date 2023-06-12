using System;
using System.Collections.Generic;

namespace EFCoreScaffoldDatabase.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
}
