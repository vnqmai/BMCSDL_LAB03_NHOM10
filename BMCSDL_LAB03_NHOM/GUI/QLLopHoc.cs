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
using BMCSDL_LAB03_NHOM.DAL;
using BMCSDL_LAB03_NHOM.BUS;

namespace BMCSDL_LAB03_NHOM.GUI
{
    public partial class QLLopHoc : Form
    {
        BUS_QLLopHoc busQLLopHoc = new BUS_QLLopHoc();
        private static LOP selectedLop;
        public QLLopHoc()
        {
            InitializeComponent();
        }

        private void QLLopHoc_Load(object sender, EventArgs e)
        {
            cmbNhanVien.DataSource = busQLLopHoc.GetNHANVIENs();
            cmbNhanVien.DisplayMember = "HOTEN";
            cmbNhanVien.ValueMember = "MANV";

            datagvQLLopHoc.DataSource = busQLLopHoc.GetLOPs();
            datagvQLLopHoc.MultiSelect = false;            

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            //txtMaLop.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text.Length!=0 && txtMaLop.Text.Length != 0)
            {
                LOP l = new LOP
                {
                    MALOP = txtMaLop.Text,
                    TENLOP = txtTenLop.Text,
                    MANV = cmbNhanVien.SelectedValue.ToString()
                };
                string res = busQLLopHoc.AddLop(l);
                if (res != null)
                {
                    MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            datagvQLLopHoc.DataSource = busQLLopHoc.GetLOPs();
        }

        private void datagvQLLopHoc_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in datagvQLLopHoc.SelectedRows)
            {
                txtMaLop.Text = r.Cells[0].Value.ToString();
                txtTenLop.Text = r.Cells[1].Value.ToString();
            }            
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text.Length != 0 && txtMaLop.Text.Length != 0)
            {
                LOP l = new LOP
                {
                    MALOP = txtMaLop.Text,
                    TENLOP = txtTenLop.Text,
                    MANV = cmbNhanVien.SelectedValue.ToString()
                };
                string res = busQLLopHoc.DelLop(l);
                if (res != null)
                {
                    MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;

            selectedLop = new LOP
            {
                MALOP = txtMaLop.Text,
                TENLOP = txtTenLop.Text,
                MANV = cmbNhanVien.SelectedValue.ToString()
            };
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string res = busQLLopHoc.UpdateLop(new LOP {
                MALOP = txtMaLop.Text,TENLOP = txtTenLop.Text,MANV = cmbNhanVien.SelectedValue.ToString()
            });
            if (res != null)
            {
                MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK);

                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
        }
    }
}
