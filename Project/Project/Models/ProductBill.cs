﻿using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class ProductBill
{
    public int Id { get; set; }

    public int? BillId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual Product? Product { get; set; }
}
