using _1._DAL.Models;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._DAL.Repositories
{
    public class ChunhanRepo : IChunhanRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public ChunhanRepo()
        {
        }

        public ChunhanRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddChuNhan(Chunhan chunhan)
        {
            try
            {
                _dbContext.Chunhans.Add(chunhan);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteChuNhan(int id)
        {
            try
            {
                var chunhan = _dbContext.Chunhans.Find(id);
                _dbContext.Chunhans.Remove(chunhan);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditChuNhan(Chunhan chunhan)
        {
            try
            {
                var updateChunhan = _dbContext.Chunhans.Find(chunhan.Id);
                updateChunhan.Ten = chunhan.Ten;
                updateChunhan.Diachi = chunhan.Diachi;
                _dbContext.Chunhans.Update(updateChunhan);
                _dbContext.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public List<Chunhan> GetAllChunhan()
        {
            return _dbContext.Chunhans.ToList();
        }

        public Chunhan GetChunhanById(int id)
        {
            return _dbContext.Chunhans.FirstOrDefault(x=>x.Id == id);
        }

        public List<Chunhan> GetChunhanByName(string name)
        {
            return _dbContext.Chunhans.Where(x=>x.Ten.Contains(name)).ToList();
        }
    }
}