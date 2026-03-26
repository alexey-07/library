using System;
using System.Collections.Generic;

namespace LibraryCity.Models;

public partial class PublishingHouse
{
    public int Id { get; set; }

    public string PublishingName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
