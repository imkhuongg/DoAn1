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

namespace DoAn_1.MainForms
{
    public partial class QLNhanVien : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        DataTable tableNV = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        string queryNV = "Select username, first_name , last_name,email ,position from user_table";
        public QLNhanVien()
        {
            InitializeComponent();
        }
        void LoadTable(string query, DataTable table, DataGridView dataGridView)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            command = Conn.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView.DataSource = table;
            Conn.Close();
            Conn.Dispose();

        }
        void ConnectAndQuerry(string query)
        {

            command = Conn.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();

            Conn.Close();
            Conn.Dispose();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            LoadTable(queryNV, tableNV, NVTable);
        }

        private void InitBtn_Click(object sender, EventArgs e)
        {
            MaTxBox.ReadOnly = false;
            MaTxBox.Text = "";
            LNameTxBox.Text = "";
            FNameTxBox.Text = "";
            emailTxt.Text = "";
            Positiontxt.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "insert into user_table(username,password,first_name,last_name,email,position) values('"+MaTxBox.Text+"','123123',N'"+FNameTxBox.Text+"',N'"+LNameTxBox.Text+"','"+emailTxt.Text+"' , N'"+Positiontxt.Text+"')";
            string check =  "select count(*) from user_table where username = '"+MaTxBox.Text+"'";

            SqlCommand cmd = new SqlCommand(check , Conn);

            if(MaTxBox.Text == "" || LNameTxBox.Text ==  "" || FNameTxBox.Text == "" || emailTxt.Text == "" ||  Positiontxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                Conn.Close();
            } else if(cmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Đã có mã nhân viên này");
                Conn.Close() ;
            }
            else
            {
               
                ConnectAndQuerry(query);
                LoadTable(queryNV, tableNV, NVTable);
                MessageBox.Show("Thêm nhân viên thành công với mật khẩu là 123123");
            }

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "DELETE FROM user_table where username = '" + MaTxBox.Text + "'";
            string check = "select count(*) from user_table where username = '" + MaTxBox.Text + "'";

            SqlCommand cmd = new SqlCommand(check, Conn);
            if (MaTxBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
                Conn.Close();
            }
            else if (cmd.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("không có mã nhân viên này");
                Conn.Close();
            }
            else
            {

                
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên "+MaTxBox.Text+"?" , "" , MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    ConnectAndQuerry(query);
                    LoadTable(queryNV, tableNV, NVTable);
                    MessageBox.Show("Xoá thành công");
                }


            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "UPDATE user_table SET first_name = '"+FNameTxBox.Text+"' , last_name = '"+LNameTxBox.Text+"', email = '"+emailTxt.Text+"' , position = '"+Positiontxt.Text+"' where username = '"+MaTxBox.Text+"'";
            string check = "select count(*) from user_table where username = '" + MaTxBox.Text + "'";

            SqlCommand cmd = new SqlCommand(check, Conn);
            if (MaTxBox.Text == "" || LNameTxBox.Text == "" || FNameTxBox.Text == "" || emailTxt.Text == "" || Positiontxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin nhân viên");
                Conn.Close();
            }
            else if (cmd.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("không có mã nhân viên này");
                Conn.Close();
            }
            else
            {

                ConnectAndQuerry(query);
                LoadTable(queryNV, tableNV, NVTable);
                MessageBox.Show("Sửa nhân viên thành công");

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            switch(SearchList.SelectedIndex)
            {
                case 0:
                    if(SearchTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "Select username, first_name , last_name,email ,position from user_table where username = '"+MaTxBox.Text+"'";
                        LoadTable(queryNV, tableNV, NVTable);
                    }
                    break;
                case 1:
                    if (SearchTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "Select username, first_name , last_name,email ,position from user_table where last_name = '" + MaTxBox.Text + "'";
                        LoadTable(queryNV, tableNV, NVTable);
                    }
                    break;
                case 2:
                    if (SearchTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "Select username, first_name , last_name,email ,position from user_table where first_name = '" + MaTxBox.Text + "'";
                        LoadTable(queryNV, tableNV, NVTable);
                    }
                    break;
                case 3:
                    if (SearchTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "Select username, first_name , last_name,email ,position from user_table where email = '" + MaTxBox.Text + "'";
                        LoadTable(queryNV, tableNV, NVTable);
                    }
                    break;
                case 4:
                    if (SearchTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "Select username, first_name , last_name,email ,position from user_table where position = '" + MaTxBox.Text + "'";
                        LoadTable(queryNV, tableNV, NVTable);
                    }
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn trường tìm kiếm");
                    break;  
            }
        }

        private void NVTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            MaTxBox.ReadOnly = true;
            i = NVTable.CurrentRow.Index;
            MaTxBox.Text = NVTable.Rows[i].Cells[0].Value.ToString();
            FNameTxBox.Text = NVTable.Rows[i].Cells[1].Value.ToString();
            LNameTxBox.Text = NVTable.Rows[i].Cells[2].Value.ToString();
            emailTxt.Text = NVTable.Rows[i].Cells[3].Value.ToString();
            Positiontxt.Text = NVTable.Rows[i].Cells[4].Value.ToString();
        }

        private void RePass_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "update user_table set password = '123123'";

            SqlCommand cmd = new SqlCommand(query, Conn);
            if(MaTxBox.Text == "" || LNameTxBox.Text == "" || FNameTxBox.Text == "" || emailTxt.Text == "" || Positiontxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                Conn.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật cho nhân viên này?", "" , MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2 );
                if(result == DialogResult.OK )
                {
                    ConnectAndQuerry(query);
                    LoadTable(queryNV, tableNV, NVTable);
                    MessageBox.Show("Cập nhật thành công, mật khẩu mới là 123123");
                }
            }
        }
    }
}
