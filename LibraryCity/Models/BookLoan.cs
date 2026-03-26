using System;
using System.Collections.Generic;

namespace LibraryCity.Models;

public partial class BookLoan
{
    public int Id { get; set; }

    public int IdReadBilet { get; set; }

    public DateOnly DateOfIssue { get; set; }

    public DateOnly DateOfCome { get; set; }

    public DateOnly? DateOfComeFact { get; set; }

    public int IdStatus { get; set; }

    public int IdBook { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual ReadBilet ReadBilet { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
