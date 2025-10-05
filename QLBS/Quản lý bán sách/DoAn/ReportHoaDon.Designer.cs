namespace DoAn
{
    partial class ReportHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportHoaDon));
            this.rpvHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvHoaDon
            // 
            this.rpvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpvHoaDon.Name = "rpvHoaDon";
            this.rpvHoaDon.Size = new System.Drawing.Size(665, 418);
            this.rpvHoaDon.TabIndex = 0;
            this.rpvHoaDon.Load += new System.EventHandler(this.rpvHoaDon_Load);
            // 
            // ReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 418);
            this.Controls.Add(this.rpvHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Hóa Dơn";
            this.Load += new System.EventHandler(this.ReportHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHoaDon;
    }
}