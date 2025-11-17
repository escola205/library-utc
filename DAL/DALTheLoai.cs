using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTheLoai
    {
        private static DALTheLoai instance;

        public static DALTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALTheLoai();
                return instance;
            }
            set => instance = value;
        }

        public List<THELOAI> GetAllTheLoai()
        {
            return QLTVEntities.Instance.THELOAIs.AsNoTracking().ToList();
        }

        /// <summary>
        /// get THELOAI by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public THELOAI GetTheLoaiById(int id)
        {
            return QLTVEntities.Instance.THELOAIs.Find(id);
        }

        /// <summary>
        /// get THELOAI by MaTheLoai
        /// </summary>
        /// <param name="maTheLoai"></param>
        /// <returns></returns>
        public THELOAI GetTheLoaiByMa(string maTheLoai)
        {
            var res = QLTVEntities.Instance.THELOAIs.AsNoTracking().Where(t => t.MaTheLoai == maTheLoai);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        /// <summary>
        /// Find THELOAI by filter
        /// </summary>
        /// <param name="tenTheLoai"></param>
        /// <returns></returns>
        public List<THELOAI> FindTheLoai(string tenTheLoai)
        {
            return QLTVEntities.Instance.THELOAIs.AsNoTracking().Where(t => t.TenTheLoai == tenTheLoai).Select(t => t).ToList();
        }

        public bool AddTheLoai(string tenTheLoai)
        {
            try
            {
                THELOAI theloai = new THELOAI { TenTheLoai = tenTheLoai };
                QLTVEntities.Instance.THELOAIs.Add(theloai);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdTheLoai(int id, string tenTheLoai)
        {
            try
            {
                var theloai = GetTheLoaiById(id);
                if (theloai == null) return false;
                theloai.TenTheLoai = tenTheLoai;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelTheLoai(int id)
        {
            try
            {
                var theloai = GetTheLoaiById(id);
                if (theloai == null) return false;
                QLTVEntities.Instance.THELOAIs.Remove(theloai);
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
