using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMCSDL_LAB03_NHOM.GUI;

namespace BMCSDL_LAB03_NHOM.GUI
{
    public partial class DangNhap : Form
    {
        public Form1 form1 = new Form1();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int loaitk = Form1.db.KIEMTRATAIKHOAN(txtTenDN.Text,txtMatKhau.Text);
            if (loaitk == -1)
            {
                Form1.nv = Form1.db.NHANVIENs.Where(x => x.TENDN == txtTenDN.Text).SingleOrDefault();
                Form1.sv = null;
                MessageBox.Show("Xin chào nhân viên "+ Form1.nv.HOTEN+".","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Close();                
                Form1.Instance.txtChao.Text = "Xin chào nhân viên " + Form1.nv.HOTEN + ".";                
                Form1.Instance.btnDangNhap.Visible = false;
                Form1.Instance.btnDangXuat.Visible = true;
                Form1.Instance.txtChao.Refresh();

            }
            else if (loaitk == 1)
            {
                Form1.sv = Form1.db.SINHVIENs.Where(x => x.TENDN == txtTenDN.Text).SingleOrDefault();
                Form1.nv = null;
                MessageBox.Show("Xin chào sinh viên " + Form1.sv.HOTEN + ".", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Close();
                Form1.Instance.txtChao.Text = "Xin chào sinh viên " + Form1.sv.HOTEN + ".";                
                Form1.Instance.btnDangNhap.Visible = false;
                Form1.Instance.btnDangXuat.Visible = true;
                Form1.Instance.txtChao.Refresh();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.","Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }
    }
}
