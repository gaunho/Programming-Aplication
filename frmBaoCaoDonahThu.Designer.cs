namespace DoAnUngDung
{
    partial class frmBaoCaoDonahThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtGDoanhThu = new System.Windows.Forms.DataGridView();
            this.dTStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGDoanhThu);
            this.panel1.Location = new System.Drawing.Point(43, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 362);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.dtEnd);
            this.panel2.Controls.Add(this.dTStart);
            this.panel2.Location = new System.Drawing.Point(43, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 49);
            this.panel2.TabIndex = 1;
            // 
            // dtGDoanhThu
            // 
            this.dtGDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dtGDoanhThu.Name = "dtGDoanhThu";
            this.dtGDoanhThu.Size = new System.Drawing.Size(579, 356);
            this.dtGDoanhThu.TabIndex = 0;
            // 
            // dTStart
            // 
            this.dTStart.Location = new System.Drawing.Point(12, 14);
            this.dTStart.Name = "dTStart";
            this.dTStart.Size = new System.Drawing.Size(200, 20);
            this.dTStart.TabIndex = 0;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(361, 14);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 20);
            this.dtEnd.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(250, 11);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBaoCaoDonahThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 507);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoDonahThu";
            this.Text = "frmBaoCaoDonahThu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtGDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dTStart;
        private System.Windows.Forms.Button btnExit;
    }
}