﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using DoAn_1.MainForms.ReportScreen;


namespace DoAn_1.MainForms
{
    
    public partial class QLSVForm : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void LoadTable()
        {
            command = Conn.CreateCommand();
            command.CommandText = "SELECT * FROM student";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
        
            SVTable.DataSource = table;

        }
        void LoadTableS(string query)
        {
            command = Conn.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            SVTable.DataSource = table;

        }

        public QLSVForm()
        {

            InitializeComponent();

            SearchQLSVDate.Format = DateTimePickerFormat.Custom;
            SearchQLSVDate.CustomFormat = "yyyy/MM/dd";

            NgaySinhTxbox.Format = DateTimePickerFormat.Custom;
            NgaySinhTxbox.CustomFormat = "yyyy/MM/dd";
        }
        void loadComboBox(string query, string member, System.Windows.Forms.ComboBox CB)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);


            SqlCommand cmd = new SqlCommand(query, Conn);
            Conn.Open();
            var dr = cmd.ExecuteReader();
            SqlDataAdapter d = new SqlDataAdapter(query, Conn);
            var dt = new DataTable();
            dt.Load(dr);


            CB.DataSource = dt;
            CB.DisplayMember = member;
            CB.ValueMember = member;
            Conn.Close();
        }

        private void QLSVForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT makhoa from faculty";
            string id = "makhoa";

            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            LoadTable();
            loadComboBox(query, id, KhoaCB);
            Conn.Close();

            SearchQLSVDate.Visible = false;
        }


        private void SVTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaSVTxBox.ReadOnly = true;
            int i;
            i = SVTable.CurrentRow.Index;
            MaSVTxBox.Text = SVTable.Rows[i].Cells[0].Value.ToString();
            LNameTxBox.Text = SVTable.Rows[i].Cells[2].Value.ToString();
            FNameTxBox.Text = SVTable.Rows[i].Cells[1].Value.ToString();
            GioiTinhCB.Text = SVTable.Rows[i].Cells[4].Value.ToString();
          
            SvClassTxBox.Text = SVTable.Rows[i].Cells[5].Value.ToString();
            NgaySinhTxbox.Text = SVTable.Rows[i].Cells[3].Value.ToString();
            
            GioiTinhCB.Text =SVTable.Rows[i].Cells[4].Value.ToString();
            
        }

        private void AddSvBtn_Click(object sender, EventArgs e)
        {
            
            Conn.Open();
            string CheckIDQuerry = "SELECT COUNT(*) FROM student WHERE masv = '" + MaSVTxBox.Text + "'";
            SqlCommand Check = new SqlCommand(CheckIDQuerry, Conn);
            if (MaSVTxBox.Text == "" || FNameTxBox.Text == "" || LNameTxBox.Text == "" || SvClassTxBox.Text == "")
            {
                MessageBox.Show("Có thông tin để trống!!");
                Conn.Close();

            }
            else if (Check.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Đã có mã sinh viên này vui lòng nhập lại");
                Conn.Close();
            }
            else
            {
                command = Conn.CreateCommand();
                command.CommandText = "INSERT INTO student(masv,ten,ho,ngaysinh,malop ,gioitinh) VALUES ('"+MaSVTxBox.Text+"',N'"+FNameTxBox.Text+"',N'"+LNameTxBox.Text +"','"+NgaySinhTxbox.Text +"','"+SvClassTxBox.Text+"', '"+GioiTinhCB.Text+"')";
                command.ExecuteNonQuery();
                LoadTable();
                Conn.Close();
            }
            Conn.Close();
        }
        
        private void SearchSvBtn_Click(object sender, EventArgs e)
        {
            
            if(SearchList.SelectedIndex == 0)
            {
                Conn.Open();
                if (SearchTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã sinh viên để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM student WHERE masv = '" + SearchTxt.Text + "' ";
                    LoadTableS(query);
                    
                }
                Conn.Close();
            }
            else if(SearchList.SelectedIndex == 1)
            {
                Conn.Open();
                if (SearchTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập ho sinh viên để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM student WHERE ho = '" + SearchTxt.Text + "' ";
                    LoadTableS(query);

                }
                Conn.Close();
            }
            else if (SearchList.SelectedIndex == 2)
            {
                Conn.Open();
                if (SearchTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập ten sinh viên để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM student WHERE ten = '" + SearchTxt.Text + "' ";
                    LoadTableS(query);

                }
                Conn.Close();
            }
           
            
            else if (SearchList.SelectedIndex == 5)
            {
                Conn.Open();
                if (SearchTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập malop để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM student WHERE malop = '" + SearchTxt.Text + "' ";
                    LoadTableS(query);

                }
                Conn.Close();
            }
            else if (SearchList.SelectedIndex == 6)
            {
                Conn.Open();
                if (SearchQLSVDate.Text == "")
                {
                    MessageBox.Show("Vui Lòng chon Ngày sinh để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM student WHERE ngaysinh = '" + SearchQLSVDate.Text + "' ";
                    LoadTableS(query);

                }
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Vui Lòng chon trường tìm kiếm ");
            }
        }

        private void EditSvBtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            command = Conn.CreateCommand();
            command.CommandText = "UPDATE student SET ten = N'" + FNameTxBox.Text + "', ho = N'" + LNameTxBox.Text + "', ngaysinh = '" + NgaySinhTxbox.Text + "', malop = '" + SvClassTxBox.Text + "', gioitinh = '"+GioiTinhCB.Text+"' WHERE masv = '" + MaSVTxBox.Text + "'";
            command.ExecuteNonQuery();
            LoadTable();
            Conn.Close();
        }

        private void DelSvBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "Select count(*) from Student_residence where masv = '"+MaSVTxBox.Text+"'";
            string query1 = "Select count(*) from room_transfer where masv = '" + MaSVTxBox.Text + "'";
            string query2 = "update dormitory set soluongSVdango = soluongSVdango-1 from dormitory\r\njoin Student_residence on dormitory.maphong = Student_residence.maphong\r\nwhere Student_residence.masv = '"+MaSVTxBox.Text+"'";
            SqlCommand cmdcheck = new SqlCommand(query , Conn);
            SqlCommand cmdcheck2 = new SqlCommand(query1, Conn);


            if (MaSVTxBox.Text == "") 
            {
                MessageBox.Show("Nhập mã sinh viên để xoá!!");
            }
            else if (cmdcheck.ExecuteScalar().ToString() == "1")
            {
                DialogResult result = MessageBox.Show("Sinh viên này đang ở ký túc xá bạn có chắn chắn muốn xoá", "", MessageBoxButtons.OKCancel);
                
                if (result == DialogResult.OK)
                {
                    string querydel = "delete from student_residence where masv = '"+MaSVTxBox.Text+"'";

                    SqlCommand cm1 = new SqlCommand(querydel, Conn);
                    SqlCommand cm2 = new SqlCommand(query2 ,Conn);
                    cm1.ExecuteNonQuery();
                    cm2.ExecuteNonQuery();
                    if(cmdcheck2.ExecuteScalar().ToString() == "1")
                    {
                        
                        string querydel2 = "delete from room_transfer where masv = '" + MaSVTxBox.Text + "'";
                        SqlCommand cm3 = new SqlCommand(querydel2, Conn);
                        cm3.ExecuteNonQuery();
                    }
                    command = Conn.CreateCommand();
                    command.CommandText = "DELETE FROM student where masv = '" + MaSVTxBox.Text + "'";
                    command.ExecuteNonQuery();
                    LoadTable();
                    Conn.Close();
                    MessageBox.Show("Xoá thành công");

                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá sinh viên này?", "" , MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    command = Conn.CreateCommand();
                    command.CommandText = "DELETE FROM student where masv = '" + MaSVTxBox.Text + "'";
                    command.ExecuteNonQuery();
                    LoadTable();
                    Conn.Close();
                    MessageBox.Show("Xoá thành công");
                }
                
            }
           
        }

        private void InitBtn_Click(object sender, EventArgs e)
        {
            MaSVTxBox.ReadOnly = false;
            SvClassTxBox.Text = "";
            MaSVTxBox.Text = "";
            NgaySinhTxbox.Text = "1/1/2000";
           
            FNameTxBox.Text = "";
            LNameTxBox.Text = "";
            GioiTinhCB.Text = "";
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            
            if (SearchTxt.Text == "")
            {
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                Conn.Open();

                LoadTable();
                Conn.Close();
            }
        }

        private void SearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchList.SelectedIndex == 6)
            {
                SearchQLSVDate.Visible = true;
            }
            else
            {
                SearchQLSVDate.Visible = false;
            }
        }

        private void KhoaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select malop from class where makhoa = '"+KhoaCB.Text+"'";
            string id = "malop";
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            loadComboBox(query, id, SvClassTxBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DDSVScreen dDSVScreen = new DDSVScreen();
            dDSVScreen.ShowDialog();
        }
    }
}
