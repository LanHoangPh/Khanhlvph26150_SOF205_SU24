using System;
using System.Collections.Generic;

namespace _1._DAL.Models;

public partial class Nhanvien
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string? Sodienthoai { get; set; }

    public DateOnly? Ngaytuyendung { get; set; }

    public int? IdCn { get; set; }

    public virtual Congty? IdCnNavigation { get; set; }
}
