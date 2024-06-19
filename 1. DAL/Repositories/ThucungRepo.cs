using _1._DAL.IRepositories;
using _1._DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.Repositories
{
    public class ThucungRepo : IThucungRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public ThucungRepo()
        {
        }

        public ThucungRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddThuCung(Thucung Thucung)
        {
            try
            {
                _dbContext.Thucungs.Add(Thucung);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteThuCung(int id)
        {
            try
            {
                var Thucung = _dbContext.Thucungs.Find(id);
                _dbContext.Thucungs.Remove(Thucung);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditThuCung(Thucung Thucung)
        {
            try
            {
                var updateThucung = _dbContext.Thucungs.Find(Thucung.Id);
                updateThucung.Ten = Thucung.Ten;
                updateThucung.Loai = Thucung.Loai;
                updateThucung.Maulong = Thucung.Maulong;
                updateThucung.Tuoi = Thucung.Tuoi;
                _dbContext.Thucungs.Update(updateThucung);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Thucung> GetAllThucung()
        {
            return _dbContext.Thucungs.ToList();
        }

        public Thucung GetThucungById(int id)
        {
            return _dbContext.Thucungs.FirstOrDefault(x => x.Id == id);
        }

        public List<Thucung> GetThucungByName(string name)
        {
            return _dbContext.Thucungs.Where(x => x.Ten.Contains(name)).ToList();
        }

        public List<Thucung> GetThucungByNameOrColor(string input)
        {
            return _dbContext.Thucungs.Where(x=>x.Ten.Contains(input)|| x.Maulong.Contains(input)).ToList();
        }

        public ArrayList GetMauLong()
        {
             ArrayList mauLong = new() ;
            List<Thucung> thucungs = _dbContext.Thucungs.ToList();

            
            foreach(Thucung t in thucungs)
            {
                
                mauLong.Add(t.Maulong);
            }
            return mauLong;
        }
    }
}