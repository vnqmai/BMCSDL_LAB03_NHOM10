using BMCSDL_LAB03_NHOM.DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCSDL_LAB03_NHOM.DAL
{
    public class DAL_QLSinhVien
    {
        public List<LOP> GetLOPs()
        {
            return Form1.db.LOPs.ToList();
        }
        public NHANVIEN GetNHANVIENbyMALOP(string malop)
        {
            LOP l = Form1.db.LOPs.Where(x => x.MALOP == malop).SingleOrDefault();
            return Form1.db.NHANVIENs.Where(x => x.MANV == l.MANV).SingleOrDefault();
        }
        public List<NHANVIEN> GetNHANVIENs()
        {
            return Form1.db.NHANVIENs.ToList();
        }
        public List<SINHVIENVIEW> GetSINHVIENs()
        {
            List<SINHVIEN> svs = Form1.db.SINHVIENs.ToList();
            List<SINHVIENVIEW> res = new List<SINHVIENVIEW>();
            foreach (SINHVIEN sv in svs)
            {
                SINHVIENVIEW v = new SINHVIENVIEW
                {
                    MASV = sv.MASV,
                    HOTEN = sv.HOTEN,
                    NGAYSINH = sv.NGAYSINH.Value,
                    DIACHI = sv.DIACHI,
                    TENDN = sv.TENDN
                };
                res.Add(v);                
            }
            return res;
        }
        public SINHVIEN GetSINHVIENbyMASV(string masv)
        {
            return Form1.db.SINHVIENs.Where(x=>x.MASV == masv).SingleOrDefault();
        }
        public int CountSVsinLOP(string malop)
        {
            return Form1.db.SINHVIENs.Where(x => x.MALOP == malop).ToList().Count;
        }
        public bool Check_NHANVIEN_QUANLY_LOP(string manv,string malop)
        {
            var res = Form1.db.LOPs.Where(x => x.MALOP == malop && x.MANV == manv).SingleOrDefault();
            if (res != null)
                return true;
            else
                return false;
        }
        public string UpdateSINHVIEN(SINHVIEN sv, string mk)
        {
            try
            {
                Form1.db.UPDATESV(sv.MASV, sv.HOTEN, sv.NGAYSINH.Value, sv.DIACHI, sv.MALOP, sv.TENDN, mk);
                Form1.db.Dispose();
                Form1.db = new QLSVDataContext();
                //Form1.db.Refresh(RefreshMode.OverwriteCurrentValues);
                return null;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public string UpdateSINHVIEN_KHONGMATKHAU(SINHVIEN sv)
        {
            try
            {
                Form1.db.UPDATESV_KHONGMATKHAU(sv.MASV, sv.HOTEN, sv.NGAYSINH.Value, sv.DIACHI, sv.MALOP, sv.TENDN);
                Form1.db.Dispose();
                Form1.db = new QLSVDataContext();
                //Form1.db.Refresh(RefreshMode.OverwriteCurrentValues);
                return null;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
