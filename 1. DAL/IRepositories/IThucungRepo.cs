using _1._DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.IRepositories
{
    internal interface IThucungRepo
    {
        List<Thucung> GetAllThucung();
        List<Thucung> GetThucungByName(string name);
        List<Thucung> GetThucungByNameOrColor(string input);
        ArrayList GetMauLong();
        Thucung GetThucungById(int id);
        bool AddThuCung(Thucung thucung);
        bool EditThuCung(Thucung thucung);
        bool DeleteThuCung(int id);
    }
}
