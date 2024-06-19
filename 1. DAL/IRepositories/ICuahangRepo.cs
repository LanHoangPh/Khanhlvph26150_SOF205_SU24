using _1._DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.IRepositories
{
    internal interface ICuahangRepo
    {
        List<Cuahang> GetAllCuahang();
        List<Cuahang> GetCuahangByName(string name);
        Cuahang GetCuahangById(int id);
        bool AddCuaHang(Cuahang Cuahang);
        bool EditCuaHang(Cuahang Cuahang);
        bool DeleteCuaHang(int id);
    }
}
