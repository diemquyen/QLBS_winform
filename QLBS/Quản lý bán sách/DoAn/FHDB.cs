using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FHDB : Form
    {
        HDB s;
        DataTable dt;
        public static DataTable dtGet_Report = null;
        public FHDB()
        {
            s = new HDB();
            dt = new DataTable();
            InitializeComponent();
        }
        public void clearbox()
        {
            txttensach.ResetText();
            cbmasach.ResetText();
        }
        public void LoadDSSAch()
        {
            DataTable dt_bc = s.GetMS();
            cbmasach.DataSource = dt_bc;
            cbmasach.DisplayMember = "Masach";
            cbmasach.ValueMember = "Tensach";
            if(cbmasach.Items.Count>0)
            {
                cbmasach.SelectedIndex = 0;
            }
        }

        private void cbmasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttensach.Text = cbmasach.SelectedValue.ToString();
        }
        public void HienThi()
        {
            dt = s.LayDS();
            
            lsvds.Items.Clear();
            lsvds.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lsvds.Items.Add(dt.Rows[i]["Mahd"].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }
        private void FHDB_Load(object sender, EventArgs e)
        {
            LoadDSSAch();
            clearbox();
            HienThi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpngay.Value);
                
            if (lsvds.SelectedIndices.Count > 0)
            {
                s.Capnhap(lsvds.SelectedItems[0].SubItems[0].Text,ngay,cbmasach.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            clearbox();
        }

        private void lsvds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvds.SelectedIndices.Count > 0)
            {
                cbmasach.Text = lsvds.SelectedItems[0].SubItems[2].Text;
                dtpngay.Value = DateTime.Parse(lsvds.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void btnInBaoBao_Click(object sender, EventArgs e)
        {
            string iDate = dtBaoCao.Text;
            DateTime oDate = Convert.ToDateTime(iDate);
            string strGet_Query = oDate.Year + "/" + oDate.Month + "/" + oDate.Day;

            dtGet_Report = s.get_Date_Report(strGet_Query);

            ReportHoaDon frmReportCon = new ReportHoaDon("DoAn.rpHoaDon.rdlc");
            frmReportCon.Show();
        }
    }
}
