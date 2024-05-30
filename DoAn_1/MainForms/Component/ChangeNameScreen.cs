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
    public partial class ChangeNameScreen : Form
    {
        SqlConnection conn;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd3;
        public ChangeNameScreen()
        {
            InitializeComponent();
        }

        private void ChangeNameScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectDatabase.ConnDb);
            conn.Open();
            string query = "update user_table set last_name = '"+HoTxtBox.Text+"' where username = '"+Properties.Settings.Default.username+"'";
            string query2 = "update user_table set first_name = '" + TenTxtBox.Text + "' where username = '" + Properties.Settings.Default.username + "'";
            string query3 = "update user_table set email = '" + emailTxtB.Text + "' where username = '" + Properties.Settings.Default.username + "'";
            if (TenTxtBox.Text == "")
            {
                MessageBox.Show("Không được để trống tên");
                conn.Close();
            }
            else
            {
                cmd1 = new SqlCommand(query, conn);
                cmd1.ExecuteNonQuery();
                cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();
                cmd3 = new SqlCommand(query3, conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đổi thông tin thành công");
            }
        }
    }
}
