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

namespace DoAn
{
    public partial class FNhaXuatBan : Form
    {
        NhaXuatBan s;
        DataTable dt;
        bool themmoi=true;
        BindingSource source;
        public FNhaXuatBan()
        {
            InitializeComponent();
            s = new NhaXuatBan();
            dt = new DataTable();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            clearbox();
            themmoi = true;
            setButton(false);
            hienthi(true);
        }

        private void FNhaXuatBan_Load(object sender, EventArgs e)
        {
            HienThiDS();
            hienthi(false);
            setButton(true);
            source = new BindingSource();
            dt = s.LayDSNXB();
            foreach (DataRow lb in dt.Rows)
                source.Add(lb);
        }
        public void HienThiDS()
        {
            dt = s.LayDSNXB();
            lsvnxb.Items.Clear();
            lsvnxb.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lsvnxb.Items.Add(dt.Rows[i]["ID"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Manxb"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());

            }
        }
        public void hienthi(bool value)
        {
            txtdiachi.ReadOnly = !value;
            txtten.ReadOnly = !value;
            txtsdt.ReadOnly = !value;
            txtma.ReadOnly = !value;
        }
        public void clearbox()
        {
            txtma.ResetText();
            txtten.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();
            txtma.Focus();
        }
        public void setButton(bool value)
        {
            btnthem.Enabled = value;
            btnxoa.Enabled = value;
            btnsua.Enabled = value;
            btnluu.Enabled = !value;
            btnhuy.Enabled = !value;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            hienthi(true);
            if(lsvnxb.SelectedIndices.Count>0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvnxb.SelectedIndices.Count > 0)
                {
                    s.XoaNXB(lsvnxb.SelectedItems[0].SubItems[0].Text);
                    lsvnxb.Items.RemoveAt(lsvnxb.SelectedIndices[0]);
                    clearbox();
                }
                else
                    MessageBox.Show("Chọn mẫu tin cần xóa", "Thông Tin");
            }
            catch
            {
                MessageBox.Show("Không thể xóa nhà xuất bản này vì chứa ràng buộc với sách","Thông Báo");
            }
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            hienthi(false);
            setButton(true);
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if(txtdiachi.Text == "" && txtsdt.Text=="")
            {
                MessageBox.Show("Không được để trống các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(themmoi)
                {
                    s.ThemNXB(txtma.Text, txtten.Text, txtdiachi.Text, txtsdt.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    s.CapnhapNXB(lsvnxb.SelectedItems[0].SubItems[0].Text, txtma.Text, txtten.Text, txtdiachi.Text, txtsdt.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
                HienThiDS();
                clearbox();
                setButton(true);
            }
        }

        private void lsvnxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton(true);
            hienthi(false);
            if(lsvnxb.SelectedIndices.Count>0)
            {
                txtma.Text = lsvnxb.SelectedItems[0].SubItems[1].Text;
                txtten.Text = lsvnxb.SelectedItems[0].SubItems[2].Text;
                txtdiachi.Text = lsvnxb.SelectedItems[0].SubItems[3].Text;
                txtsdt.Text = lsvnxb.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
            HienThiDS();
        }
    }
}
