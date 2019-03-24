using BMCSDL_LAB03_NHOM.BUS;
using BMCSDL_LAB03_NHOM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMCSDL_LAB03_NHOM.GUI
{
    public partial class QLSinhVien : Form
    {
        BUS_QLSinhVien busQLSinhVien = new BUS_QLSinhVien();
        public QLSinhVien()
        {
            InitializeComponent();
        }

        private void Modify_EnabledMode(bool malop, bool masv, bool tendn, bool mk, bool sosv,  bool ngaysinh,bool hoten, bool diachi, bool nhanvien, bool sua, bool luu, bool huy, bool tailai)
        {
            cmbLopHoc.Enabled = malop;
            txtMaSV.Enabled = masv;
            txtTenDN.Enabled = tendn;
            txtMatKhau.Enabled = mk;
            txtSoSV.Enabled = sosv;
            dpNgaySinh.Enabled = ngaysinh;
            txtHoTen.Enabled = hoten;
            txtDiaChi.Enabled = diachi;
            cmbNhanVien.Enabled = nhanvien;
            btnSua.Enabled = sua;
            btnLuu.Enabled = luu;
            btnHuy.Enabled = huy;
            btnTaiLai.Enabled = tailai;            
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            cmbLopHoc.DataSource = busQLSinhVien.GetLOPs();
            cmbLopHoc.DisplayMember = "TENLOP";
            cmbLopHoc.ValueMember = "MALOP";

            datagvQLSinhVien.DataSource = busQLSinhVien.GetSINHVIENs();            
            datagvQLSinhVien.Rows[0].Selected = true;

            cmbNhanVien.DataSource = busQLSinhVien.GetNHANVIENs();
            cmbNhanVien.DisplayMember = "HOTEN";
            cmbNhanVien.ValueMember = "MANV";            

            if (Form1.nv != null)
            {
                cmbNhanVien.SelectedValue = Form1.nv.MANV;                
            }
            Modify_EnabledMode(false, false, false, false, false, false, false, false, false, true, false, false, true);
        }

        private void datagvQLSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagvQLSinhVien.SelectedRows)
            {
                SINHVIEN sv = busQLSinhVien.GetSINHVIENbyMASV(r.Cells[0].Value.ToString());

                cmbLopHoc.SelectedValue = sv.MALOP;
                txtHoTen.Text = sv.HOTEN;
                dpNgaySinh.Value = sv.NGAYSINH.Value;
                txtDiaChi.Text = sv.DIACHI;
                txtTenDN.Text = sv.TENDN;
                txtMaSV.Text = sv.MASV;                
                txtSoSV.Text = busQLSinhVien.CountSVsinLOP(cmbLopHoc.SelectedValue.ToString()).ToString();
            }
        }

        private void cmbLopHoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSoSV.Text = busQLSinhVien.CountSVsinLOP(cmbLopHoc.SelectedValue.ToString()).ToString();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {            
            datagvQLSinhVien.DataSource = null;
            datagvQLSinhVien.DataSource = busQLSinhVien.GetSINHVIENs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmbNhanVien.Enabled = true;
            cmbLopHoc.Enabled = true;
            if (busQLSinhVien.Check_NHANVIEN_QUANLY_LOP(cmbNhanVien.SelectedValue.ToString(), cmbLopHoc.SelectedValue.ToString()))
            {                
                Modify_EnabledMode(true, false, true, true, false, true, true, true, true, false, true, true, false);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {            
            Modify_EnabledMode(false, false, false, false, false, false, false, false, false, true, false, false, true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!busQLSinhVien.Check_NHANVIEN_QUANLY_LOP(cmbNhanVien.SelectedValue.ToString(), cmbLopHoc.SelectedValue.ToString()))
                MessageBox.Show("Bạn không có quyền!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                SINHVIEN sv = new SINHVIEN
                {
                    MASV = txtMaSV.Text,
                    HOTEN = txtHoTen.Text,
                    NGAYSINH = dpNgaySinh.Value,
                    DIACHI = txtDiaChi.Text,
                    TENDN = txtTenDN.Text,
                    MALOP = cmbLopHoc.SelectedValue.ToString(),
                };
                if (busQLSinhVien.UpdateSINHVIEN(sv, txtMatKhau.Text)!=null)
                {
                    MessageBox.Show(busQLSinhVien.UpdateSINHVIEN(sv, txtMatKhau.Text), "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);                    
                    Modify_EnabledMode(false,false,false,false,false,false,false,false,false,true,false,false,true);
                }
            }
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhanVien.SelectedItem != Form1.nv)
            {
                MessageBox.Show("Bạn không có quyền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNhanVien.SelectedItem = Form1.nv;
            }
        }
    }
}
