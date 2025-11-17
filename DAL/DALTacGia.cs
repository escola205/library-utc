using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTacGia
    {
        private static DALTacGia instance;

        public static DALTacGia Instance
        {
            get
            {
                if (instance == null) instance = new DALTacGia();
                return instance;
            }
            set => instance = value;
        }

        public List<TACGIA> GetAllTacGia()
        {
            return QLTVEntities.Instance.TACGIAs.AsNoTracking().ToList();
        }

        public TACGIA GetTacGiaById(int id)
        {
            return QLTVEntities.Instance.TACGIAs.Find(id);
        }

        /// <summary>
        /// get TACGIA by maTacGia
        /// </summary>
        /// <param name="maTacGia"></param>
        /// <returns></returns>
        public TACGIA GetTacGiaByMa(string maTacGia)
        {
            var res = QLTVEntities.Instance.TACGIAs.AsNoTracking().Where(t => t.MATACGIA == maTacGia);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        /// <summary>
        /// find TACGIA by filter 
        /// </summary>
        /// <param name="tenTacGia"></param>
        /// <returns></returns>
        public List<TACGIA> FindTacGia(string tenTacGia)
        {
            return QLTVEntities.Instance.TACGIAs.Where(t => t.TenTacGia == tenTacGia).Select(t => t).ToList();
        }
        public int AddTacGia(string tenTacGia)
        {
            try
            {
                TACGIA tacGia = new TACGIA { TenTacGia = tenTacGia };
                QLTVEntities.Instance.TACGIAs.Add(tacGia);
                QLTVEntities.Instance.SaveChanges();
                return tacGia.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool UpdTacGia(int id, string tenTacGia)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                tacgia.TenTacGia = tenTacGia;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelTacGia(int id)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                QLTVEntities.Instance.TACGIAs.Remove(tacgia);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
