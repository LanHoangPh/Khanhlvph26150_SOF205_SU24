using _1._DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.IRepositories
{
    internal interface ICongtyRepo
    {
        List<Congty> GetAllCongty();
        List<Congty> GetCongtyByName(string name);
        Congty GetCongtyById(int id);
        bool AddCongty(Congty Congty);
        bool EditCongty(Congty Congty);
        bool DeleteCongty(int id);
    }
}
