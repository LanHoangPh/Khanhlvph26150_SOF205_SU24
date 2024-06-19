using _1._DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.IRepositories
{
    internal interface ISanphamRepo
    {
        List<Sanpham> GetAllSanpham();
        List<Sanpham> GetSanphamByName(string name);
        Sanpham GetSanphamById(int id);
        bool AddSanpham(Sanpham Sanpham);
        bool EditSanpham(Sanpham Sanpham);
        bool DeleteSanpham(int id);
    }
}
