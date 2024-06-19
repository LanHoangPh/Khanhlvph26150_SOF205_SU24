using _1._DAL.IRepositories;
using _1._DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.Repositories
{
    public class CongtyRepo : ICongtyRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public CongtyRepo()
        {
        }

        public CongtyRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddCongty(Congty Congty)
        {
            try
            {
                _dbContext.Congties.Add(Congty);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCongty(int id)
        {
            try
            {
                var Congty = _dbContext.Congties.Find(id);
                _dbContext.Congties.Remove(Congty);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditCongty(Congty Congty)
        {
            try
            {
                var updateCongty = _dbContext.Congties.Find(Congty.Id);
                updateCongty.Ten = Congty.Ten;
                updateCongty.Diachi = Congty.Diachi;
                _dbContext.Congties.Update(updateCongty);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Congty> GetAllCongty()
        {
            return _dbContext.Congties.ToList();
        }

        public Congty GetCongtyById(int id)
        {
            return _dbContext.Congties.FirstOrDefault(x => x.Id == id);
        }

        public List<Congty> GetCongtyByName(string name)
        {
            return _dbContext.Congties.Where(x => x.Ten.Contains(name)).ToList();
        }
    }
}