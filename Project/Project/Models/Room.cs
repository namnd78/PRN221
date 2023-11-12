using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Room
{
    public int Id { get; set; }

    public int? SeatQuantity { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();
}
