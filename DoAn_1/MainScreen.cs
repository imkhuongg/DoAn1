using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_1.MainForms;

namespace DoAn_1
{
    public partial class MainScreen : Form
    {
        public static MainScreen instance;
        
        public MainScreen()
        {
            InitializeComponent();
            instance = this;

            LoadForm(new OverviewForm());
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        public void ChangeBtnOverview()
        {
            BtnOverview.BackColor = Color.FromArgb(88, 92, 89);
            QLSV.BackColor = Color.FromArgb(68, 74, 70);
            QLPKTX.BackColor = Color.FromArgb(68, 74, 70);
            QLDienNuoc.BackColor = Color.FromArgb(68, 74, 70);
            ThongKe.BackColor = Color.FromArgb(68, 74, 70);
            About_ctn.BackColor = Color.FromArgb(68, 74, 70);
        }
        public void ChangeBtnQLSV()
        {
            BtnOverview.BackColor = Color.FromArgb(68, 74, 70);
            QLSV.BackColor = Color.FromArgb(88, 92, 89);
            QLPKTX.BackColor = Color.FromArgb(68, 74, 70);
            QLDienNuoc.BackColor = Color.FromArgb(68, 74, 70);
            ThongKe.BackColor = Color.FromArgb(68, 74, 70);
            About_ctn.BackColor = Color.FromArgb(68, 74, 70);
        }
        public void ChangeBtnLogOut()
        {
            BtnOverview.BackColor = Color.FromArgb(68, 74, 70);
            QLSV.BackColor = Color.FromArgb(68, 74, 70);
            QLPKTX.BackColor = Color.FromArgb(68, 74, 70);
            QLDienNuoc.BackColor = Color.FromArgb(68, 74, 70);
            ThongKe.BackColor = Color.FromArgb(68, 74, 70);
            About_ctn.BackColor = Color.FromArgb(68, 74, 70);
            Logout.BackColor = Color.FromArgb(88, 92, 89);
        }
        public void ChangeBtnQLPKTX()
        {
            BtnOverview.BackColor = Color.FromArgb(68, 74, 70);
            QLSV.BackColor = Color.FromArgb(68, 74, 70);
            QLPKTX.BackColor = Color.FromArgb(88, 92, 89);
            QLDienNuoc.BackColor = Color.FromArgb(68, 74, 70);
            ThongKe.BackColor = Color.FromArgb(68, 74, 70);
            About_ctn.BackColor = Color.FromArgb(68, 74, 70);
        }
        public void ChangeBtnTinhDienNuoc()
        {
            BtnOverview.BackColor = Color.FromArgb(68, 74, 70);
            QLSV.BackColor = Color.FromArgb(68, 74, 70);
            QLPKTX.BackColor = Color.FromArgb(68, 74, 70);
            QLDienNuoc.BackColor = Color.FromArgb(88, 92, 89);
            ThongKe.BackColor = Color.FromArgb(68, 74, 70);
            About_ctn.BackColor = Color.FromArgb(68, 74, 70);
        }
        public void ChangeBtnThongKe()
        {
            BtnOverview.BackColor = Color.FromArgb(68, 74, 70);
            QLSV.BackColor = Color.FromArgb(68, 74, 70);
            QLPKTX.BackColor = Color.FromArgb(68, 74, 70);
            QLDienNuoc.BackColor = Color.FromArgb(68, 74, 70);
            ThongKe.BackColor = Color.FromArgb(88, 92, 89);
            About_ctn.BackColor = Color.FromArgb(68, 74, 70);
        }
       
        public void ChangeBtnAbout()
        {
            BtnOverview.BackColor = Color.FromArgb(68, 74, 70);
            QLSV.BackColor = Color.FromArgb(68, 74, 70);
            QLPKTX.BackColor = Color.FromArgb(68, 74, 70);
            QLDienNuoc.BackColor = Color.FromArgb(68, 74, 70);
            ThongKe.BackColor = Color.FromArgb(68, 74, 70);
            About_ctn.BackColor = Color.FromArgb(88, 92, 89);
        }
        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            ;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }
        private void BtnManage_Click(object sender, EventArgs e)
        {

        }


        private void QLSV_Click(object sender, EventArgs e)
        {
            LoadForm(new QLSVForm());
            ChangeBtnQLSV();
            
        }

        private void BtnOverview_Click(object sender, EventArgs e)
        {
            LoadForm(new OverviewForm());
            ChangeBtnOverview();
        }

        private void QLPKTX_Click(object sender, EventArgs e)
        {
            LoadForm(new QLPKTXScreen());
            ChangeBtnQLPKTX();
        }

        private void QLDienNuoc_Click(object sender, EventArgs e)
        {
            LoadForm(new TinhDienNuocKTXScreen());
            ChangeBtnTinhDienNuoc();
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            LoadForm(new ThongKeScreen());
            ChangeBtnThongKe();
        }





        private void About_ctn_Click(object sender, EventArgs e)
        {
            LoadForm(new AboutScreen());
            ChangeBtnAbout();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            ChangeBtnLogOut();
            this.Hide();
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            Form1 Login = new Form1();
            Login.ShowDialog();
            this.Close();
        }

        private void headerCtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
