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
    public partial class frmPDP : Form
    {
        QLTroBAL qltbal = new QLTroBAL();

        public frmPDP()
        {
            InitializeComponent();
        }

        private void frmPDP_Load(object sender, EventArgs e)
        {
            dgvMP.DataSource = qltbal.LoadDGVMPTrong();
            LoadComboBoxMaPhongTrong();
            cbbPhong.SelectedIndex = 0;

            dgvMaNV.DataSource = qltbal.LoadDGVMaNV();
            LoadComboBoxMaNV();
            cbbNV.SelectedIndex = 0;

            HienThiMaHoaDonNenNhap();
            HienThiMaKhachNenNhap();
            HienThiMaPhieuDatPhongNenNhap();
        }

        private void LoadComboBoxMaPhongTrong()
        {
            for (int i = 0; i < dgvMP.RowCount; i++)
            {
                cbbPhong.Items.Add(dgvMP.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void LoadComboBoxMaNV()
        {
            for (int i = 0; i < dgvMaNV.RowCount; i++)
            {
                cbbNV.Items.Add(dgvMaNV.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void HienThiMaHoaDonNenNhap()
        {
            string suggest = qltbal.LayMHDLonNhat();
            string sohoadon = suggest.Substring(2);
            int SohoadonSuggest = Convert.ToInt32(sohoadon) + 1;
            txtMHD.Text = "HD" + SohoadonSuggest.ToString();
        }

        private void HienThiMaKhachNenNhap()
        {
            string suggest = qltbal.LayMKLonNhat();
            string somakhach = suggest.Substring(2);
            int SomakhachSuggest = Convert.ToInt32(somakhach) + 1;
            txtMK.Text = "MK" + SomakhachSuggest.ToString();
        }

        private void HienThiMaPhieuDatPhongNenNhap()
        {
            string suggest = qltbal.LayMPDPLonNhat();
            string somaphieudatphong = suggest.Substring(3);
            int SomaphieudatphongSuggest = Convert.ToInt32(somaphieudatphong) + 1;
            txtMaPDP.Text = "PDP" + SomaphieudatphongSuggest.ToString();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            if (qltbal.LapPhieuDatPhong(txtMK.Text, txtTen.Text, txtCMND.Text, txtSDT.Text, cbbPhong.SelectedItem.ToString(), 
                txtMaPDP.Text, dtpNgayDat.Value, cbbNV.SelectedItem.ToString(), txtMHD.Text, dtpNgayTra.Value))
            {
                qltbal.CapNhatTrangThaiPhongSangDatCoc(cbbPhong.SelectedItem.ToString());
                MessageBox.Show("Lập phiếu đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lập phiếu đặt phòng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {
            cbbPhong.Items.Clear();
            cbbNV.Items.Clear();

            dgvMP.DataSource = qltbal.LoadDGVMPTrong();
            dgvMaNV.DataSource = qltbal.LoadDGVMaNV();

            LoadComboBoxMaPhongTrong();
            LoadComboBoxMaNV();

            cbbPhong.SelectedIndex = 0;
            cbbNV.SelectedIndex = 0;

            HienThiMaHoaDonNenNhap();
            HienThiMaKhachNenNhap();
            HienThiMaPhieuDatPhongNenNhap();
        }
    }
}
