using BMCSDL_LAB03_NHOM.DAL;
using BMCSDL_LAB03_NHOM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCSDL_LAB03_NHOM.BUS
{    
    public class BUS_QLSinhVien
    {
        DAL_QLSinhVien dalQLSinhVien = new DAL_QLSinhVien();
        public List<LOP> GetLOPs()
        {
            return dalQLSinhVien.GetLOPs();
        }
        public NHANVIEN GetNHANVIENbyMALOP(string malop)
        {
            return dalQLSinhVien.GetNHANVIENbyMALOP(malop);
        }
        public List<NHANVIEN> GetNHANVIENs()
        {
            return dalQLSinhVien.GetNHANVIENs();
        }
        public List<SINHVIENVIEW> GetSINHVIENs()
        {
            return dalQLSinhVien.GetSINHVIENs();
        }
        public SINHVIEN GetSINHVIENbyMASV(string masv)
        {
            return dalQLSinhVien.GetSINHVIENbyMASV(masv);
        }
        public bool Check_NHANVIEN_QUANLY_LOP(string manv, string malop)
        {
            return dalQLSinhVien.Check_NHANVIEN_QUANLY_LOP(manv,malop);
        }
        public int CountSVsinLOP(string malop)
        {
            try
            {
                int res = dalQLSinhVien.CountSVsinLOP(malop);
                return res;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public string UpdateSINHVIEN(SINHVIEN sv, string mk)
        {
            if (mk.Length > 0)
                return dalQLSinhVien.UpdateSINHVIEN(sv, mk);
            else
                return dalQLSinhVien.UpdateSINHVIEN_KHONGMATKHAU(sv);
        }
    }
}
