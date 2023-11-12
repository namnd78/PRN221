﻿using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<ProductBill> ProductBills { get; set; } = new List<ProductBill>();
}
