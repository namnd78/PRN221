using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project.Models;

public partial class ProjectPrn221Context : DbContext
{
    public ProjectPrn221Context()
    {
    }

    public ProjectPrn221Context(DbContextOptions<ProjectPrn221Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductBill> ProductBills { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<SeatSetting> SeatSettings { get; set; }

    public virtual DbSet<Showtime> Showtimes { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); IConfigurationRoot configuration = builder.Build(); optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
    } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bill__3214EC07E781D0C7");

            entity.ToTable("Bill");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bills)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Bill__CustomerId__398D8EEE");

            entity.HasOne(d => d.Staff).WithMany(p => p.Bills)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK__Bill__StaffId__3A81B327");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07CE508C04");

            entity.ToTable("Customer");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Genre__3214EC07AEC53108");

            entity.ToTable("Genre");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movie__3214EC070456AFFB");

            entity.ToTable("Movie");

            entity.HasOne(d => d.Genre).WithMany(p => p.Movies)
                .HasForeignKey(d => d.GenreId)
                .HasConstraintName("FK__Movie__GenreId__2F10007B");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC07CC72FF43");

            entity.ToTable("Product");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ProductBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductB__3214EC0730B59DCE");

            entity.ToTable("ProductBill");

            entity.HasOne(d => d.Bill).WithMany(p => p.ProductBills)
                .HasForeignKey(d => d.BillId)
                .HasConstraintName("FK__ProductBi__BillI__440B1D61");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductBills)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductBi__Produ__44FF419A");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Room__3214EC0742A94F60");

            entity.ToTable("Room");
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Seat__3213E83F0E90B6FE");

            entity.ToTable("Seat");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Room).WithMany(p => p.Seats)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__Seat__RoomId__286302EC");
        });

        modelBuilder.Entity<SeatSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SeatSett__3213E83FB3E80270");

            entity.ToTable("SeatSetting");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.HasOne(d => d.Seat).WithMany(p => p.SeatSettings)
                .HasForeignKey(d => d.SeatId)
                .HasConstraintName("FK__SeatSetti__SeatI__35BCFE0A");

            entity.HasOne(d => d.Showtime).WithMany(p => p.SeatSettings)
                .HasForeignKey(d => d.ShowtimeId)
                .HasConstraintName("FK__SeatSetti__Showt__36B12243");
        });

        modelBuilder.Entity<Showtime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Showtime__3214EC0759F7DC97");

            entity.ToTable("Showtime");

            entity.Property(e => e.ShowDate).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TicketPrice).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Movie).WithMany(p => p.Showtimes)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK__Showtime__MovieI__31EC6D26");

            entity.HasOne(d => d.Room).WithMany(p => p.Showtimes)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__Showtime__RoomId__32E0915F");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Staff__3214EC07B242459E");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ticket__3214EC076E446B4C");

            entity.ToTable("Ticket");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Bill).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.BillId)
                .HasConstraintName("FK__Ticket__BillId__3D5E1FD2");

            entity.HasOne(d => d.Seat).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.SeatId)
                .HasConstraintName("FK__Ticket__SeatId__3F466844");

            entity.HasOne(d => d.Showtime).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ShowtimeId)
                .HasConstraintName("FK__Ticket__Showtime__3E52440B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
