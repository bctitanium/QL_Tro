
namespace GUI
{
    partial class frmPDP
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnLap = new System.Windows.Forms.Button();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbMP = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.dgvMP = new System.Windows.Forms.DataGridView();
            this.txtMaPDP = new System.Windows.Forms.TextBox();
            this.lbMPDP = new System.Windows.Forms.Label();
            this.lbNgayDat = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.lbMNV = new System.Windows.Forms.Label();
            this.dgvMaNV = new System.Windows.Forms.DataGridView();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.lbMHD = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lbNgayTra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(18, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(385, 46);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Viết phiếu đặt phòng";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(152, 259);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(93, 54);
            this.btnLap.TabIndex = 1;
            this.btnLap.Text = "Lập";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Location = new System.Drawing.Point(33, 87);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(87, 22);
            this.lbMK.TabIndex = 2;
            this.lbMK.Text = "Mã khách";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(33, 120);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(42, 22);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Tên";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Location = new System.Drawing.Point(33, 153);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(63, 22);
            this.lbCMND.TabIndex = 4;
            this.lbCMND.Text = "CMND";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(33, 186);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(47, 22);
            this.lbSDT.TabIndex = 5;
            this.lbSDT.Text = "SĐT";
            // 
            // lbMP
            // 
            this.lbMP.AutoSize = true;
            this.lbMP.Location = new System.Drawing.Point(33, 219);
            this.lbMP.Name = "lbMP";
            this.lbMP.Size = new System.Drawing.Size(89, 22);
            this.lbMP.TabIndex = 6;
            this.lbMP.Text = "Mã phòng";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(152, 84);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(218, 27);
            this.txtMK.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(152, 117);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(218, 27);
            this.txtTen.TabIndex = 8;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(152, 150);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(218, 27);
            this.txtCMND.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(152, 183);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(218, 27);
            this.txtSDT.TabIndex = 10;
            // 
            // cbbPhong
            // 
            this.cbbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(152, 216);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(218, 28);
            this.cbbPhong.TabIndex = 29;
            // 
            // dgvMP
            // 
            this.dgvMP.AllowUserToAddRows = false;
            this.dgvMP.AllowUserToDeleteRows = false;
            this.dgvMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMP.Location = new System.Drawing.Point(1136, -2);
            this.dgvMP.Name = "dgvMP";
            this.dgvMP.ReadOnly = true;
            this.dgvMP.Size = new System.Drawing.Size(159, 342);
            this.dgvMP.TabIndex = 35;
            this.dgvMP.Visible = false;
            // 
            // txtMaPDP
            // 
            this.txtMaPDP.Location = new System.Drawing.Point(576, 84);
            this.txtMaPDP.Name = "txtMaPDP";
            this.txtMaPDP.Size = new System.Drawing.Size(288, 27);
            this.txtMaPDP.TabIndex = 37;
            // 
            // lbMPDP
            // 
            this.lbMPDP.AutoSize = true;
            this.lbMPDP.Location = new System.Drawing.Point(402, 87);
            this.lbMPDP.Name = "lbMPDP";
            this.lbMPDP.Size = new System.Drawing.Size(168, 22);
            this.lbMPDP.TabIndex = 36;
            this.lbMPDP.Text = "Mã phiếu đặt phòng";
            // 
            // lbNgayDat
            // 
            this.lbNgayDat.AutoSize = true;
            this.lbNgayDat.Location = new System.Drawing.Point(402, 153);
            this.lbNgayDat.Name = "lbNgayDat";
            this.lbNgayDat.Size = new System.Drawing.Size(82, 22);
            this.lbNgayDat.TabIndex = 38;
            this.lbNgayDat.Text = "Ngày đặt";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Location = new System.Drawing.Point(576, 148);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(288, 27);
            this.dtpNgayDat.TabIndex = 39;
            // 
            // cbbNV
            // 
            this.cbbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(576, 216);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(288, 28);
            this.cbbNV.TabIndex = 41;
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Location = new System.Drawing.Point(402, 219);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(91, 22);
            this.lbMNV.TabIndex = 40;
            this.lbMNV.Text = "Nhân viên";
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.AllowUserToAddRows = false;
            this.dgvMaNV.AllowUserToDeleteRows = false;
            this.dgvMaNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaNV.Location = new System.Drawing.Point(971, -2);
            this.dgvMaNV.Name = "dgvMaNV";
            this.dgvMaNV.ReadOnly = true;
            this.dgvMaNV.Size = new System.Drawing.Size(159, 342);
            this.dgvMaNV.TabIndex = 42;
            this.dgvMaNV.Visible = false;
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(576, 117);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(218, 27);
            this.txtMHD.TabIndex = 44;
            // 
            // lbMHD
            // 
            this.lbMHD.AutoSize = true;
            this.lbMHD.Location = new System.Drawing.Point(402, 120);
            this.lbMHD.Name = "lbMHD";
            this.lbMHD.Size = new System.Drawing.Size(104, 22);
            this.lbMHD.TabIndex = 43;
            this.lbMHD.Text = "Mã hóa đơn";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(576, 181);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(288, 27);
            this.dtpNgayTra.TabIndex = 46;
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Location = new System.Drawing.Point(402, 186);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(78, 22);
            this.lbNgayTra.TabIndex = 45;
            this.lbNgayTra.Text = "Ngày trả";
            // 
            // frmPDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 341);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.lbNgayTra);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.lbMHD);
            this.Controls.Add(this.dgvMaNV);
            this.Controls.Add(this.cbbNV);
            this.Controls.Add(this.lbMNV);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.lbNgayDat);
            this.Controls.Add(this.txtMaPDP);
            this.Controls.Add(this.lbMPDP);
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
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPDP";
            this.Load += new System.EventHandler(this.frmPDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbMP;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.DataGridView dgvMP;
        private System.Windows.Forms.TextBox txtMaPDP;
        private System.Windows.Forms.Label lbMPDP;
        private System.Windows.Forms.Label lbNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.DataGridView dgvMaNV;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.Label lbMHD;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lbNgayTra;
    }
}