﻿using System;
using System.Collections.Generic;

namespace AutoSoftShop.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
