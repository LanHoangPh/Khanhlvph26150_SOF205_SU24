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
    public class NhacungcapRepo : INhacungcapRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public NhacungcapRepo()
        {
        }

        public NhacungcapRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddNhacungcap(Nhacungcap Nhacungcap)
        {
            try
            {
                _dbContext.Nhacungcaps.Add(Nhacungcap);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteNhacungcap(int id)
        {
            try
            {
                var Nhacungcap = _dbContext.Nhacungcaps.Find(id);
                _dbContext.Nhacungcaps.Remove(Nhacungcap);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditNhacungcap(Nhacungcap Nhacungcap)
        {
            try
            {
                var updateNhacungcap = _dbContext.Nhacungcaps.Find(Nhacungcap.Id);
                updateNhacungcap.Ten = Nhacungcap.Ten;
                updateNhacungcap.Diachi = Nhacungcap.Diachi;
                _dbContext.Nhacungcaps.Update(updateNhacungcap);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Nhacungcap> GetAllNhacungcap()
        {
            return _dbContext.Nhacungcaps.ToList();
        }

        public Nhacungcap GetNhacungcapById(int id)
        {
            return _dbContext.Nhacungcaps.FirstOrDefault(x => x.Id == id);
        }

        public List<Nhacungcap> GetNhacungcapByName(string name)
        {
            return _dbContext.Nhacungcaps.Where(x => x.Ten.Contains(name)).ToList();
        }
    }
}