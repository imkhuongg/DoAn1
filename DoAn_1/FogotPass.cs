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

namespace DoAn_1
{
    public partial class FogotPass : Form
    {
        SqlConnection conn;
        SqlCommand sqlCommand;
        public FogotPass()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectDatabase.ConnDb);
            conn.Open();

            string query = "select count(*) from user_table where username = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            if(textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                conn.Close();
            }
            else if(cmd.ExecuteScalar().ToString() == "0")
            {
               label7.Text = "Không có mã nhân viên "+textBox1.Text;
            }
            else if(cmd.ExecuteScalar().ToString() == "1")
            {
                label7.Text = "Có mã nhân viên " + textBox1.Text;
            }
        }

        private void FogotPass_Load(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectDatabase.ConnDb);
            conn.Open();

            string query = "select count(*) from user_table where username = '" + textBox1.Text + "'";
            string query2 = "update user_table set password = '"+textBox2.Text+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            if(textBox1.Text == "" ||  textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                conn.Close();
            }    else if(cmd.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("không có mã nhân viên này");
                conn.Close();
            }
            else
            {
                sqlCommand = new SqlCommand(query2 , conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đổi mật khẩu thành công");
            }

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
           
        }

      
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
        
    }
}
