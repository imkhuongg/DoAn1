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

      
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectDatabase.ConnDb);
            conn.Open();
            string query = "update user_table set password = '"+PassnewTxt.Text+"' where username = '"+Properties.Settings.Default.username+"'";
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
                DialogResult result = MessageBox.Show("Đổi mật khẩu thành công");
                if(result == DialogResult.OK)
                {
                    this.Hide();
                    this.Close();
                }
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "Ẩn";
            PassoldTxt.UseSystemPasswordChar = false;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = "Hiện";
            PassoldTxt.UseSystemPasswordChar = true;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.Text = "Ẩn";
            PassnewTxt.UseSystemPasswordChar = false;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            label4.Text = "Ẩn";
            PassnewTxt.UseSystemPasswordChar = true;
        }
    }
}
