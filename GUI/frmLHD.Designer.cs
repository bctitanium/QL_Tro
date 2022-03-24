
namespace GUI
{
    partial class frmLHD
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
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.lbMHD = new System.Windows.Forms.Label();
            this.btnLap = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbNL = new System.Windows.Forms.Label();
            this.lbMNV = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.dtpNL = new System.Windows.Forms.DateTimePicker();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.txtSoDien = new System.Windows.Forms.TextBox();
            this.lbSoDien = new System.Windows.Forms.Label();
            this.txtSoNuoc = new System.Windows.Forms.TextBox();
            this.lbSoNuoc = new System.Windows.Forms.Label();
            this.dgvMaNV = new System.Windows.Forms.DataGridView();
            this.dgvMP = new System.Windows.Forms.DataGridView();
            this.txtSNC = new System.Windows.Forms.TextBox();
            this.lbSNC = new System.Windows.Forms.Label();
            this.txtSDC = new System.Windows.Forms.TextBox();
            this.lbSDC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(158, 105);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(218, 27);
            this.txtMHD.TabIndex = 19;
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Location = new System.Drawing.Point(48, 108);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(104, 22);
            this.lbMHD.TabIndex = 14;
            this.lbMHD.Text = "Mã hóa đơn";
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(190, 318);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(93, 54);
            this.btnLap.TabIndex = 13;
            this.btnLap.Text = "Lập";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(121, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(242, 46);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Lập hóa đơn";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // lbNL
            // 
            this.lbNL.AutoSize = true;
            this.lbNL.Location = new System.Drawing.Point(48, 141);
            this.lbNL.Name = "lbNL";
            this.lbNL.Size = new System.Drawing.Size(81, 22);
            this.lbNL.TabIndex = 20;
            this.lbNL.Text = "Ngày lập";
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Location = new System.Drawing.Point(48, 174);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(91, 22);
            this.lbMNV.TabIndex = 22;
            this.lbMNV.Text = "Nhân viên";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(48, 207);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(62, 22);
            this.lbPhong.TabIndex = 24;
            this.lbPhong.Text = "Phòng";
            // 
            // dtpNL
            // 
            this.dtpNL.Location = new System.Drawing.Point(158, 136);
            this.dtpNL.Name = "dtpNL";
            this.dtpNL.Size = new System.Drawing.Size(292, 27);
            this.dtpNL.TabIndex = 25;
            // 
            // cbbNV
            // 
            this.cbbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(158, 171);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(157, 28);
            this.cbbNV.TabIndex = 26;
            // 
            // cbbPhong
            // 
            this.cbbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(158, 204);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(157, 28);
            this.cbbPhong.TabIndex = 27;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // txtSoDien
            // 
            this.txtSoDien.Location = new System.Drawing.Point(335, 238);
            this.txtSoDien.Name = "txtSoDien";
            this.txtSoDien.Size = new System.Drawing.Size(91, 27);
            this.txtSoDien.TabIndex = 29;
            // 
            // lbSoDien
            // 
            this.lbSoDien.AutoSize = true;
            this.lbSoDien.Location = new System.Drawing.Point(258, 241);
            this.lbSoDien.Name = "lbSoDien";
            this.lbSoDien.Size = new System.Drawing.Size(71, 22);
            this.lbSoDien.TabIndex = 28;
            this.lbSoDien.Text = "Số điện";
            // 
            // txtSoNuoc
            // 
            this.txtSoNuoc.Location = new System.Drawing.Point(335, 271);
            this.txtSoNuoc.Name = "txtSoNuoc";
            this.txtSoNuoc.Size = new System.Drawing.Size(91, 27);
            this.txtSoNuoc.TabIndex = 31;
            // 
            // lbSoNuoc
            // 
            this.lbSoNuoc.AutoSize = true;
            this.lbSoNuoc.Location = new System.Drawing.Point(258, 274);
            this.lbSoNuoc.Name = "lbSoNuoc";
            this.lbSoNuoc.Size = new System.Drawing.Size(76, 22);
            this.lbSoNuoc.TabIndex = 30;
            this.lbSoNuoc.Text = "Số nước";
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.AllowUserToAddRows = false;
            this.dgvMaNV.AllowUserToDeleteRows = false;
            this.dgvMaNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaNV.Location = new System.Drawing.Point(660, 27);
            this.dgvMaNV.Name = "dgvMaNV";
            this.dgvMaNV.ReadOnly = true;
            this.dgvMaNV.Size = new System.Drawing.Size(159, 342);
            this.dgvMaNV.TabIndex = 32;
            this.dgvMaNV.Visible = false;
            // 
            // dgvMP
            // 
            this.dgvMP.AllowUserToAddRows = false;
            this.dgvMP.AllowUserToDeleteRows = false;
            this.dgvMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMP.Location = new System.Drawing.Point(849, 27);
            this.dgvMP.Name = "dgvMP";
            this.dgvMP.ReadOnly = true;
            this.dgvMP.Size = new System.Drawing.Size(159, 342);
            this.dgvMP.TabIndex = 33;
            this.dgvMP.Visible = false;
            // 
            // txtSNC
            // 
            this.txtSNC.Enabled = false;
            this.txtSNC.Location = new System.Drawing.Point(158, 271);
            this.txtSNC.Name = "txtSNC";
            this.txtSNC.ReadOnly = true;
            this.txtSNC.Size = new System.Drawing.Size(91, 27);
            this.txtSNC.TabIndex = 37;
            // 
            // lbSNC
            // 
            this.lbSNC.AutoSize = true;
            this.lbSNC.Location = new System.Drawing.Point(48, 274);
            this.lbSNC.Name = "lbSNC";
            this.lbSNC.Size = new System.Drawing.Size(100, 22);
            this.lbSNC.TabIndex = 36;
            this.lbSNC.Text = "Số nước cũ";
            // 
            // txtSDC
            // 
            this.txtSDC.Enabled = false;
            this.txtSDC.Location = new System.Drawing.Point(158, 238);
            this.txtSDC.Name = "txtSDC";
            this.txtSDC.ReadOnly = true;
            this.txtSDC.Size = new System.Drawing.Size(91, 27);
            this.txtSDC.TabIndex = 35;
            // 
            // lbSDC
            // 
            this.lbSDC.AutoSize = true;
            this.lbSDC.Location = new System.Drawing.Point(48, 241);
            this.lbSDC.Name = "lbSDC";
            this.lbSDC.Size = new System.Drawing.Size(95, 22);
            this.lbSDC.TabIndex = 34;
            this.lbSDC.Text = "Số điện cũ";
            // 
            // frmLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 405);
            this.Controls.Add(this.txtSNC);
            this.Controls.Add(this.lbSNC);
            this.Controls.Add(this.txtSDC);
            this.Controls.Add(this.lbSDC);
            this.Controls.Add(this.dgvMP);
            this.Controls.Add(this.dgvMaNV);
            this.Controls.Add(this.txtSoNuoc);
            this.Controls.Add(this.lbSoNuoc);
            this.Controls.Add(this.txtSoDien);
            this.Controls.Add(this.lbSoDien);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.cbbNV);
            this.Controls.Add(this.dtpNL);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.lbMNV);
            this.Controls.Add(this.lbNL);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.lbMHD);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLHD";
            this.Text = "frmLHD";
            this.Load += new System.EventHandler(this.frmLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNL;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.DateTimePicker dtpNL;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.TextBox txtSoDien;
        private System.Windows.Forms.Label lbSoDien;
        private System.Windows.Forms.TextBox txtSoNuoc;
        private System.Windows.Forms.Label lbSoNuoc;
        private System.Windows.Forms.DataGridView dgvMaNV;
        private System.Windows.Forms.DataGridView dgvMP;
        private System.Windows.Forms.TextBox txtSNC;
        private System.Windows.Forms.Label lbSNC;
        private System.Windows.Forms.TextBox txtSDC;
        private System.Windows.Forms.Label lbSDC;
    }
}