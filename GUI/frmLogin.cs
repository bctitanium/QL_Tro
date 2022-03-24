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
    public partial class frmLogin : Form
    {
        public delegate void flagLogin(bool flag);
        public flagLogin FL;

        QLTroBAL qltbal = new QLTroBAL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text)) //bất kỳ khoảng trắng nào cũng không được chấp nhận
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text.Any(char.IsWhiteSpace)) //bất kỳ khoảng trắng nào cũng không được chấp nhận
                {
                    MessageBox.Show("Tên đăng nhập không được có khoảng trắng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!txtUsername.Text.All(char.IsLetterOrDigit)) //nếu như chuỗi không toàn là chữ hay số thì chắc chắn có ký tự đặc biệt
                    {
                        MessageBox.Show("Tên đăng nhập không được có ký tự đặc biệt!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Any(char.IsWhiteSpace)) //bất kỳ khoảng trắng nào cũng không được chấp nhận
                        {
                            MessageBox.Show("Mật khẩu không hợp lệ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (qltbal.CheckAccount(txtUsername.Text, txtPassword.Text)) //kiểm tra sự tồn tại của account
                            {
                                if (MessageBox.Show("Bạn sắp vào khu vực của ADMIN\nKhông phận sự miễn vào", "Mầy là ai mậy!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    this.Hide();
                                    FL(true);
                                    txtPassword.Text = ""; //xoá trắng mật khẩu thôi :)))
                                }
                                else
                                {
                                    //không cho vào thì thôi
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sai thông tin đăng nhập\nBạn đã đăng ký tài khoản này chưa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
