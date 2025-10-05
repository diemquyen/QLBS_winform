using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FDMT : Form
    {
        MUATHUE s;
        DataTable dt;
        public static DataTable dtReportMuaSach = new DataTable();
        public static DataTable dtReportThueSach = new DataTable();
        public static string sTongTienMuaSach = "";
        public static string sTongTienThueSach = "";
        public static string sHoTenKhachMuon = "";
        public static string sCMNDKhachMuon = "";
        public static string sNgayMuon = "";
        public static string sNgayTra = "";
        public static string sMaSachThue = "";
        public static string sCMND = "";
        public FDMT()
        {
            
            InitializeComponent();
            s = new MUATHUE();
            dt = new DataTable();
        }
        public void HienThiDS()
        {
            dt = s.LayDS();
            lvdms.Items.Clear();
            lvdms.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvdms.Items.Add(dt.Rows[i]["ID"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Masach"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Tensach"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Giaban"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Manxb"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Hinhanh"].ToString());

            }
        }
        public void hienthi(bool value)
        {
            txtgiasach.ReadOnly = !value;
            txtmasach.ReadOnly = !value;
            txtnxb.ReadOnly = !value;
            txttensach.ReadOnly = !value;
            txtgiasach.ReadOnly = !value;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            //SELECT* FROM SACH WHERE Masach LIKE '%N%' OR Tensach LIKE N'%a%' OR Manxb LIKE '%a%'
            //lvdms
            dt = s.Tim(txtsearch.Text);
            lvdms.Items.Clear();
            lvdms.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvdms.Items.Add(dt.Rows[i]["ID"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Masach"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Tensach"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Giaban"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Manxb"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Hinhanh"].ToString());
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lsvChon = lvdms.SelectedItems[0];
                ListViewItem lsvNew = new ListViewItem();
                lsvNew.Text = lsvChon.SubItems[2].Text;
                lsvNew.SubItems.Add(lsvChon.SubItems[3].Text);
                lsvNew.SubItems.Add(lsvChon.SubItems[1].Text);
                lvChon.Items.Add(lsvNew);
                int iTongTien = 0;
                foreach (ListViewItem lvCon in lvChon.Items)
                {
                    iTongTien += int.Parse(lvCon.SubItems[1].Text);
                }
                txtGiaThue.Text = (iTongTien * (0.1)).ToString();
                txtTongTien.Text = iTongTien.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sách trước");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lsvChon = lvChon.SelectedItems[0];
                lsvChon.Remove();

                int iTongTien = 0;
                foreach (ListViewItem lvCon in lvChon.Items)
                {
                    iTongTien += int.Parse(lvCon.SubItems[1].Text);
                }
                txtGiaThue.Text = (iTongTien * (0.1)).ToString();
                txtTongTien.Text = iTongTien.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sách cần hủy");
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {

            if (lvChon.Items.Count > 0)
            {
                foreach (ListViewItem lvCon in lvChon.Items)
                {
                    string strMaSach = lvCon.SubItems[2].Text;
                    s.ThemMua(strMaSach);
                }


                dtReportMuaSach.Columns.Clear();
                dtReportMuaSach.Rows.Clear();
                dtReportMuaSach.Columns.Add("colTenSach");
                dtReportMuaSach.Columns.Add("colGia");
                sTongTienMuaSach = txtTongTien.Text;
                foreach (ListViewItem lvCon in lvChon.Items)
                {
                    dtReportMuaSach.Rows.Add(lvCon.SubItems[0].Text, lvCon.SubItems[1].Text);
                }
                rpMua_Thue_Sach frmReportCon = new rpMua_Thue_Sach("DoAn.ThongTinMua.rdlc");
                frmReportCon.Show();
            }
            else
                MessageBox.Show("Chưa có sách để mua trong danh sach chọn vui lòng chọn sách");
        }

        private void bntthue_Click(object sender, EventArgs e)
        {
           
            if (sCMND == "" || sCMND == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin khách thuê trước khi thuê");
            }
            bntthue.Enabled = false;
            btnNhapTenKhachHang.Enabled = true;
            if (lvChon.Items.Count > 0)
            {
                foreach (ListViewItem lvCon in lvChon.Items)
                {
                    string strMaSach = lvCon.SubItems[2].Text;
                    s.ThemThue(lvCon.SubItems[2].Text, (int.Parse(lvCon.SubItems[1].Text) * 0.1).ToString(),sCMND);
                }
                s.UpdateThongTinKhachThue(sCMND);
                MessageBox.Show("Thuê thành công");

                sTongTienThueSach = txtGiaThue.Text;
                dtReportThueSach.Columns.Clear();
                dtReportThueSach.Rows.Clear();
                dtReportThueSach.Columns.Add("colTenSach");
                dtReportThueSach.Columns.Add("colGia");
                sTongTienMuaSach = txtTongTien.Text;
                foreach (ListViewItem lvCon in lvChon.Items)
                {
                    dtReportThueSach.Rows.Add(lvCon.SubItems[0].Text, lvCon.SubItems[1].Text);
                }
                rpThueSach frmReportCon = new rpThueSach("DoAn.ThongTinThue.rdlc");
                frmReportCon.Show();
                
            }
        }    

        private void lvdms_SelectedIndexChanged2(object sender, EventArgs e)
        {
            if (lvdms.SelectedIndices.Count > 0)
            {
                txtmasach.Text=lvdms.SelectedItems[0].SubItems[1].Text;
                txttensach.Text = lvdms.SelectedItems[0].SubItems[2].Text;
                txtgiasach.Text = lvdms.SelectedItems[0].SubItems[3].Text;
                txtnxb.Text = lvdms.SelectedItems[0].SubItems[4].Text;
                ptb.Image = Image.FromFile("Img/"+lvdms.SelectedItems[0].SubItems[5].Text);
            }
            
        }

        private void FDMS_Load(object sender, EventArgs e)
        {
            HienThiDS();
            bntthue.Enabled = false;
            hienthi(false);
        }

        private void btnNhapTenKhachHang_Click(object sender, EventArgs e)
        {
            if (lvChon.Items.Count > 0)
            {
                FKhachThue fkt = new FKhachThue();
                fkt.btnXacNhan.Visible = true;
                fkt.btnthoat.Visible = true;
                fkt.Show();
                bntthue.Enabled = true;
                btnNhapTenKhachHang.Enabled = false;
            }
            else
                MessageBox.Show("Chưa có sách để mua trong danh sach chọn vui lòng chọn sách");

        }
    }
}
