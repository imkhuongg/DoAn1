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

namespace DoAn_1.MainForms.Component
{
    public partial class ChangePasword : Form
    {
        SqlCommand cm1;
        SqlCommand cm2;
        SqlConnection conn;
        public ChangePasword()
        {
            InitializeComponent();
        }

        private void ChangePasword_Load(object sender, EventArgs e)
        {
            PassoldTxt.UseSystemPasswordChar = true;
            PassnewTxt.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Hiện";
            if(label3.Text == "Hiện")
            {
                label3.Text = "Ẩn";
                PassoldTxt.UseSystemPasswordChar=false;
            }
            else if(label3.Text == "Ẩn")
            {
                label3.Text = "Hiện";
                PassoldTxt.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Hiện";
            if (label4.Text == "Hiện")
            {
                label4.Text = "Ẩn";
                PassnewTxt.UseSystemPasswordChar = false;
            }
            else if(label4.Text == "Ẩn")
            {
                label4.Text = "Hiện";
                PassnewTxt.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectDatabase.ConnDb);
            conn.Open();
            string query = "update user_table set password = '"+PassnewTxt+"' where username = '"+Properties.Settings.Default.username+"'";
            string check = "select count(password) from user_table where password = '"+PassoldTxt.Text+ "' and username = '"+Properties.Settings.Default.username+"'";

            SqlCommand sqlCommand = new SqlCommand(check , conn);

            if(PassoldTxt.Text == "" || PassnewTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                conn.Close();
            } else if(sqlCommand.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                conn.Close();
            }
            else
            {
                cm1 = new SqlCommand(query , conn);
                cm1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = "Hiện";
            if (label3.Text == "Hiện")
            {
                label3.Text = "Ẩn";
                PassoldTxt.UseSystemPasswordChar = false;
            }
            else if (label3.Text == "Ẩn")
            {
                label3.Text = "Hiện";
                PassoldTxt.UseSystemPasswordChar = true;
            }
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Text = "Hiện";
            if (label4.Text == "Hiện")
            {
                label4.Text = "Ẩn";
                PassnewTxt.UseSystemPasswordChar = false;
            }
            else if (label4.Text == "Ẩn")
            {
                label4.Text = "Hiện";
                PassnewTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
