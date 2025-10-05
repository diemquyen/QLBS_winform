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
    public partial class ReportHoaDon : Form
    {
        public string strYeuCau = "";
        public ReportHoaDon(string sResult)
        {
            InitializeComponent();
            strYeuCau = sResult;
        }

        private void ReportHoaDon_Load(object sender, EventArgs e)
        {
            this.rpvHoaDon.RefreshReport();
        }

        private void rpvHoaDon_Load(object sender, EventArgs e)
        {
            rpvHoaDon.LocalReport.ReportEmbeddedResource = strYeuCau;
            ReportDataSource rds = new ReportDataSource("HoaDonMua",FHDB.dtGet_Report);
            this.rpvHoaDon.LocalReport.DataSources.Clear();
            this.rpvHoaDon.LocalReport.DataSources.Add(rds);
            this.rpvHoaDon.LocalReport.Refresh();
            this.rpvHoaDon.RefreshReport();


        }
    }
}
