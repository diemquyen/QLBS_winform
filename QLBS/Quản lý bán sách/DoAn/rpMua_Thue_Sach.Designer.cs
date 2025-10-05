namespace DoAn
{
    partial class rpMua_Thue_Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpMua_Thue_Sach));
            this.rpView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpView
            // 
            this.rpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpView.Location = new System.Drawing.Point(0, 0);
            this.rpView.Name = "rpView";
            this.rpView.Size = new System.Drawing.Size(493, 436);
            this.rpView.TabIndex = 0;
            this.rpView.Load += new System.EventHandler(this.rpView_Load);
            // 
            // rpMua_Thue_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 436);
            this.Controls.Add(this.rpView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rpMua_Thue_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN HÓA ĐƠN";
            this.Load += new System.EventHandler(this.rpMua_Thue_Sach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpView;
    }
}