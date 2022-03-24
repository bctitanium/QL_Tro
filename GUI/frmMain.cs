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
    public partial class frmMain : Form
    {
        public bool flagLoginAdmin = false; //để lưu biến delegate truyền từ form login, true thì là admin đăng nhập

        frmLogin flg = new frmLogin();
        frmLienHe flh = new frmLienHe();
        frmQLP fqlp = new frmQLP();
        frmThongBao ftb = new frmThongBao();
        frmPDP fpdp = new frmPDP();
        frmTKVP ftkvp = new frmTKVP();
        frmTTKCK fttkck = new frmTTKCK();
        frmTTNTP fttntp = new frmTTNTP();
        frmLHD flhd = new frmLHD();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            flg.MdiParent = this;
            pnMain.Controls.Add(flg);
            flg.Dock = DockStyle.Fill;
            flg.Show();

            flg.FL = new frmLogin.flagLogin(LoadFAM);
        }

        private void LoadFAM(bool flag)
        {
            flagLoginAdmin = flag; //nhận cờ

            btnQLP.Visible = true;
            btnTTNT.Visible = true;
            btnTB.Visible = true;
            btnPDP.Visible = true;
            btnTKVP.Visible = true;
            btnTTKCK.Visible = true;
            btnLogout.Visible = true;
            btnLHD.Visible = true;

            btnLogin.Visible = false;

            if (flagLoginAdmin)
            {
                fqlp.MdiParent = this;
                pnMain.Controls.Add(fqlp);
                fqlp.Dock = DockStyle.Fill;
                fqlp.Show();
            }
            else
            {
                //không làm gì
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            flh.Hide();
            fqlp.Hide();
            ftb.Hide();
            fpdp.Hide();
            ftkvp.Hide();
            fttkck.Hide();
            fttntp.Hide();
            flhd.Hide();

            flg.MdiParent = this;
            pnMain.Controls.Add(flg);
            flg.Dock = DockStyle.Fill;
            flg.Show();
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            flg.Hide();
            fqlp.Hide();
            ftb.Hide();
            fpdp.Hide();
            ftkvp.Hide();
            fttkck.Hide();
            fttntp.Hide();
            flhd.Hide();

            flh.MdiParent = this;
            pnMain.Controls.Add(flh);
            flh.Dock = DockStyle.Fill;
            flh.Show();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            flg.Hide();
            flh.Hide();
            ftb.Hide();
            fpdp.Hide();
            ftkvp.Hide();
            fttkck.Hide();
            fttntp.Hide();
            flhd.Hide();

            fqlp.MdiParent = this;
            pnMain.Controls.Add(fqlp);
            fqlp.Dock = DockStyle.Fill;
            fqlp.Show();
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            flg.Hide();
            flh.Hide();
            fqlp.Hide();
            fpdp.Hide();
            ftkvp.Hide();
            fttkck.Hide();
            fttntp.Hide();
            flhd.Hide();

            ftb.MdiParent = this;
            pnMain.Controls.Add(ftb);
            ftb.Dock = DockStyle.Fill;
            ftb.Show();
        }

        private void btnPDP_Click(object sender, EventArgs e)
        {
            flg.Hide();
            flh.Hide();
            fqlp.Hide();
            ftb.Hide();
            ftkvp.Hide();
            fttkck.Hide();
            fttntp.Hide();
            flhd.Hide();

            fpdp.MdiParent = this;
            pnMain.Controls.Add(fpdp);
            fpdp.Dock = DockStyle.Fill;
            fpdp.Show();
        }

        private void btnTKVP_Click(object sender, EventArgs e)
        {
            flg.Hide();
            flh.Hide();
            fqlp.Hide();
            ftb.Hide();
            fpdp.Hide();
            fttkck.Hide();
            fttntp.Hide();
            flhd.Hide();

            ftkvp.MdiParent = this;
            pnMain.Controls.Add(ftkvp);
            ftkvp.Dock = DockStyle.Fill;
            ftkvp.Show();
        }

        private void btnTTKCK_Click(object sender, EventArgs e)
        {
            flg.Hide();
            flh.Hide();
            fqlp.Hide();
            ftb.Hide();
            fpdp.Hide();
            ftkvp.Hide();
            fttntp.Hide();
            flhd.Hide();

            fttkck.MdiParent = this;
            pnMain.Controls.Add(fttkck);
            fttkck.Dock = DockStyle.Fill;
            fttkck.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Muốn đăng xuất thiệt hông? =.=\"", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnQLP.Visible = false;
                btnTTNT.Visible = false;
                btnTB.Visible = false;
                btnPDP.Visible = false;
                btnTKVP.Visible = false;
                btnTTKCK.Visible = false;
                btnLogout.Visible = false;
                btnLHD.Visible = false;

                btnLogin.Visible = true;

                flg.Show();

                flh.Hide();
                fqlp.Hide();
                ftb.Hide();
                fpdp.Hide();
                ftkvp.Hide();
                fttkck.Hide();
                fttntp.Hide();
                flhd.Hide();

                MessageBox.Show("Đã đăng xuất :))", "Nhớ đăng nhập lại nha :D", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //không làm gì
            }
        }

        private void btnTTNT_Click(object sender, EventArgs e)
        {
            flg.Hide();
            flh.Hide();
            fqlp.Hide();
            ftb.Hide();
            fpdp.Hide();
            ftkvp.Hide();
            fttkck.Hide();
            flhd.Hide();

            fttntp.MdiParent = this;
            pnMain.Controls.Add(fttntp);
            fttntp.Dock = DockStyle.Fill;
            fttntp.Show();
        }

        private void btnLHD_Click(object sender, EventArgs e)
        {
            flg.Hide();
            flh.Hide();
            fqlp.Hide();
            ftb.Hide();
            fpdp.Hide();
            ftkvp.Hide();
            fttkck.Hide();
            fttntp.Hide();

            flhd.MdiParent = this;
            pnMain.Controls.Add(flhd);
            flhd.Dock = DockStyle.Fill;
            flhd.Show();
        }
    }
}
