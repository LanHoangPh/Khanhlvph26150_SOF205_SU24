using _1._DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.IRepositories
{
    internal interface INhacungcapRepo
    {
        List<Nhacungcap> GetAllNhacungcap();
        List<Nhacungcap> GetNhacungcapByName(string name);
        Nhacungcap GetNhacungcapById(int id);
        bool AddNhacungcap(Nhacungcap Nhacungcap);
        bool EditNhacungcap(Nhacungcap Nhacungcap);
        bool DeleteNhacungcap(int id);
    }
}
