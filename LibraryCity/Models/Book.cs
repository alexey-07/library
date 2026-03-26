using System;
using System.Collections.Generic;

namespace LibraryCity.Models;

public partial class Book
{
    public int Id { get; set; }

    public string BookName { get; set; } = null!;

    public int IdAthor { get; set; }

    public int IdGenre { get; set; }

    public int IdPublishing { get; set; }

    public int Year { get; set; }

    public int Page { get; set; }

    public int Copy { get; set; }

    public int Available { get; set; }

    public string Annotation { get; set; } = null!;

    public string? Image { get; set; }

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Athor Athor { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual PublishingHouse PublishingHouse { get; set; } = null!;
}
