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
    public partial class frmTKVP : Form
    {
        QLTroBAL qltbal = new QLTroBAL();

        public frmTKVP()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (qltbal.ThemKhach(txtMK.Text, txtTen.Text, txtCMND.Text, txtSDT.Text, cbbPhong.SelectedItem.ToString()))
            {
                MessageBox.Show("Thêm khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiMaKhachNenNhap()
        {
            string suggest = qltbal.LayMKLonNhat();
            string somakhach = suggest.Substring(2);
            int SomakhachSuggest = Convert.ToInt32(somakhach) + 1;
            txtMK.Text = "MK" + SomakhachSuggest.ToString();
        }

        private void LoadComboBoxMaPhong()
        {
            for (int i = 0; i < dgvMP.RowCount; i++)
            {
                cbbPhong.Items.Add(dgvMP.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void frmTKVP_Load(object sender, EventArgs e)
        {
            dgvMP.DataSource = qltbal.LoadDGVMP();
            LoadComboBoxMaPhong();
            cbbPhong.SelectedIndex = 0;

            HienThiMaKhachNenNhap();
        }

        private void lbTKVP_Click(object sender, EventArgs e)
        {
            cbbPhong.Items.Clear();

            dgvMP.DataSource = qltbal.LoadDGVMP();
            
            LoadComboBoxMaPhong();

            cbbPhong.SelectedIndex = 0;

            HienThiMaKhachNenNhap();
        }
    }
}
