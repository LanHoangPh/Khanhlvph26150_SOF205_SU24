using System;
using System.Collections.Generic;

namespace _1._DAL.Models;

public partial class Chunhan
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string? Diachi { get; set; }

    public virtual ICollection<Thucung> Thucungs { get; set; } = new List<Thucung>();
}
