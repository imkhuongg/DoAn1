using DoAn_1.MainForms;
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
using System.Xml.Linq;

namespace DoAn_1
{
    
   
    public partial class Form1 : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        
        public class User
        {
            private string Fname;
            private string LName;
            public String GetFname()
            {
                return this.Fname;
            }
            public String GetLname()
            {
                return this.LName;
            }
            public String setFname(string Fname)
            {
                return this.Fname = Fname;
            }
            public String setLname(string LName)
            {
                return this.LName = LName;
            }
        }
       
        public static Form1 instance;
        
        
        
        public Form1()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
       
        public string returnLastName()
        {
            User user = new User();
            return user.GetLname();
        }
        public string returnFName()
        {
            User user = new User();
            return user.GetFname();
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
        
        private void Login_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = textBox1.Text;
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=IMKHUONGG\SQLEXPRESS;Initial Catalog=user_table;database=QLDienNuocKTX_DoAn1;integrated security=SSPI";
            SqlCommand scmd = new SqlCommand("select count (*) from user_table where username= '"+textBox1.Text+"'  and password='"+textBox2.Text+"'", scn);
            
          
            scn.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống");
            }
            else if (scmd.ExecuteScalar().ToString() == "1")
            {
                
                this.Hide();
                MainScreen main = new MainScreen();
                main.ShowDialog();
                this.Close();

                

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }


        }
        public string getus()
        {
            string s;
            s = textBox1.Text;
            return s;
        }
        public string getps()
        {
            string ps = textBox2.Text;
            return ps;
        }
        private void RmCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (RmCheckB.Checked == true)
            {
                Properties.Settings.Default.username = textBox1.Text;
                Properties.Settings.Default.password = textBox2.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = textBox1.Text;
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getus();
            getps();
        }

        private void Foget_Click(object sender, EventArgs e)
        {
            this.Hide();
            FogotPass fogotPass = new FogotPass();
            fogotPass.ShowDialog();
            this.Close();

        }
    }
}
