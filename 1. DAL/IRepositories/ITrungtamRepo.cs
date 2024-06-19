using _1._DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.IRepositories
{
    internal interface ITrungtamRepo
    {
        List<Trungtam> GetAllTrungtam();
        List<Trungtam> GetTrungtamByName(string name);
        Trungtam GetTrungtamById(int id);
        bool AddTrungtam(Trungtam Trungtam);
        bool EditTrungtam(Trungtam Trungtam);
        bool DeleteTrungtam(int id);
    }
}
