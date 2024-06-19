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
    public class CuahangRepo : ICuahangRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public CuahangRepo()
        {
        }

        public CuahangRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddCuaHang(Cuahang Cuahang)
        {
            try
            {
                _dbContext.Cuahangs.Add(Cuahang);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCuaHang(int id)
        {
            try
            {
                var Cuahang = _dbContext.Cuahangs.Find(id);
                _dbContext.Cuahangs.Remove(Cuahang);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditCuaHang(Cuahang Cuahang)
        {
            try
            {
                var updateCuahang = _dbContext.Cuahangs.Find(Cuahang.Id);
                updateCuahang.Ten = Cuahang.Ten;
                updateCuahang.Mota = Cuahang.Mota;
                updateCuahang.Loaihang = Cuahang.Loaihang;
                updateCuahang.Ngaydangky = Cuahang.Ngaydangky;
                _dbContext.Cuahangs.Update(updateCuahang);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Cuahang> GetAllCuahang()
        {
            return _dbContext.Cuahangs.ToList();
        }

        public Cuahang GetCuahangById(int id)
        {
            return _dbContext.Cuahangs.FirstOrDefault(x => x.Id == id);
        }

        public List<Cuahang> GetCuahangByName(string name)
        {
            return _dbContext.Cuahangs.Where(x => x.Ten.Contains(name)).ToList();
        }
    }
}