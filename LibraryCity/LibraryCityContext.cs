using System;
using System.Collections.Generic;
using LibraryCity.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryCity;

public partial class LibraryCityContext : DbContext
{
    public LibraryCityContext()
    {
    }

    public LibraryCityContext(DbContextOptions<LibraryCityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Athor> Athors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookLoan> BookLoans { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<PublishingHouse> PublishingHouses { get; set; }

    public virtual DbSet<ReadBilet> ReadBilets { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=library_city;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Athor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("athors_pkey");

            entity.ToTable("athors");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AthorName).HasColumnName("athor_name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("books_pkey");

            entity.ToTable("books");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Annotation).HasColumnName("annotation");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.BookName).HasColumnName("book_name");
            entity.Property(e => e.Copy).HasColumnName("copy");
            entity.Property(e => e.IdAthor).HasColumnName("id_athor");
            entity.Property(e => e.IdGenre).HasColumnName("id_genre");
            entity.Property(e => e.IdPublishing).HasColumnName("id_publishing");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Page).HasColumnName("page");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Athor).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAthor)
                .HasConstraintName("books_id_athor_fkey");

            entity.HasOne(d => d.Genre).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdGenre)
                .HasConstraintName("books_id_genre_fkey");

            entity.HasOne(d => d.PublishingHouse).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdPublishing)
                .HasConstraintName("books_id_publishing_fkey");
        });

        modelBuilder.Entity<BookLoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("book_loans_pkey");

            entity.ToTable("book_loans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfCome).HasColumnName("date_of_come");
            entity.Property(e => e.DateOfComeFact).HasColumnName("date_of_come_fact");
            entity.Property(e => e.DateOfIssue).HasColumnName("date_of_issue");
            entity.Property(e => e.IdBook).HasColumnName("id_book");
            entity.Property(e => e.IdReadBilet).HasColumnName("id_read_bilet");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");

            entity.HasOne(d => d.Book).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdBook)
                .HasConstraintName("book_loans_id_book_fkey");

            entity.HasOne(d => d.ReadBilet).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdReadBilet)
                .HasConstraintName("book_loans_id_read_bilet_fkey");

            entity.HasOne(d => d.Status).WithMany(p => p.BookLoans)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("book_loans_id_status_fkey");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenreName).HasColumnName("genre_name");
        });

        modelBuilder.Entity<PublishingHouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("publishing_houses_pkey");

            entity.ToTable("publishing_houses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PublishingName).HasColumnName("publishing_name");
        });

        modelBuilder.Entity<ReadBilet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("read_bilet_pkey");

            entity.ToTable("read_bilets");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('read_bilet_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BiletName).HasColumnName("bilet_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdReadBilet).HasColumnName("id_read_bilet");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Surname).HasColumnName("surname");

            entity.HasOne(d => d.ReadBilet).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdReadBilet)
                .HasConstraintName("users_id_read_bilet_fkey");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("users_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
