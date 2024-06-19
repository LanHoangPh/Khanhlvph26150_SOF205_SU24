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
    public class TrungtamRepo : ITrungtamRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public TrungtamRepo()
        {
        }

        public TrungtamRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddTrungtam(Trungtam Trungtam)
        {
            try
            {
                _dbContext.Trungtams.Add(Trungtam);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTrungtam(int id)
        {
            try
            {
                var Trungtam = _dbContext.Trungtams.Find(id);
                _dbContext.Trungtams.Remove(Trungtam);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditTrungtam(Trungtam Trungtam)
        {
            try
            {
                var updateTrungtam = _dbContext.Trungtams.Find(Trungtam.Id);
                updateTrungtam.Ten = Trungtam.Ten;
                updateTrungtam.Diachi = Trungtam.Diachi;
                _dbContext.Trungtams.Update(updateTrungtam);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Trungtam> GetAllTrungtam()
        {
            return _dbContext.Trungtams.ToList();
        }

        public Trungtam GetTrungtamById(int id)
        {
            return _dbContext.Trungtams.FirstOrDefault(x => x.Id == id);
        }

        public List<Trungtam> GetTrungtamByName(string name)
        {
            return _dbContext.Trungtams.Where(x => x.Ten.Contains(name)).ToList();
        }
    }
}