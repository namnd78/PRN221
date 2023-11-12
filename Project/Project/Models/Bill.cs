using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Bill
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? StaffId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public decimal? TotalPrice { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<ProductBill> ProductBills { get; set; } = new List<ProductBill>();

    public virtual Staff? Staff { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
