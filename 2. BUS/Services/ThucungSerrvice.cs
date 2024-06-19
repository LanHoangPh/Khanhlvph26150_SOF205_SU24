using _1._DAL.Models;
using _1._DAL.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._BUS.Services
{
    public class ThucungSerrvice
    {
        public ThucungRepo thucungRepo = new ThucungRepo();

        public ThucungSerrvice()
        {
        }

        public ThucungSerrvice(ThucungRepo thucungRepo)
        {
            this.thucungRepo = thucungRepo;
        }

        public List<Thucung> GetAllThucung()
        {
            return thucungRepo.GetAllThucung();
        }
        public List<Thucung> GetThucungByName(string name)
        {
            return thucungRepo.GetThucungByName(name);
        }

        public List<Thucung> GetThucungByNameOrColor(string input)
        {
            return thucungRepo.GetThucungByNameOrColor(input);
        }

        public ArrayList GetMauLong()
        {
            return thucungRepo.GetMauLong();
        }

        public string AddThucung(Thucung thucung)
        {
            if (thucungRepo.AddThuCung(thucung))
            {
                return "Succeeded";
            }
            else
            {
                return "Failed";
            }
        }
        public string EditThucung(Thucung thucung)
        {
            if (thucungRepo.EditThuCung(thucung))
            {
                return "Succeeded";
            }
            else
            {
                return "Failed";
            }
        }
        public string DeleteThucung(int id)
        {
            if (thucungRepo.DeleteThuCung(id))
            {
                return "Succeeded";
            }
            else
            {
                return "Failed";
            }
        }
    }
}
