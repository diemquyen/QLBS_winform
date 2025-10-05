using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAn
{
    public partial class FSach : Form
    {
        Sach s;
        DataTable dt;
        bool themmoi = true;
        public string strHinhAnh = "";
        public FSach()
        {
            s = new Sach();
            dt = new DataTable();
            InitializeComponent();
        }

        public void btpicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtimage.Text = openFileDialog1.FileName;
                if (File.Exists(openFileDialog1.FileName))
                {
                    File.Copy(openFileDialog1.FileName, "Img\\" + Path.GetFileName(openFileDialog1.FileName), true);
                    strHinhAnh = Path.GetFileName(openFileDialog1.FileName);

                }
            }
        }
        public void hienthi(bool value)
        {
            txtgiaban.ReadOnly = !value;
            txtimage.ReadOnly = !value;
            txtmasach.ReadOnly = !value;
            txttensach.ReadOnly = !value;
        }
        public void clearbox()
        {
            txtgiaban.ResetText();
            txtimage.ResetText();
            txtmasach.ResetText();
            txttensach.ResetText();
            txtmasach.Focus();
        }
        public void setButton(bool value)
        {
            btnthem.Enabled = value;
            btnxoa.Enabled = value;
            btnsua.Enabled = value;
            btnluu.Enabled = !value;
            btnhuy.Enabled = !value;
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FSach_Load(object sender, EventArgs e)
        {
            LoadDSPhieu();
            HienThiDS();
            hienthi(false);
            setButton(true);
            txtmasach.Focus();
        }
        public void LoadDSPhieu()
        {
            DataTable dt_bc = s.LayDSManxb();
            cbmanxb.DataSource = dt_bc;
            cbmanxb.DisplayMember = "Manxb";
            cbmanxb.ValueMember = "Manxb";
        }
        public void HienThiDS()
        {
            dt = s.LayDS();
            lsvds.Items.Clear();
            lsvds.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lsvds.Items.Add(dt.Rows[i]["ID"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Masach"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            hienthi(false);
            setButton(true);
            clearbox();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "" && txttensach.Text == "" && txtgiaban.Text == ""&&txtimage.Text=="")
            {
                MessageBox.Show("Không được để trống các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int x = int.Parse(txtgiaban.Text);
                if (themmoi)
                {
                    //strHinhAnh
                    s.Them(txtmasach.Text, txttensach.Text, cbmanxb.SelectedValue.ToString(),x, strHinhAnh);
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    s.Capnhap(lsvds.SelectedItems[0].SubItems[0].Text, txtmasach.Text, txttensach.Text, cbmanxb.SelectedValue.ToString(), x, strHinhAnh);
                    MessageBox.Show("Cập nhật thành công");
                }
                HienThiDS();
                clearbox();
                setButton(true);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
                {
                if (lsvds.SelectedIndices.Count > 0)
                {
                    s.Xoa(lsvds.SelectedItems[0].SubItems[0].Text);
                    lsvds.Items.RemoveAt(lsvds.SelectedIndices[0]);
                    clearbox();
                    setButton(true);
                }
                else
                    MessageBox.Show("Chọn mẫu tin cần xoá");
                
            }
            catch
            {
                MessageBox.Show("Không thể xoá sách vì đã có người mua", "Thông báo");
            }
        }

        private void lsvds_SelectedIndexChanged(object sender, EventArgs e)
        {
            setButton(true);
            hienthi(false);
            if (lsvds.SelectedIndices.Count > 0)
            {
                txtmasach.Text = lsvds.SelectedItems[0].SubItems[1].Text;
                txttensach.Text = lsvds.SelectedItems[0].SubItems[2].Text;
                cbmanxb.Text = lsvds.SelectedItems[0].SubItems[3].Text;
                txtgiaban.Text = lsvds.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
