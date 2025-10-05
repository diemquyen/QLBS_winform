namespace DoAn
{
    partial class FHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHDB));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmasach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvds = new System.Windows.Forms.ListView();
            this.mahd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaylap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnInBaoBao = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtBaoCao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN BÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpngay);
            this.groupBox1.Controls.Add(this.txttensach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbmasach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // dtpngay
            // 
            this.dtpngay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngay.Location = new System.Drawing.Point(93, 126);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(184, 20);
            this.dtpngay.TabIndex = 4;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(93, 82);
            this.txttensach.Name = "txttensach";
            this.txttensach.ReadOnly = true;
            this.txttensach.Size = new System.Drawing.Size(184, 20);
            this.txttensach.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách";
            // 
            // cbmasach
            // 
            this.cbmasach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbmasach.FormattingEnabled = true;
            this.cbmasach.Location = new System.Drawing.Point(93, 34);
            this.cbmasach.Name = "cbmasach";
            this.cbmasach.Size = new System.Drawing.Size(184, 21);
            this.cbmasach.TabIndex = 1;
            this.cbmasach.SelectedIndexChanged += new System.EventHandler(this.cbmasach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvds);
            this.groupBox2.Location = new System.Drawing.Point(366, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // lsvds
            // 
            this.lsvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mahd,
            this.ngaylap,
            this.masach});
            this.lsvds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsvds.FullRowSelect = true;
            this.lsvds.Location = new System.Drawing.Point(6, 19);
            this.lsvds.Name = "lsvds";
            this.lsvds.Size = new System.Drawing.Size(306, 160);
            this.lsvds.TabIndex = 0;
            this.lsvds.UseCompatibleStateImageBehavior = false;
            this.lsvds.View = System.Windows.Forms.View.Details;
            this.lsvds.SelectedIndexChanged += new System.EventHandler(this.lsvds_SelectedIndexChanged);
            // 
            // mahd
            // 
            this.mahd.Text = "Mã hóa đơn";
            this.mahd.Width = 82;
            // 
            // ngaylap
            // 
            this.ngaylap.Text = "Ngày lập";
            this.ngaylap.Width = 102;
            // 
            // masach
            // 
            this.masach.Text = "Mã sách";
            this.masach.Width = 114;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnhuy);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Location = new System.Drawing.Point(384, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 98);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.White;
            this.btnhuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnhuy.FlatAppearance.BorderSize = 3;
            this.btnhuy.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(130, 19);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(84, 66);
            this.btnhuy.TabIndex = 0;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.White;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnsua.FlatAppearance.BorderSize = 3;
            this.btnsua.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(21, 19);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(84, 66);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnInBaoBao
            // 
            this.btnInBaoBao.BackColor = System.Drawing.Color.White;
            this.btnInBaoBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInBaoBao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnInBaoBao.FlatAppearance.BorderSize = 3;
            this.btnInBaoBao.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnInBaoBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnInBaoBao.Image = ((System.Drawing.Image)(resources.GetObject("btnInBaoBao.Image")));
            this.btnInBaoBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBaoBao.Location = new System.Drawing.Point(23, 93);
            this.btnInBaoBao.Name = "btnInBaoBao";
            this.btnInBaoBao.Size = new System.Drawing.Size(182, 66);
            this.btnInBaoBao.TabIndex = 7;
            this.btnInBaoBao.Text = "IN BÁO CÁO";
            this.btnInBaoBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInBaoBao.UseVisualStyleBackColor = false;
            this.btnInBaoBao.Click += new System.EventHandler(this.btnInBaoBao_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtBaoCao);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnInBaoBao);
            this.groupBox4.Location = new System.Drawing.Point(12, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 165);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng in";
            // 
            // dtBaoCao
            // 
            this.dtBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaoCao.Location = new System.Drawing.Point(21, 51);
            this.dtBaoCao.Name = "dtBaoCao";
            this.dtBaoCao.Size = new System.Drawing.Size(184, 20);
            this.dtBaoCao.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chọn ngày in";
            // 
            // FHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 445);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHDB";
            this.Text = "FHDB";
            this.Load += new System.EventHandler(this.FHDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmasach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvds;
        private System.Windows.Forms.ColumnHeader mahd;
        private System.Windows.Forms.ColumnHeader ngaylap;
        private System.Windows.Forms.ColumnHeader masach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnInBaoBao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBaoCao;
    }
}