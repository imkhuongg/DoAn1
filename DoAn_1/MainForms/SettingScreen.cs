using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using DoAn_1.MainForms.Component;
using System.IO;

namespace DoAn_1.MainForms
{
    public partial class SettingScreen : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public SettingScreen()
        {
            InitializeComponent();
        }

        private void SettingScreen_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectDatabase.ConnDb);
            connection.Open();
            string ID = "SELECT username from user_table where username = '"+ Properties.Settings.Default.username + "'";
            string email = "SELECT email from user_table where username = '" + Properties.Settings.Default.username + "'";
            string position = "SELECT position from user_table where username = '" + Properties.Settings.Default.username + "'";
            string Lname = "SELECT last_name from user_table where username = '" + Properties.Settings.Default.username + "'";
            string Fname = "SELECT first_name from user_table where username = '" + Properties.Settings.Default.username + "'";
            string Image = "SELECT imageNV from user_table where username = '" + Properties.Settings.Default.username + "'";

            SqlCommand getID = new SqlCommand(ID, connection);
            SqlCommand getEmail = new SqlCommand(email, connection);
            SqlCommand getPosition = new SqlCommand(position, connection);
            SqlCommand getLName = new SqlCommand(Lname, connection);
            SqlCommand getFirstName = new SqlCommand(Fname, connection);
            SqlCommand getImage = new SqlCommand(Image, connection);

            if (getLName.ExecuteScalar() == null)
            {
                string F = getFirstName.ExecuteScalar().ToString();
                NameTxt.Text = F;
            }
            else
            {
                string L = getLName.ExecuteScalar().ToString();
                string F = getFirstName.ExecuteScalar().ToString();
                NameTxt.Text = L + " " + F;
            }
            IDTxt.Text = getID.ExecuteScalar().ToString();
            emailTxt.Text = getEmail.ExecuteScalar().ToString();
            PositionTxt.Text = getPosition.ExecuteScalar().ToString();
            if(getImage.ExecuteScalar() == null)
            {
                pictureBox1.ImageLocation = @"\DoAn1\DoAn_1\access\default.jpg";
            }
            else
            {
                pictureBox1.ImageLocation = getImage.ExecuteScalar().ToString();
            }
        }

        private void BtnNameBtn_Click(object sender, EventArgs e)
        {
            ChangeNameScreen changeNameScreen = new ChangeNameScreen();
            changeNameScreen.ShowDialog();
            this.Refresh();
        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            ChangePasword changePasword = new ChangePasword();
            changePasword.ShowDialog();
            this.Refresh();
        }
       

        private void ChangeAvartarBtn_Click(object sender, EventArgs e)
        {
           ChangeAvatar changeAvatar = new ChangeAvatar();
            changeAvatar.ShowDialog();
            
        }
    }
}
