using BMCSDL_LAB03_NHOM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMCSDL_LAB03_NHOM.DAL
{
    public class DAL_QLLopHoc
    {        
        public List<NHANVIEN> GetNHANVIENs()
        {
            return Form1.db.NHANVIENs.ToList();
        }
        public List<LOPVIEW> GetLOPs()
        {
            List<LOPVIEW> res = new List<LOPVIEW>();
            List<LOP> ls = Form1.db.LOPs.ToList();
            List<NHANVIEN> nvs = Form1.db.NHANVIENs.ToList();
            for(int i = 0;i<ls.Count;++i)
            {
                for (int j = 0;j<nvs.Count;++j)
                {
                    if (ls[i].MANV == nvs[j].MANV)
                    {
                        LOPVIEW lv = new LOPVIEW { MALOP = ls[i].MALOP, TENLOP = ls[i].TENLOP, TENNHANVIEN = nvs[j].HOTEN };
                        res.Add(lv);
                    }
                }
            }
            return res;
        }
        public string AddLop(LOP l)
        {
            try
            {                
                Form1.db.LOPs.InsertOnSubmit(l);
                Form1.db.SubmitChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.ToString();
            }            
        }
        public string DelLop(LOP l)
        {
            try
            {
                Form1.db.LOPs.DeleteOnSubmit(Form1.db.LOPs.Where(x => x.MALOP == l.MALOP).SingleOrDefault());
                Form1.db.SubmitChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public string UpdateLop(LOP l)
        {
            try
            {
                LOP updatel = Form1.db.LOPs.Where(x => x.MALOP == l.MALOP).SingleOrDefault();
                updatel.MALOP = l.MALOP;
                updatel.TENLOP = l.TENLOP;
                updatel.MANV = l.MANV;
                Form1.db.SubmitChanges();
                return null;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
