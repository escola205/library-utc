using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALThamSo
    {
        private static DALThamSo instance;

        public static DALThamSo Instance
        {
            get
            {
                if (instance == null) instance = new DALThamSo();
                return instance;
            }
            set => instance = value;
        }

        public DALThamSo()
        {
            if (!QLTVEntities.Instance.THAMSOes.Any())
            {
                QLTVEntities.Instance.THAMSOes.Add(new THAMSO
                {
                    TuoiToiThieu = 18,
                    TuoiToiDa = 55,
                    ThoiHanThe = 6,
                    KhoangCachXuatBan = 8,
                    SoSachMuonToiDa = 5,
                    SoNgayMuonToiDa = 4,
                    DonGiaPhat = 1000,
                    AD_QDKTTienThu = 1
                });
                QLTVEntities.Instance.SaveChanges();
            }
        }
        public THAMSO GetAllThamSo()
        {

            return QLTVEntities.Instance.THAMSOes.First();
        }

        public bool UpdTuoiToiThieu(int tuoi)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.TuoiToiThieu = tuoi;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }
        public bool UpdTuoiToiDa(int tuoi)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.TuoiToiDa = tuoi;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdThoiHanThe(int thoiHan)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.ThoiHanThe = thoiHan;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdKhoangCachXB(int kc)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.KhoangCachXuatBan = kc;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }

        public bool UpdSoSachMuonToiDa(int soSach)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.SoSachMuonToiDa = soSach;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }

        public bool UpdSoNgayMuonToiDa(int soNgay)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.SoNgayMuonToiDa = soNgay;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }

        public bool UpdDonGiaPhat(int donGia)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.DonGiaPhat = donGia;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdQDKTTienPhat(int apDung)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.AD_QDKTTienThu = apDung;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }
    }
}
