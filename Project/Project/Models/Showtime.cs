using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Showtime
{
    public int Id { get; set; }

    public int? MovieId { get; set; }

    public int? RoomId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? ShowDate { get; set; }

    public decimal? TicketPrice { get; set; }

    public virtual Movie? Movie { get; set; }

    public virtual Room? Room { get; set; }

    public virtual ICollection<SeatSetting> SeatSettings { get; set; } = new List<SeatSetting>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
