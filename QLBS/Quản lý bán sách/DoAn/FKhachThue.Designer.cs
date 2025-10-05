namespace DoAn
{
    partial class FKhachThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKhachThue));
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.dtpngaymuon = new System.Windows.Forms.DateTimePicker();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvkt = new System.Windows.Forms.ListView();
            this.cmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaymuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaytra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tinhtrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnsua.FlatAppearance.BorderSize = 2;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnsua.Location = new System.Drawing.Point(82, 258);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(65, 30);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.Control;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnthem.FlatAppearance.BorderSize = 2;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnthem.Location = new System.Drawing.Point(11, 258);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(65, 30);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtinhtrang);
            this.groupBox1.Controls.Add(this.dtpngaytra);
            this.groupBox1.Controls.Add(this.dtpngaymuon);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtkh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Items.AddRange(new object[] {
            "Đã trả",
            "Chưa trả"});
            this.cbtinhtrang.Location = new System.Drawing.Point(150, 166);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(147, 21);
            this.cbtinhtrang.TabIndex = 10;
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaytra.Location = new System.Drawing.Point(447, 73);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(156, 20);
            this.dtpngaytra.TabIndex = 9;
            // 
            // dtpngaymuon
            // 
            this.dtpngaymuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaymuon.Location = new System.Drawing.Point(447, 28);
            this.dtpngaymuon.Name = "dtpngaymuon";
            this.dtpngaymuon.Size = new System.Drawing.Size(156, 20);
            this.dtpngaymuon.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(150, 115);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(152, 20);
            this.txtsdt.TabIndex = 6;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(447, 115);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(156, 20);
            this.txtcmnd.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(150, 73);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(152, 20);
            this.txtdiachi.TabIndex = 7;
            // 
            // txtkh
            // 
            this.txtkh.Location = new System.Drawing.Point(150, 28);
            this.txtkh.Name = "txtkh";
            this.txtkh.Size = new System.Drawing.Size(152, 20);
            this.txtkh.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvkt);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // lsvkt
            // 
            this.lsvkt.AllowDrop = true;
            this.lsvkt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmnd,
            this.ten,
            this.sdt,
            this.diachi,
            this.ngaymuon,
            this.ngaytra,
            this.tinhtrang,
            this.id});
            this.lsvkt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsvkt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvkt.Location = new System.Drawing.Point(3, 16);
            this.lsvkt.Name = "lsvkt";
            this.lsvkt.Size = new System.Drawing.Size(594, 159);
            this.lsvkt.TabIndex = 0;
            this.lsvkt.UseCompatibleStateImageBehavior = false;
            this.lsvkt.View = System.Windows.Forms.View.Details;
            this.lsvkt.SelectedIndexChanged += new System.EventHandler(this.lsvkt_SelectedIndexChanged);
            // 
            // cmnd
            // 
            this.cmnd.Text = "CMND";
            this.cmnd.Width = 87;
            // 
            // ten
            // 
            this.ten.Text = "Tên KH";
            this.ten.Width = 90;
            // 
            // sdt
            // 
            this.sdt.Text = "Số điện thoại";
            this.sdt.Width = 83;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa chỉ";
            this.diachi.Width = 113;
            // 
            // ngaymuon
            // 
            this.ngaymuon.Text = "Ngày mượn";
            this.ngaymuon.Width = 82;
            // 
            // ngaytra
            // 
            this.ngaytra.Text = "Ngày trả";
            this.ngaytra.Width = 74;
            // 
            // tinhtrang
            // 
            this.tinhtrang.Text = "Tình trạng";
            this.tinhtrang.Width = 77;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(195, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh Sách Thuê";
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnsearch.FlatAppearance.BorderSize = 2;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(525, 257);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(84, 30);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "   Tìm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(335, 257);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(168, 20);
            this.txtTimKiem.TabIndex = 14;
            // 
            // btnluu
            // 
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnluu.FlatAppearance.BorderSize = 2;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnluu.Location = new System.Drawing.Point(153, 258);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(65, 30);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnXacNhan.FlatAppearance.BorderSize = 3;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnXacNhan.Location = new System.Drawing.Point(619, 398);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(85, 71);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Visible = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnhuy.FlatAppearance.BorderSize = 2;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnhuy.Location = new System.Drawing.Point(224, 258);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(65, 30);
            this.btnhuy.TabIndex = 7;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnthoat.FlatAppearance.BorderSize = 3;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnthoat.Location = new System.Drawing.Point(619, 323);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 69);
            this.btnthoat.TabIndex = 16;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Visible = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FKhachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 484);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FKhachThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FKhachThue";
            this.Load += new System.EventHandler(this.FKhachThue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvkt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cbtinhtrang;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.DateTimePicker dtpngaymuon;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader cmnd;
        private System.Windows.Forms.ColumnHeader diachi;
        private System.Windows.Forms.ColumnHeader ngaymuon;
        private System.Windows.Forms.ColumnHeader ngaytra;
        private System.Windows.Forms.ColumnHeader tinhtrang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ColumnHeader sdt;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.ColumnHeader id;
        public System.Windows.Forms.Button btnXacNhan;
        public System.Windows.Forms.Button btnthoat;
    }
}