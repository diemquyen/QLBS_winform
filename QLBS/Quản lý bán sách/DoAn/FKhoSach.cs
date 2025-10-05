using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DoAn
{
    public partial class FKhoSach : Form
    {
        KhoSach s;
        DataTable dt;
        bool themmoi = true;
        public FKhoSach()
        {
            s = new KhoSach();
            dt = new DataTable();
            InitializeComponent();
        }
        public void hienthi(bool value)
        {
            
            txtsoluong.ReadOnly = !value;
        }
        public void clearbox()
        {
            txtsoluong.ResetText();
            cbmasach.ResetText();
            txttensach.ResetText();
            cbmasach.Focus();
        }
        public void HienThiDS()
        {
            dt = s.LayDS();
            lsvds.Items.Clear();
            lsvds.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lsvds.Items.Add(dt.Rows[i]["Mahd"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Masach"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
        }
        public void setButton(bool value)
        {
            btnthem.Enabled = value;
            btnxoa.Enabled = value;
            btnsua.Enabled = value;
            btnluu.Enabled = !value;
            btnhuy.Enabled = !value;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            clearbox();
            themmoi = true;
            setButton(false);
            hienthi(true);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            hienthi(true);
            if (lsvds.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void lsvds_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton(true);
            hienthi(false);
            if (lsvds.SelectedIndices.Count > 0)
            {
                cbmasach.Text = lsvds.SelectedItems[0].SubItems[1].Text;
                txtsoluong.Text = lsvds.SelectedItems[0].SubItems[2].Text;
                dtpngaynhap.Value = DateTime.Parse(lsvds.SelectedItems[0].SubItems[3].Text);
            }
        }
        public void LoadDSSAch()
        {
            DataTable dt_bc = s.LayDSMaSach();
            cbmasach.DataSource = dt_bc;
            cbmasach.DisplayMember = "Masach";
            cbmasach.ValueMember = "Tensach";
            if (cbmasach.Items.Count > 0)
            {
                cbmasach.SelectedIndex = 0;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cbmasach.Text == ""&& txtsoluong.Text == "")
            {
                MessageBox.Show("Không được để trống các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ngay=String.Format("{0:MM/dd/yyyy}", dtpngaynhap.Value);
                int x = Convert.ToInt32(txtsoluong.Text);
                if (themmoi)
                {
                    s.Them(cbmasach.Text, x,ngay);
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    s.Capnhap(lsvds.SelectedItems[0].SubItems[0].Text, cbmasach.Text, x,ngay);
                    MessageBox.Show("Cập nhật thành công");
                }
                HienThiDS();
                clearbox();
                setButton(true);
            }
        }

        private void FKhoSach_Load(object sender, EventArgs e)
        {
            HienThiDS();
            hienthi(false);
            setButton(true);
            LoadDSSAch();
            clearbox();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            s.Xoa(lsvds.SelectedItems[0].SubItems[0].Text);
            lsvds.Items.RemoveAt(lsvds.SelectedIndices[0]);
            clearbox();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            hienthi(false);
            setButton(true);
            clearbox();
        }

        private void cbmasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttensach.Text = cbmasach.SelectedValue.ToString();
        }
    }
}
