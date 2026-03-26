using System;
using System.Collections.Generic;

namespace LibraryCity.Models;

public partial class ReadBilet
{
    public int Id { get; set; }

    public string BiletName { get; set; } = null!;

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
