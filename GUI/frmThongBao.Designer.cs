
namespace GUI
{
    partial class frmThongBao
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
            this.rtxtThongBao = new System.Windows.Forms.RichTextBox();
            this.lbTB = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnDang = new System.Windows.Forms.Button();
            this.lbNDTB = new System.Windows.Forms.Label();
            this.pnThongBao = new System.Windows.Forms.Panel();
            this.pnTitle.SuspendLayout();
            this.pnThongBao.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtThongBao
            // 
            this.rtxtThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtThongBao.Location = new System.Drawing.Point(3, 426);
            this.rtxtThongBao.Name = "rtxtThongBao";
            this.rtxtThongBao.Size = new System.Drawing.Size(904, 75);
            this.rtxtThongBao.TabIndex = 0;
            this.rtxtThongBao.Text = "";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.Location = new System.Drawing.Point(258, 11);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(512, 54);
            this.lbTB.TabIndex = 1;
            this.lbTB.Text = "Đây là nơi để thông báo";
            // 
            // pnTitle
            // 
            this.pnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTitle.Controls.Add(this.lbTB);
            this.pnTitle.Location = new System.Drawing.Point(12, 12);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(996, 77);
            this.pnTitle.TabIndex = 2;
            // 
            // btnDang
            // 
            this.btnDang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDang.Location = new System.Drawing.Point(913, 428);
            this.btnDang.Name = "btnDang";
            this.btnDang.Size = new System.Drawing.Size(80, 73);
            this.btnDang.TabIndex = 3;
            this.btnDang.Text = "Đăng";
            this.btnDang.UseVisualStyleBackColor = true;
            this.btnDang.Click += new System.EventHandler(this.btnDang_Click);
            // 
            // lbNDTB
            // 
            this.lbNDTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNDTB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNDTB.Location = new System.Drawing.Point(3, 0);
            this.lbNDTB.Name = "lbNDTB";
            this.lbNDTB.Size = new System.Drawing.Size(990, 423);
            this.lbNDTB.TabIndex = 4;
            this.lbNDTB.Text = "Thông báo giả định";
            // 
            // pnThongBao
            // 
            this.pnThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnThongBao.Controls.Add(this.lbNDTB);
            this.pnThongBao.Controls.Add(this.btnDang);
            this.pnThongBao.Controls.Add(this.rtxtThongBao);
            this.pnThongBao.Location = new System.Drawing.Point(12, 95);
            this.pnThongBao.Name = "pnThongBao";
            this.pnThongBao.Size = new System.Drawing.Size(996, 504);
            this.pnThongBao.TabIndex = 5;
            // 
            // frmThongBao
            // 
            this.AcceptButton = this.btnDang;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 611);
            this.Controls.Add(this.pnThongBao);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmThongBao";
            this.Text = "frmThongBao";
            this.Load += new System.EventHandler(this.frmThongBao_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnThongBao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtThongBao;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button btnDang;
        private System.Windows.Forms.Label lbNDTB;
        private System.Windows.Forms.Panel pnThongBao;
    }
}