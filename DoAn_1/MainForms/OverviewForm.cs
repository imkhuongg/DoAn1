using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DoAn_1.MainForms
{

    public partial class OverviewForm : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        public static OverviewForm Instance;
        public OverviewForm()
        {
            InitializeComponent();
            Instance = this;
        }
        public String Navigate ;


        void LoadFName()
        {

            command = Conn.CreateCommand();
            string CommandText1 = "SELECT last_name FROM user_table WHERE username='" + Properties.Settings.Default.username+"'";
            string CommandText2 = "SELECT first_name FROM user_table WHERE username='" + Properties.Settings.Default.username+"'";
            string PositionQuery = "SELECT position FROM user_table WHERE username ='" + Properties.Settings.Default.username+"'";
            string Image = "SELECT imageNV from user_table where username = '" + Properties.Settings.Default.username + "'";
            adapter.SelectCommand = command;
            SqlCommand Check = new SqlCommand(CommandText1, Conn);
            SqlCommand Check2 = new SqlCommand(CommandText2, Conn);
            SqlCommand cmdPosition = new SqlCommand(PositionQuery, Conn);
            SqlCommand getImage = new SqlCommand(Image, Conn);

            if (Check.ExecuteScalar() == null)
            {
                string F = Check2.ExecuteScalar().ToString();
                FName.Text = F;
            } else
            {
                string L = Check.ExecuteScalar().ToString();
                string F = Check2.ExecuteScalar().ToString();
                FName.Text = L + " " + F;
            }
            Avatar.ImageLocation = @"\DoAn1\DoAn_1\access\default.jpg";
            PositionTxt.Text = cmdPosition.ExecuteScalar().ToString();
            if (getImage.ExecuteScalar() == null)
            {
                Avatar.ImageLocation = @"\DoAn1\DoAn_1\access\default.jpg";
            }
            else
            {
                Avatar.ImageLocation = getImage.ExecuteScalar().ToString();
            }

        }
        private void OverviewForm_Load(object sender, EventArgs e)
        {


            Avatar.ImageLocation = @"\DoAn1\DoAn_1\access\default.jpg";
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            LoadFName();

            Conn.Close();
            Conn.Dispose();
        }
        private void panel13_Click(object sender, EventArgs e)
        {
            MainScreen.instance.LoadForm(new QLSVForm());
            MainScreen.instance.ChangeBtnQLSV();
        }

        private void BtnQLPKTXctn_Click(object sender, EventArgs e)
        {
            MainScreen.instance.LoadForm(new QLPKTXScreen());
            MainScreen.instance.ChangeBtnQLPKTX();
        }

        private void BtnTinhDienNuocCtn_Click(object sender, EventArgs e)
        {
            MainScreen.instance.LoadForm(new TinhDienNuocKTXScreen());
            MainScreen.instance.ChangeBtnTinhDienNuoc();
        }

        private void ThongKeBtnCtn_Click(object sender, EventArgs e)
        {
            MainScreen.instance.LoadForm(new ThongKeScreen());
            MainScreen.instance.ChangeBtnThongKe();

        }

        private void AboutBtnCtn_Click(object sender, EventArgs e)
        {
            MainScreen.instance.LoadForm(new AboutScreen());
            MainScreen.instance.ChangeBtnAbout();
        }

        private void SettingBtnCtn_Click(object sender, EventArgs e)
        {
            MainScreen.instance.LoadForm(new SettingScreen());
        }
    }
}
