using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Staff
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Gender { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
