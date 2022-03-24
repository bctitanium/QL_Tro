
namespace GUI
{
    partial class frmTTKCK
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
            this.btnTạo = new System.Windows.Forms.Button();
            this.lbTTKCK = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTạo
            // 
            this.btnTạo.Location = new System.Drawing.Point(153, 200);
            this.btnTạo.Name = "btnTạo";
            this.btnTạo.Size = new System.Drawing.Size(93, 54);
            this.btnTạo.TabIndex = 13;
            this.btnTạo.Text = "Tạo";
            this.btnTạo.UseVisualStyleBackColor = true;
            // 
            // lbTTKCK
            // 
            this.lbTTKCK.AutoSize = true;
            this.lbTTKCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTKCK.Location = new System.Drawing.Point(23, 9);
            this.lbTTKCK.Name = "lbTTKCK";
            this.lbTTKCK.Size = new System.Drawing.Size(457, 46);
            this.lbTTKCK.TabIndex = 12;
            this.lbTTKCK.Text = "Tạo tài khoản cho khách";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(47, 84);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(90, 22);
            this.lbAccount.TabIndex = 22;
            this.lbAccount.Text = "Tài khoản";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(47, 117);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(83, 22);
            this.lbPassword.TabIndex = 23;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(143, 81);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(218, 27);
            this.txtAccount.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(143, 114);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 27);
            this.txtPassword.TabIndex = 25;
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(47, 150);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(63, 22);
            this.lbCMND.TabIndex = 16;
            this.lbCMND.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(143, 147);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(218, 27);
            this.txtCMND.TabIndex = 21;
            // 
            // frmTTKCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 282);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.btnTạo);
            this.Controls.Add(this.lbTTKCK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTTKCK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTTKCK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTạo;
        private System.Windows.Forms.Label lbTTKCK;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.TextBox txtCMND;
    }
}