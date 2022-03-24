
namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnBtn = new System.Windows.Forms.Panel();
            this.btnLHD = new System.Windows.Forms.Button();
            this.btnTTKCK = new System.Windows.Forms.Button();
            this.btnTKVP = new System.Windows.Forms.Button();
            this.btnPDP = new System.Windows.Forms.Button();
            this.btnTB = new System.Windows.Forms.Button();
            this.btnTTNT = new System.Windows.Forms.Button();
            this.btnQLP = new System.Windows.Forms.Button();
            this.btnLienHe = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuLinhtinh = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiGiáDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBtn.SuspendLayout();
            this.menuLinhtinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Location = new System.Drawing.Point(154, 27);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(907, 598);
            this.pnMain.TabIndex = 1;
            // 
            // pnBtn
            // 
            this.pnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBtn.Controls.Add(this.btnLHD);
            this.pnBtn.Controls.Add(this.btnTTKCK);
            this.pnBtn.Controls.Add(this.btnTKVP);
            this.pnBtn.Controls.Add(this.btnPDP);
            this.pnBtn.Controls.Add(this.btnTB);
            this.pnBtn.Controls.Add(this.btnTTNT);
            this.pnBtn.Controls.Add(this.btnQLP);
            this.pnBtn.Controls.Add(this.btnLienHe);
            this.pnBtn.Controls.Add(this.btnLogin);
            this.pnBtn.Controls.Add(this.btnLogout);
            this.pnBtn.Location = new System.Drawing.Point(12, 27);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(136, 598);
            this.pnBtn.TabIndex = 2;
            // 
            // btnLHD
            // 
            this.btnLHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLHD.Location = new System.Drawing.Point(3, 389);
            this.btnLHD.Name = "btnLHD";
            this.btnLHD.Size = new System.Drawing.Size(126, 55);
            this.btnLHD.TabIndex = 10;
            this.btnLHD.Text = "Lập hóa đơn";
            this.btnLHD.UseVisualStyleBackColor = true;
            this.btnLHD.Visible = false;
            this.btnLHD.Click += new System.EventHandler(this.btnLHD_Click);
            // 
            // btnTTKCK
            // 
            this.btnTTKCK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTTKCK.Enabled = false;
            this.btnTTKCK.Location = new System.Drawing.Point(3, 328);
            this.btnTTKCK.Name = "btnTTKCK";
            this.btnTTKCK.Size = new System.Drawing.Size(126, 55);
            this.btnTTKCK.TabIndex = 8;
            this.btnTTKCK.Text = "Tạo tài khoản cho khách";
            this.btnTTKCK.UseVisualStyleBackColor = true;
            this.btnTTKCK.Visible = false;
            this.btnTTKCK.Click += new System.EventHandler(this.btnTTKCK_Click);
            // 
            // btnTKVP
            // 
            this.btnTKVP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTKVP.Location = new System.Drawing.Point(3, 262);
            this.btnTKVP.Name = "btnTKVP";
            this.btnTKVP.Size = new System.Drawing.Size(126, 60);
            this.btnTKVP.TabIndex = 7;
            this.btnTKVP.Text = "Thêm khách vào phòng";
            this.btnTKVP.UseVisualStyleBackColor = true;
            this.btnTKVP.Visible = false;
            this.btnTKVP.Click += new System.EventHandler(this.btnTKVP_Click);
            // 
            // btnPDP
            // 
            this.btnPDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDP.Location = new System.Drawing.Point(3, 193);
            this.btnPDP.Name = "btnPDP";
            this.btnPDP.Size = new System.Drawing.Size(126, 63);
            this.btnPDP.TabIndex = 6;
            this.btnPDP.Text = "Viết phiếu đặt phòng";
            this.btnPDP.UseVisualStyleBackColor = true;
            this.btnPDP.Visible = false;
            this.btnPDP.Click += new System.EventHandler(this.btnPDP_Click);
            // 
            // btnTB
            // 
            this.btnTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTB.Location = new System.Drawing.Point(3, 146);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(126, 41);
            this.btnTB.TabIndex = 5;
            this.btnTB.Text = "Thông báo";
            this.btnTB.UseVisualStyleBackColor = true;
            this.btnTB.Visible = false;
            this.btnTB.Click += new System.EventHandler(this.btnTB_Click);
            // 
            // btnTTNT
            // 
            this.btnTTNT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTTNT.Location = new System.Drawing.Point(3, 66);
            this.btnTTNT.Name = "btnTTNT";
            this.btnTTNT.Size = new System.Drawing.Size(126, 74);
            this.btnTTNT.TabIndex = 3;
            this.btnTTNT.Text = "Thông tin người thuê phòng";
            this.btnTTNT.UseVisualStyleBackColor = true;
            this.btnTTNT.Visible = false;
            this.btnTTNT.Click += new System.EventHandler(this.btnTTNT_Click);
            // 
            // btnQLP
            // 
            this.btnQLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLP.Location = new System.Drawing.Point(3, 3);
            this.btnQLP.Name = "btnQLP";
            this.btnQLP.Size = new System.Drawing.Size(126, 57);
            this.btnQLP.TabIndex = 2;
            this.btnQLP.Text = "Quản lý phòng";
            this.btnQLP.UseVisualStyleBackColor = true;
            this.btnQLP.Visible = false;
            this.btnQLP.Click += new System.EventHandler(this.btnQLP_Click);
            // 
            // btnLienHe
            // 
            this.btnLienHe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLienHe.Location = new System.Drawing.Point(3, 505);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Size = new System.Drawing.Size(126, 40);
            this.btnLienHe.TabIndex = 1;
            this.btnLienHe.Text = "Liên hệ";
            this.btnLienHe.UseVisualStyleBackColor = true;
            this.btnLienHe.Click += new System.EventHandler(this.btnLienHe_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(3, 551);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(3, 551);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuLinhtinh
            // 
            this.menuLinhtinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuLinhtinh.Location = new System.Drawing.Point(0, 0);
            this.menuLinhtinh.Name = "menuLinhtinh";
            this.menuLinhtinh.Size = new System.Drawing.Size(1073, 24);
            this.menuLinhtinh.TabIndex = 4;
            this.menuLinhtinh.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchHóaĐơnToolStripMenuItem,
            this.danhSáchPhiếuĐặtPhòngToolStripMenuItem,
            this.thayĐổiGiáDịchVụToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // danhSáchHóaĐơnToolStripMenuItem
            // 
            this.danhSáchHóaĐơnToolStripMenuItem.Name = "danhSáchHóaĐơnToolStripMenuItem";
            this.danhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.danhSáchHóaĐơnToolStripMenuItem.Text = "Danh sách hóa đơn";
            // 
            // danhSáchPhiếuĐặtPhòngToolStripMenuItem
            // 
            this.danhSáchPhiếuĐặtPhòngToolStripMenuItem.Name = "danhSáchPhiếuĐặtPhòngToolStripMenuItem";
            this.danhSáchPhiếuĐặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.danhSáchPhiếuĐặtPhòngToolStripMenuItem.Text = "Danh sách phiếu đặt phòng";
            // 
            // thayĐổiGiáDịchVụToolStripMenuItem
            // 
            this.thayĐổiGiáDịchVụToolStripMenuItem.Name = "thayĐổiGiáDịchVụToolStripMenuItem";
            this.thayĐổiGiáDịchVụToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.thayĐổiGiáDịchVụToolStripMenuItem.Text = "Thay đổi giá dịch vụ";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 637);
            this.Controls.Add(this.pnBtn);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuLinhtinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý phòng trọ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnBtn.ResumeLayout(false);
            this.menuLinhtinh.ResumeLayout(false);
            this.menuLinhtinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnBtn;
        private System.Windows.Forms.Button btnLienHe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnTTNT;
        private System.Windows.Forms.Button btnQLP;
        private System.Windows.Forms.Button btnTB;
        private System.Windows.Forms.Button btnPDP;
        private System.Windows.Forms.Button btnTTKCK;
        private System.Windows.Forms.Button btnTKVP;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLHD;
        private System.Windows.Forms.MenuStrip menuLinhtinh;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuĐặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiGiáDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

