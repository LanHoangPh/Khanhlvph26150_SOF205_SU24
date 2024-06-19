using System;
using System.Collections.Generic;

namespace _1._DAL.Models;

public partial class Sanpham
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string Mota { get; set; } = null!;

    public int? Soluongtonkho { get; set; }

    public int? Giatien { get; set; }

    public int? IdNcc { get; set; }

    public virtual Nhacungcap? IdNccNavigation { get; set; }
}
