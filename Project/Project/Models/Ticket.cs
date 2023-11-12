using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public int? BillId { get; set; }

    public int? ShowtimeId { get; set; }

    public int? SeatId { get; set; }

    public decimal? Price { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual Seat? Seat { get; set; }

    public virtual Showtime? Showtime { get; set; }
}
