using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? RunningTime { get; set; }

    public string? Country { get; set; }

    public string? Description { get; set; }

    public int? ReleaseYear { get; set; }

    public int? GenreId { get; set; }

    public string? Director { get; set; }

    public string? Image { get; set; }

    public virtual Genre? Genre { get; set; }

    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();
}
