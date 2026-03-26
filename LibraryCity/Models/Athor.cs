using System;
using System.Collections.Generic;

namespace LibraryCity.Models;

public partial class Athor
{
    public int Id { get; set; }

    public string AthorName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
