using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DoAn
{
    public partial class Home : Form
    {
        public Home()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void Start()
        {
            Application.Run(new KhoiDong());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.08;
            if (this.Opacity < 0.1) this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(sender, e);
        }
        public void AddFormKS()
        {
            this.mainPanel.Controls.Clear();
            FKhoSach frmChild = new FKhoSach();
            frmChild.TopLevel = false;
            this.mainPanel.Controls.Add(frmChild);
            frmChild.Show();
        }
        public void AddFormNXB()
        {
            this.mainPanel.Controls.Clear();
            FNhaXuatBan frmChild = new FNhaXuatBan();
            frmChild.TopLevel = false;
            this.mainPanel.Controls.Add(frmChild);
            frmChild.Show();
        }
       
        public void AddFormHoaDon()
        {
            this.mainPanel.Controls.Clear();
            FHDB frmChild = new FHDB();
            frmChild.TopLevel = false;
            this.mainPanel.Controls.Add(frmChild);
            frmChild.Show();
        }
        public void AddFormKhachThue()
        {
            this.mainPanel.Controls.Clear();
            FKhachThue frmChild = new FKhachThue();
            frmChild.TopLevel = false;
            this.mainPanel.Controls.Add(frmChild);
            frmChild.Show();
        }
        public void AddFormMuaThue()
        {
            this.mainPanel.Controls.Clear();
            FDMT frmChild = new FDMT();
            frmChild.TopLevel = false;
            this.mainPanel.Controls.Add(frmChild);
            frmChild.Show();
        }
        public void AddFormDMS()
        {
            this.mainPanel.Controls.Clear();
            FSach frmChild = new FSach();
            frmChild.TopLevel = false;
            this.mainPanel.Controls.Add(frmChild);
            frmChild.Show();
        }

        private void btnkhosach_Click(object sender, EventArgs e)
        {
            AddFormKS();
        }


        private void btnnxb_Click(object sender, EventArgs e)
        {
            AddFormNXB();
        }


        private void btnkhachthue_Click(object sender, EventArgs e)
        {
            AddFormKhachThue();
        }


        private void btnbill_Click(object sender, EventArgs e)
        {
            AddFormHoaDon();
        }

        private void btnmuathue_Click(object sender, EventArgs e)
        {
            AddFormMuaThue();
        }

        private void btndms_Click_1(object sender, EventArgs e)
        {
            AddFormDMS();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
