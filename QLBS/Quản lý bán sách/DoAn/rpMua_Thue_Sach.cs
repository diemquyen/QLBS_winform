using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DoAn
{
    
    public partial class rpMua_Thue_Sach : Form
    {
        public string strYeuCau = "";
        public rpMua_Thue_Sach(string sResult)
        {
            InitializeComponent();
            strYeuCau = sResult;
        }

        private void rpMua_Thue_Sach_Load(object sender, EventArgs e)
        {
            this.rpView.RefreshReport();
        }
        private void rpView_Load(object sender, EventArgs e)
        {
            rpView.LocalReport.ReportEmbeddedResource = strYeuCau;
            string sTongTien = FDMT.sTongTienMuaSach; // tong tien mua sach
            rpView.LocalReport.SetParameters(new ReportParameter("TongTien", sTongTien, false));
            ReportDataSource rds = new ReportDataSource("dtMuaSach", FDMT.dtReportMuaSach);
            this.rpView.LocalReport.DataSources.Clear();
            this.rpView.LocalReport.DataSources.Add(rds);
            this.rpView.LocalReport.Refresh();
            this.rpView.RefreshReport();
        }
    }
}
