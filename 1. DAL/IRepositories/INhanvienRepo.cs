using _1._DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.IRepositories
{
    internal interface INhanvienRepo
    {
        List<Nhanvien> GetAllNhanvien();
        List<Nhanvien> GetNhanvienByName(string name);
        Nhanvien GetNhanvienById(int id);
        bool AddNhanvien(Nhanvien Nhanvien);
        bool EditNhanvien(Nhanvien Nhanvien);
        bool DeleteNhanvien(int id);
    }
}
