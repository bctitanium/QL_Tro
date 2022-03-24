
namespace GUI
{
    partial class frmTKVP
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lbMP = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbTKVP = new System.Windows.Forms.Label();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.dgvMP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(162, 188);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(188, 27);
            this.txtSDT.TabIndex = 22;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(162, 155);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(188, 27);
            this.txtCMND.TabIndex = 21;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(162, 122);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(188, 27);
            this.txtTen.TabIndex = 20;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(162, 89);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(188, 27);
            this.txtMK.TabIndex = 19;
            // 
            // lbMP
            // 
            this.lbMP.AutoSize = true;
            this.lbMP.Location = new System.Drawing.Point(43, 224);
            this.lbMP.Name = "lbMP";
            this.lbMP.Size = new System.Drawing.Size(89, 22);
            this.lbMP.TabIndex = 18;
            this.lbMP.Text = "Mã phòng";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(43, 191);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(47, 22);
            this.lbSDT.TabIndex = 17;
            this.lbSDT.Text = "SĐT";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(43, 158);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(63, 22);
            this.lbCMND.TabIndex = 16;
            this.lbCMND.Text = "CMND";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(43, 125);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(42, 22);
            this.lbTen.TabIndex = 15;
            this.lbTen.Text = "Tên";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Location = new System.Drawing.Point(43, 92);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(87, 22);
            this.lbMK.TabIndex = 14;
            this.lbMK.Text = "Mã khách";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(162, 264);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 54);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbTKVP
            // 
            this.lbTKVP.AutoSize = true;
            this.lbTKVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKVP.Location = new System.Drawing.Point(28, 23);
            this.lbTKVP.Name = "lbTKVP";
            this.lbTKVP.Size = new System.Drawing.Size(436, 46);
            this.lbTKVP.TabIndex = 12;
            this.lbTKVP.Text = "Thêm khách vào phòng";
            this.lbTKVP.Click += new System.EventHandler(this.lbTKVP_Click);
            // 
            // cbbPhong
            // 
            this.cbbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(162, 221);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(188, 28);
            this.cbbPhong.TabIndex = 28;
            // 
            // dgvMP
            // 
            this.dgvMP.AllowUserToAddRows = false;
            this.dgvMP.AllowUserToDeleteRows = false;
            this.dgvMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMP.Location = new System.Drawing.Point(757, -2);
            this.dgvMP.Name = "dgvMP";
            this.dgvMP.ReadOnly = true;
            this.dgvMP.Size = new System.Drawing.Size(159, 342);
            this.dgvMP.TabIndex = 34;
            this.dgvMP.Visible = false;
            // 
            // frmTKVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 339);
            this.Controls.Add(this.dgvMP);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.lbMP);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbCMND);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbTKVP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTKVP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTKVP";
            this.Load += new System.EventHandler(this.frmTKVP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lbMP;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbTKVP;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.DataGridView dgvMP;
    }
}