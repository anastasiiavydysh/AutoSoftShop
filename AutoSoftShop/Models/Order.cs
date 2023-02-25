using System;
using System.Collections.Generic;

namespace AutoSoftShop.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? ClientId { get; set; }

    public DateTime? RequestTime { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Product? Product { get; set; }
}
