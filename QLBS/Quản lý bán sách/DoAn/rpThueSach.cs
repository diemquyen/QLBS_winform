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
    public partial class rpThueSach : Form
    {
        public string strYeuCau = "";
        public rpThueSach(string sResult)
        {
            InitializeComponent();
            strYeuCau = sResult;
        }

        private void rpThueSach_Load(object sender, EventArgs e)
        {

            this.rvThueSach.RefreshReport();
        }

        private void rvThueSach_Load(object sender, EventArgs e)
        {
            rvThueSach.LocalReport.ReportEmbeddedResource = strYeuCau;

            rvThueSach.LocalReport.SetParameters(new ReportParameter("TongTien", FDMT.sTongTienThueSach, false));
            rvThueSach.LocalReport.SetParameters(new ReportParameter("TenKhachThue", FDMT.sHoTenKhachMuon, false));
            rvThueSach.LocalReport.SetParameters(new ReportParameter("NgayMuon", FDMT.sNgayMuon, false));
            rvThueSach.LocalReport.SetParameters(new ReportParameter("NgayTra", FDMT.sNgayTra, false));
            rvThueSach.LocalReport.SetParameters(new ReportParameter("CMND", FDMT.sCMNDKhachMuon, false));

            ReportDataSource rds = new ReportDataSource("dtMuaSach", FDMT.dtReportThueSach);

            this.rvThueSach.LocalReport.DataSources.Clear();
            this.rvThueSach.LocalReport.DataSources.Add(rds);
            this.rvThueSach.LocalReport.Refresh();
            this.rvThueSach.RefreshReport();
        }
    }
}
