using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMCSDL_LAB03_NHOM.DAL;
using BMCSDL_LAB03_NHOM.GUI;

namespace BMCSDL_LAB03_NHOM
{
    public partial class Form1 : Form
    {
        public static QLSVDataContext db = new QLSVDataContext();
        public static SINHVIEN sv;
        public static NHANVIEN nv;
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        public Form1()
        {
            InitializeComponent();            
        }               

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Form1.Instance.btnDangNhap.Visible = true;
            Form1.Instance.btnDangXuat.Visible = false;
            if (nv != null)
            {
                txtChao.Text = "Xin chào nhân viên " + nv.HOTEN + "!";
            }
            else if (sv != null)
            {
                txtChao.Text = "Xin chào sinh viên " + sv.HOTEN + "!";
            }
            else
            {
                txtChao.Text = "";
            }
        }

        private void btnQLLopHoc_Click(object sender, EventArgs e)
        {
            if (nv != null)
            {
                QLLopHoc qllh = new QLLopHoc();
                qllh.Show();
            }
            else if (sv!=null)
            {
                MessageBox.Show("Bạn không có quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            if (nv != null)
            {
                QLSinhVien qlsv = new QLSinhVien();
                qlsv.Show();
            }
            else if (sv != null)
            {
                MessageBox.Show("Bạn không có quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (nv != null)
            {
                NhapDiem nd = new NhapDiem();
                nd.Show();
            }
            else if (sv != null)
            {
                MessageBox.Show("Bạn không có quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            sv = null;
            nv = null;
            btnDangNhap.Visible = true;
            btnDangXuat.Visible = false;
            txtChao.Text = null;
            MessageBox.Show("Đăng xuất thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
