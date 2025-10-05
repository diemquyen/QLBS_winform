namespace DoAn
{
    partial class rpThueSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpThueSach));
            this.rvThueSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvThueSach
            // 
            this.rvThueSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvThueSach.Location = new System.Drawing.Point(0, 0);
            this.rvThueSach.Name = "rvThueSach";
            this.rvThueSach.Size = new System.Drawing.Size(666, 460);
            this.rvThueSach.TabIndex = 0;
            this.rvThueSach.Load += new System.EventHandler(this.rvThueSach_Load);
            // 
            // rpThueSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 460);
            this.Controls.Add(this.rvThueSach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rpThueSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Thuê Sách";
            this.Load += new System.EventHandler(this.rpThueSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvThueSach;
    }
}