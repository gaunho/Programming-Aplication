namespace DoAnUngDung
{
    partial class frmTableManagerUser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBanSo = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btnTamTinh = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoThuTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenMon1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.userToolStripMenuItem.Image = global::DoAnUngDung.Properties.Resources.manager;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.userToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::DoAnUngDung.Properties.Resources.profile;
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Image = global::DoAnUngDung.Properties.Resources.logout__2_;
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay đổi mật khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::DoAnUngDung.Properties.Resources.logout;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.báoCáoDoanhThuToolStripMenuItem});
            this.adminToolStripMenuItem.Image = global::DoAnUngDung.Properties.Resources.profile;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Image = global::DoAnUngDung.Properties.Resources.book1;
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemThôngTinToolStripMenuItem.Text = "Xem Thông Tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            this.báoCáoDoanhThuToolStripMenuItem.Image = global::DoAnUngDung.Properties.Resources.loan;
            this.báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            this.báoCáoDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.báoCáoDoanhThuToolStripMenuItem.Text = "Báo Cáo Doanh Thu";
            this.báoCáoDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(645, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 375);
            this.panel1.TabIndex = 1;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenMon,
            this.colDonGia,
            this.colTinhTrang});
            this.listView2.Location = new System.Drawing.Point(12, 114);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(280, 337);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 58);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Ban 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 58);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Ban 2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 39);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 58);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Ban 3";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 115);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(59, 58);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Ban 4";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 115);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(59, 58);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Ban 5";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(186, 115);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(59, 58);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Ban 6";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(31, 270);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(59, 58);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "Ban 10";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(109, 270);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(59, 58);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "Ban 11";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(186, 270);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(59, 58);
            this.textBox9.TabIndex = 0;
            this.textBox9.Text = "Ban 12";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(308, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Muc Order";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSoThuTu,
            this.colTenMon1,
            this.colDonGia1,
            this.colSoLuong,
            this.colThanhTien});
            this.listView1.Location = new System.Drawing.Point(10, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 246);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(645, 39);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenBan.TabIndex = 5;
            this.btnChuyenBan.Text = "Chuyen Ban";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ma Hoa Don";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(217, 73);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(13, 75);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(183, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(379, 38);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(102, 20);
            this.textBox10.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ban So";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBanSo
            // 
            this.txtBanSo.Location = new System.Drawing.Point(553, 40);
            this.txtBanSo.Name = "txtBanSo";
            this.txtBanSo.Size = new System.Drawing.Size(74, 20);
            this.txtBanSo.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(79, 39);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(117, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thoi Gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giam Gia";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(379, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tong Tien";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(379, 114);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(102, 20);
            this.textBox11.TabIndex = 7;
            // 
            // btnTamTinh
            // 
            this.btnTamTinh.Location = new System.Drawing.Point(553, 71);
            this.btnTamTinh.Name = "btnTamTinh";
            this.btnTamTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTamTinh.TabIndex = 5;
            this.btnTamTinh.Text = "Tam Tinh";
            this.btnTamTinh.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(553, 114);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh Toan";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "(VND)";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(738, 38);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Lam Moi";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 43;
            // 
            // colTenMon
            // 
            this.colTenMon.Text = "Ten Mon";
            this.colTenMon.Width = 80;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Don Gia";
            this.colDonGia.Width = 75;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tinh Trang";
            this.colTinhTrang.Width = 81;
            // 
            // colSoThuTu
            // 
            this.colSoThuTu.Text = "STT";
            this.colSoThuTu.Width = 37;
            // 
            // colTenMon1
            // 
            this.colTenMon1.Text = "Ten Mon";
            // 
            // colDonGia1
            // 
            this.colDonGia1.Text = "Don Gia";
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "So Luong";
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thanh Tien";
            this.colThanhTien.Width = 77;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(31, 192);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(59, 58);
            this.textBox12.TabIndex = 0;
            this.textBox12.Text = "Ban 7";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(109, 192);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(59, 58);
            this.textBox13.TabIndex = 0;
            this.textBox13.Text = "Ban 8";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(186, 192);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(59, 58);
            this.textBox14.TabIndex = 0;
            this.textBox14.Text = "Ban 9";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(831, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmTableManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 476);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtBanSo);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTamTinh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTableManagerUser";
            this.Text = "Quản Lí Nhà Hàng";
            this.Load += new System.EventHandler(this.frmTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBanSo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button btnTamTinh;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenMon;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.ColumnHeader colSoThuTu;
        private System.Windows.Forms.ColumnHeader colTenMon1;
        private System.Windows.Forms.ColumnHeader colDonGia1;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnExit;
    }
}