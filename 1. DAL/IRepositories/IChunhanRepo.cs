using _1._DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface IChunhanRepo
    {
        List<Chunhan> GetAllChunhan();
        List<Chunhan> GetChunhanByName(string name);
        Chunhan GetChunhanById(int id);
        bool AddChuNhan(Chunhan chunhan);
        bool EditChuNhan(Chunhan chunhan);
        bool DeleteChuNhan(int id);
    }
}
