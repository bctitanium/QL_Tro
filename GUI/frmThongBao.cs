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
    public partial class frmThongBao : Form
    {
        QLTroBAL qltbal = new QLTroBAL();

        public frmThongBao()
        {
            InitializeComponent();
        }

        private void btnDang_Click(object sender, EventArgs e)
        {
            if (qltbal.DangThongBao(rtxtThongBao.Text))
            {
                MessageBox.Show("Đã cập nhật thông báo mới nhứt!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbNDTB.Text = qltbal.LayThongBao();
            }
            else
            {
                MessageBox.Show("Cập nhật thông báo không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThongBao_Load(object sender, EventArgs e)
        {
            lbNDTB.Text = qltbal.LayThongBao();
        }
    }
}
