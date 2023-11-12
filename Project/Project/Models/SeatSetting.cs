using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class SeatSetting
{
    public int Id { get; set; }

    public int? SeatId { get; set; }

    public int? ShowtimeId { get; set; }

    public int? Status { get; set; }

    public virtual Seat? Seat { get; set; }

    public virtual Showtime? Showtime { get; set; }
}
