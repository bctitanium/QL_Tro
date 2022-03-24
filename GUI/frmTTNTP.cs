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
    public partial class frmTTNTP : Form
    {
        QLTroBAL qltbal = new QLTroBAL();

        public frmTTNTP()
        {
            InitializeComponent();
        }

        private void frmTTNTP_Load(object sender, EventArgs e)
        {
            DGVKhach.DataSource = qltbal.LoadDGVKhach();
        }
    }
}
