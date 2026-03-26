using System;
using System.Collections.Generic;

namespace LibraryCity.Models;

public partial class User
{
    public int Id { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdRole { get; set; }

    public int IdReadBilet { get; set; }

    public virtual ReadBilet IdReadBiletNavigation { get; set; } = null!;

    public virtual Role IdRoleNavigation { get; set; } = null!;
}
