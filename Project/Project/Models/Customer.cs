using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
