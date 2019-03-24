using BMCSDL_LAB03_NHOM.DAL;
using BMCSDL_LAB03_NHOM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCSDL_LAB03_NHOM.BUS
{
    public class BUS_QLLopHoc
    {
        DAL_QLLopHoc dalQLLopHoc = new DAL_QLLopHoc();
        public List<NHANVIEN> GetNHANVIENs()
        {
            return dalQLLopHoc.GetNHANVIENs();
        }
        public List<LOPVIEW> GetLOPs()
        {
            return dalQLLopHoc.GetLOPs();
        }
        public string AddLop(LOP l)
        {
            return dalQLLopHoc.AddLop(l);            
        }
        public string DelLop(LOP l)
        {            
            return dalQLLopHoc.DelLop(l);
        }
        public string UpdateLop(LOP l)
        {
            return dalQLLopHoc.UpdateLop(l);
        }
    }
}
