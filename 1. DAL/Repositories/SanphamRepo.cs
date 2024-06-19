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
    public class SanphamRepo : ISanphamRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public SanphamRepo()
        {
        }

        public SanphamRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddSanpham(Sanpham Sanpham)
        {
            try
            {
                _dbContext.Sanphams.Add(Sanpham);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSanpham(int id)
        {
            try
            {
                var Sanpham = _dbContext.Sanphams.Find(id);
                _dbContext.Sanphams.Remove(Sanpham);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditSanpham(Sanpham Sanpham)
        {
            try
            {
                var updateSanpham = _dbContext.Sanphams.Find(Sanpham.Id);
                updateSanpham.Ten = Sanpham.Ten;
                updateSanpham.Mota = Sanpham.Mota;
                updateSanpham.Soluongtonkho = Sanpham.Soluongtonkho;
                updateSanpham.Giatien = Sanpham.Giatien;
                _dbContext.Sanphams.Update(updateSanpham);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Sanpham> GetAllSanpham()
        {
            return _dbContext.Sanphams.ToList();
        }

        public Sanpham GetSanphamById(int id)
        {
            return _dbContext.Sanphams.FirstOrDefault(x => x.Id == id);
        }

        public List<Sanpham> GetSanphamByName(string name)
        {
            return _dbContext.Sanphams.Where(x => x.Ten.Contains(name)).ToList();
        }
    }
}