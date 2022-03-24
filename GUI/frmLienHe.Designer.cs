
namespace GUI
{
    partial class frmLienHe
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
            this.pnLienHe = new System.Windows.Forms.Panel();
            this.lbLienHe = new System.Windows.Forms.Label();
            this.pnLienHe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLienHe
            // 
            this.pnLienHe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLienHe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnLienHe.Controls.Add(this.lbLienHe);
            this.pnLienHe.Location = new System.Drawing.Point(12, 12);
            this.pnLienHe.Name = "pnLienHe";
            this.pnLienHe.Size = new System.Drawing.Size(716, 435);
            this.pnLienHe.TabIndex = 0;
            // 
            // lbLienHe
            // 
            this.lbLienHe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLienHe.AutoSize = true;
            this.lbLienHe.Location = new System.Drawing.Point(212, 169);
            this.lbLienHe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLienHe.Name = "lbLienHe";
            this.lbLienHe.Size = new System.Drawing.Size(298, 44);
            this.lbLienHe.TabIndex = 1;
            this.lbLienHe.Text = "Công cmn ty TNHN 1 nùi thành viên\r\nSĐT: 0123456789";
            // 
            // frmLienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 459);
            this.Controls.Add(this.pnLienHe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmLienHe";
            this.Text = "frmLienHe";
            this.pnLienHe.ResumeLayout(false);
            this.pnLienHe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLienHe;
        private System.Windows.Forms.Label lbLienHe;
    }
}