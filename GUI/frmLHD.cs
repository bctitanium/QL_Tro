using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace GUI
{
    public partial class frmLHD : Form
    {
        QLTroBAL qltbal = new QLTroBAL();
        public frmLHD()
        {
            InitializeComponent();
        }

        private void frmLHD_Load(object sender, EventArgs e)
        {
            dgvMaNV.DataSource = qltbal.LoadDGVMaNV();
            dgvMP.DataSource = qltbal.LoadDGVMP();

            LoadComboBoxMaNV();
            cbbNV.SelectedIndex = 0;
            LoadComboBoxMaPhong();
            cbbPhong.SelectedIndex = 0;

            HienThiMaHoaDonNenNhap();
        }

        private void LoadComboBoxMaNV()
        {
            for (int i = 0; i < dgvMaNV.RowCount; i++)
            {
                cbbNV.Items.Add(dgvMaNV.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void LoadComboBoxMaPhong()
        {
            for (int i = 0; i < dgvMP.RowCount; i++)
            {
                cbbPhong.Items.Add(dgvMP.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void HienThiMaHoaDonNenNhap()
        {
            string suggest = qltbal.LayMHDLonNhat();
            string sohoadon = suggest.Substring(2);
            int SohoadonSuggest =  Convert.ToInt32(sohoadon) + 1;
            txtMHD.Text = "HD" + SohoadonSuggest.ToString();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            string makhach = qltbal.LayMKTuMP(cbbPhong.SelectedItem.ToString());
            string mahoadon = qltbal.LayMHDTuNgayLap(cbbPhong.SelectedItem.ToString());
            int SoDienCu = qltbal.LaySoDien(mahoadon);
            int SoNuocCu = qltbal.LaySoNuoc(mahoadon);

            if (!txtSoNuoc.Text.All(char.IsNumber) || !txtSoDien.Text.All(char.IsNumber) || string.IsNullOrEmpty(txtSoDien.Text) || string.IsNullOrEmpty(txtSoNuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập điện nước là số hoặc không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (SoDienCu > Convert.ToInt32(txtSoDien.Text) || SoNuocCu > Convert.ToInt32(txtSoNuoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số điện nước\nSố điện (nước) MỚI phải lớn hơn số điện (nước) CŨ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (qltbal.LapHoaDon(txtMHD.Text, dtpNL.Value, cbbNV.SelectedItem.ToString(), makhach))
                    {
                        if (qltbal.LapChiTietHoaDon(txtMHD.Text, SoDienCu, Convert.ToInt32(txtSoDien.Text), SoNuocCu, Convert.ToInt32(txtSoNuoc.Text)))
                        {
                            MessageBox.Show("Lập hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lập chi tiết hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lập hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSDC.Text = qltbal.LaySoDien(qltbal.LayMHDTuNgayLap(cbbPhong.SelectedItem.ToString())).ToString();
            txtSNC.Text = qltbal.LaySoNuoc(qltbal.LayMHDTuNgayLap(cbbPhong.SelectedItem.ToString())).ToString();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {
            cbbPhong.Items.Clear();
            cbbNV.Items.Clear();

            dgvMaNV.DataSource = qltbal.LoadDGVMaNV();
            dgvMP.DataSource = qltbal.LoadDGVMP();

            LoadComboBoxMaNV();
            LoadComboBoxMaPhong();

            cbbPhong.SelectedIndex = 0;
            cbbNV.SelectedIndex = 0;

            HienThiMaHoaDonNenNhap();
        }

        private void btnSuggestMHD_Click(object sender, EventArgs e)
        {

        }
    }
}
