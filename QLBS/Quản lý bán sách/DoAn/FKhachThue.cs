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
    public partial class FKhachThue : Form
    {
        MUATHUE muathue = new MUATHUE();
        DataTable dt = new DataTable();
        bool themmoi = true;
        public FKhachThue()
        {
            InitializeComponent();
        }
       
        private void FKhachThue_Load(object sender, EventArgs e)
        {
            lsvkt.Items.Clear();
            hienthi(false);
            setButton(true);
            lsvkt.View = View.Details;
            lsvkt.FullRowSelect = true;
            lsvkt.MultiSelect = false;
            dt = muathue.LayDanhSachDonThueSach();
            get_Data();
            cbtinhtrang.SelectedIndex = 0; // Đã trả
        }
        public void hienthi(bool value)
        {
            txtdiachi.ReadOnly = !value;
            txtkh.ReadOnly = !value;
            txtsdt.ReadOnly = !value;
            txtcmnd.ReadOnly = !value;
            
        }
        public void clearbox()
        {
            txtcmnd.ResetText();
            txtkh.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();
            cbtinhtrang.ResetText();
            txtkh.Focus();
        }
        public void setButton(bool value)
        {
            btnthem.Enabled = value;
            btnsua.Enabled = value;
            btnluu.Enabled = !value;
            btnhuy.Enabled = !value;
        }
        private void get_Data()
        {
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem lsv = new ListViewItem();
                lsv.Text = row[0].ToString();
                lsv.SubItems.Add(row[1].ToString());
                lsv.SubItems.Add(row[2].ToString());
                lsv.SubItems.Add(row[3].ToString());
                lsv.SubItems.Add(row[4].ToString());
                lsv.SubItems.Add(row[5].ToString());
                lsv.SubItems.Add((row[6].ToString() == "1" ? "Chưa trả" : "Trả rồi"));
                lsv.SubItems.Add((row[7].ToString()));
                lsvkt.Items.Add(lsv);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            clearbox();
            themmoi = true;
            setButton(false);
            hienthi(true);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            lsvkt.Items.Clear();
            if (txtTimKiem.Text != "")
            {
                dt = muathue.LayDanhSachDonThueSach(txtTimKiem.Text);
                get_Data();
            }
            if (txtTimKiem.Text == "" || txtTimKiem.Text == null)
            {
                dt = muathue.LayDanhSachDonThueSach();
                get_Data();
            }
        }
        void Clear_TextBox()
        {
            txtcmnd.Text = "";
            txtdiachi.Text = "";
            txtkh.Text = "";
            txtsdt.Text = "";
        }
        private void lsvkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvkt.SelectedIndices.Count > 0)
            {
                Clear_TextBox();
                txtcmnd.Text = lsvkt.SelectedItems[0].SubItems[0].Text;
                txtkh.Text = lsvkt.SelectedItems[0].SubItems[1].Text;
                txtsdt.Text = lsvkt.SelectedItems[0].SubItems[2].Text;
                txtdiachi.Text = lsvkt.SelectedItems[0].SubItems[3].Text;
                dtpngaymuon.Text = lsvkt.SelectedItems[0].SubItems[4].Text;
                dtpngaytra.Text = lsvkt.SelectedItems[0].SubItems[5].Text;
                cbtinhtrang.SelectedIndex = lsvkt.SelectedItems[0].SubItems[6].Text == "Chưa trả" ? 1 : 0;
            }
            hienthi(false);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lsvkt.SelectedItems.Count > 0)
            {
                FDMT.sCMND = lsvkt.SelectedItems[0].SubItems[0].Text;
                FDMT.sCMNDKhachMuon = lsvkt.SelectedItems[0].SubItems[0].Text;
                FDMT.sHoTenKhachMuon = lsvkt.SelectedItems[0].SubItems[1].Text;
                FDMT.sNgayTra = lsvkt.SelectedItems[0].SubItems[5].Text.Trim().Split(' ')[0];
                FDMT.sNgayMuon = lsvkt.SelectedItems[0].SubItems[4].Text.Trim().Split(' ')[0];
                this.Hide();
            }
            if (lsvkt.SelectedItems.Count <= 0)
            {
                MessageBox.Show("vui lòng chọn trước khi xác nhận");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            hienthi(true);
            if (lsvkt.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "" && txtsdt.Text == "" && txtkh.Text == "" && txtcmnd.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ngaymuon = String.Format("{0:MM/dd/yyyy}", dtpngaymuon.Value);
                string ngaytra = String.Format("{0:MM/dd/yyyy}", dtpngaytra.Value);
                if (themmoi)
                {
                    muathue.PhieuThue(txtcmnd.Text, txtkh.Text,txtsdt.Text, txtdiachi.Text, ngaytra,ngaymuon,cbtinhtrang.SelectedIndex.ToString());
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    muathue.CapNhatPhieuThue(lsvkt.SelectedItems[0].SubItems[7].Text, txtcmnd.Text, txtkh.Text,txtsdt.Text, txtdiachi.Text,ngaytra,ngaymuon, cbtinhtrang.SelectedIndex.ToString());
                    MessageBox.Show("Cập nhật thành công");
                }
                clearbox();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            hienthi(false);
            setButton(true);
            clearbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
