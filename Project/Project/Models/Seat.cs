using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Seat
{
    public int Id { get; set; }

    public int? SeatNumer { get; set; }

    public string? Row { get; set; }

    public int? RoomId { get; set; }

    public virtual Room? Room { get; set; }

    public virtual ICollection<SeatSetting> SeatSettings { get; set; } = new List<SeatSetting>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
