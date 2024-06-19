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
    public class NhanvienRepo : INhanvienRepo
    {
        private Sof205FinalTestContext _dbContext = new Sof205FinalTestContext();

        public NhanvienRepo()
        {
        }

        public NhanvienRepo(Sof205FinalTestContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddNhanvien(Nhanvien Nhanvien)
        {
            try
            {
                _dbContext.Nhanviens.Add(Nhanvien);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteNhanvien(int id)
        {
            try
            {
                var Nhanvien = _dbContext.Nhanviens.Find(id);
                _dbContext.Nhanviens.Remove(Nhanvien);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditNhanvien(Nhanvien Nhanvien)
        {
            try
            {
                var updateNhanvien = _dbContext.Nhanviens.Find(Nhanvien.Id);
                updateNhanvien.Ten = Nhanvien.Ten;
                updateNhanvien.Diachi = Nhanvien.Diachi;
                updateNhanvien.Sodienthoai = Nhanvien.Sodienthoai;
                updateNhanvien.Ngaytuyendung = Nhanvien.Ngaytuyendung;
                _dbContext.Nhanviens.Update(updateNhanvien);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Nhanvien> GetAllNhanvien()
        {
            return _dbContext.Nhanviens.ToList();
        }

        public Nhanvien GetNhanvienById(int id)
        {
            return _dbContext.Nhanviens.FirstOrDefault(x => x.Id == id);
        }

        public List<Nhanvien> GetNhanvienByName(string name)
        {
            return _dbContext.Nhanviens.Where(x => x.Ten.Contains(name)).ToList();
        }
    }
}