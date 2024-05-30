using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DoAn_1.MainForms.ReportScreen;

namespace DoAn_1.MainForms
{

    public partial class QLPKTXScreen : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablePKTX = new DataTable();
        DataTable tableDD = new DataTable();
        DataTable tableTrans = new DataTable();
        DataTable tableNtru = new DataTable();
        string QueryNtru = "SELECT * FROM Student_residence";
        string QuerryTrans = "SELECT * FROM room_transfer";
        string QueryPKTX = "SELECT * FROM dormitory";
        string QueryDDPKTX = "SELECT * FROM dormitory_items";
        public QLPKTXScreen()
        {
            InitializeComponent();

            DateNtru.Format = DateTimePickerFormat.Custom;
            DateNtru.CustomFormat = "yyyy/MM/dd";
           
            SearchDateNtru.Format = DateTimePickerFormat.Custom;
            SearchDateNtru.CustomFormat = "yyyy/MM/dd";

            SearchDateTrans.Format = DateTimePickerFormat.Custom;
            SearchDateTrans.CustomFormat = "yyyy/MM/dd";

            DateTrans.Format = DateTimePickerFormat.Custom;
            DateTrans.CustomFormat = "yyyy/MM/dd";

        }
        void LoadTable(string query , DataTable table , DataGridView dataGridView)
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
        void loadComboBox(string query , string member , System.Windows.Forms.ComboBox CB)
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
        void ConnectAndQuerry(string query)
        {
            
            command = Conn.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            
            Conn.Close();
            Conn.Dispose();
        }
            
        private void QLPKTXScreen_Load(object sender, EventArgs e)
        {
            string CBPTKX = "maphong";
            string queryBuild = "Select sotoa from building";
            string valBuild = "sotoa";

            loadComboBox(queryBuild, valBuild, NumBuid);

            SearchDateNtru.Visible = false;
            SearchDateTrans.Visible = false;
        }
        private void PKTXtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRoom.ReadOnly = true;
            int i;
            i = PKTXtable.CurrentRow.Index;
            IdRoom.Text = PKTXtable.Rows[i].Cells[0].Value.ToString();
            NumRoom.Text = PKTXtable.Rows[i].Cells[1].Value.ToString();
            NumBuid.Text = PKTXtable.Rows[i].Cells[2].Value.ToString();
            NumStudent.Text = PKTXtable.Rows[i].Cells[3].Value.ToString();
            IdRoom.BorderStyle = BorderStyle.None;
        }

        private void KTXInitBtn_Click(object sender, EventArgs e)
        {
            IdRoom.ReadOnly = false;
            IdRoom.Text = "";
            NumRoom.Text = "";
            NumBuid.Text = "";
            NumStudent.Text = "";
        }

        private void PKTXAdd_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "INSERT INTO dormitory(maphong,sophong,sotoa,soluongSVdango) VALUES ('" + IdRoom.Text + "',N'" + NumRoom.Text + "',N'" + NumBuid.Text + "','" + NumStudent.Text + "')";
            string CheckIDQuerry = "SELECT COUNT(*) FROM dormitory WHERE maphong= '" + IdRoom.Text + "'";
            SqlCommand Check = new SqlCommand(CheckIDQuerry, Conn);
            if (IdRoom.Text == "" || NumRoom.Text == "" || NumBuid.Text == "")
            {   
                MessageBox.Show("Có thông tin để trống!!");
                Conn.Close();

            }
            else if (Check.ExecuteScalar().ToString() == "1")
            {
                
                MessageBox.Show("Đã có mã phòng này vui lòng nhập lại");
                Conn.Close();
            }
            else
            {
                ConnectAndQuerry(query);
                LoadTable(QueryPKTX , tablePKTX, PKTXtable);
            }
            
        }

        private void DelPKTXBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "DELETE FROM dormitory where maphong= '" + IdRoom.Text + "'"; 
            if (IdRoom.Text == "")
            {
                MessageBox.Show("Nhập mã phòng để xoá!!");
            }
            else
            {
                ConnectAndQuerry(query);
                LoadTable(QueryPKTX, tablePKTX, PKTXtable);
            }
        }

        private void EditPKTX_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "UPDATE dormitory SET sophong = N'" + NumRoom.Text + "' ,sotoa = '" + NumBuid.Text + "', soluongSVdango = " + NumStudent.Text + " WHERE maphong= '" + IdRoom.Text + "'";
            if(IdRoom.Text == "")
            {
                MessageBox.Show("Trống mã phòng!");
            } else
            {
                ConnectAndQuerry(query);
                LoadTable(QueryPKTX, tablePKTX, PKTXtable);
            }
            
        }


        private void tabDDPKTX1_Paint(object sender, PaintEventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);

            LoadTable(QueryDDPKTX, tableDD, TableDDPKTX);
            Conn.Close();
        }

        private void TableDDPKTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NumRoomDDP.Enabled = false;
            int i;
            i = TableDDPKTX.CurrentRow.Index;

            NumRoomDDP.Text = TableDDPKTX.Rows[i].Cells[0].Value.ToString();
            NumFans.Text = TableDDPKTX.Rows[i].Cells[1].Value.ToString();
            NumBeds.Text = TableDDPKTX.Rows[i].Cells[2].Value.ToString();
            NumN.Text = TableDDPKTX.Rows[i].Cells[3].Value.ToString();
            NumTable.Text = TableDDPKTX.Rows[i].Cells[4].Value.ToString();
            NumPSockets.Text = TableDDPKTX.Rows[i].Cells[5].Value.ToString();
            NumRoomDDP.BackColor = Color.Gainsboro;
        }

        private void tabPKTX_Paint(object sender, PaintEventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            
            LoadTable(QueryPKTX, tablePKTX, PKTXtable);
           
        }

        private void InitDDP_Click(object sender, EventArgs e)
        {
            NumRoomDDP.Enabled = true;
            NumRoomDDP.BackColor = Color.White;
            NumRoomDDP.Text = "";
            NumFans.Text = "";
            NumBeds.Text = "";
            NumN.Text = "";
            NumTable.Text = "";
            NumPSockets.Text = "";
        }

        private void AddDDP_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "INSERT INTO dormitory_items(maphong,soluongquat,soluonggiuong,soluongnem ,soluongban , soluongodien , soluongSVtoida) VALUES ('" + NumRoomDDP.Text + "',N'" + NumFans.Text + "',N'" + NumBeds.Text + "','" + NumN.Text + "' ,'" + NumTable.Text + "' , '" + NumPSockets.Text + "' , '"+ SLSVMaxTxtB.Text+ "')";
            string CheckIDQuerry = "SELECT COUNT(*) FROM dormitory_items WHERE maphong= '" + NumRoomDDP.Text + "'";
            string CheckIDRoomQuerry = "SELECT COUNT(*) FROM dormitory WHERE maphong= '"+NumRoomDDP.Text +"'";
            SqlCommand Check = new SqlCommand(CheckIDQuerry, Conn);
            SqlCommand CheckID = new SqlCommand(CheckIDRoomQuerry, Conn);
            if (NumRoomDDP.Text == "" || NumFans.Text == "" || NumBeds.Text == "" || NumN.Text == "" || NumTable.Text == "" || NumPSockets.Text == "")
            {
                MessageBox.Show("Có thông tin để trống!!");
                Conn.Close();

            }
            else if (Check.ExecuteScalar().ToString() == "1")
            {
                
                MessageBox.Show("Đã có phòng này vui lòng nhập lại");
                Conn.Close();
            }
            else if (CheckID.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("Không tồn tại phòng");
                Conn.Close();
            }
            else
            {
                ConnectAndQuerry(query);
                LoadTable(QueryDDPKTX, tableDD, TableDDPKTX);
                
            }
            
        }

        private void DelDDP_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "DELETE FROM dormitory_items where maphong= '" + NumRoomDDP.Text + "'";
            if (NumRoomDDP.Text == "")
            {
                MessageBox.Show("Nhập số phòng để xoá!!");
            }
            else
            {
                ConnectAndQuerry(query);
                LoadTable(QueryDDPKTX, tableDD, TableDDPKTX);
            }
        }

        private void EditDDP_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query  = "UPDATE dormitory_items SET soluongquat = '" + NumFans.Text + "', soluonggiuong = '" + NumBeds.Text + "' , soluongnem = '" + NumN.Text + "' , soluongban = '" + NumTable.Text + "' , soluongodien = '" + NumPSockets.Text + "'  WHERE maphong= '" + NumRoomDDP.Text + "'";
            ConnectAndQuerry(query);
            LoadTable(QueryDDPKTX, tableDD, TableDDPKTX);
            
        }

        private void tabTransRoom_Paint(object sender, PaintEventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            LoadTable(QuerryTrans, tableTrans, TableTranfer);
            
        }

        private void InitTrans_Click(object sender, EventArgs e)
        {
            MaSVTrans.ReadOnly = false;
            IdRoomTrans.Enabled = false;
            MaSVTrans.Text = "";
            IdRoomTrans.Text = "";
            DateTrans.Text = "1/1/2000";

        }

        private void AddTrans_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            //QUERY
            string query = "INSERT INTO room_transfer(masv,maphong,maphongchuyentoi,ngaychuyen) VALUES ('" + MaSVTrans.Text + "',N'" + IdRoomTrans.Text + "','"+IdRoomTransTo.Text+"','"+DateTrans.Text+"')";
            string CheckIDQuerry = "SELECT COUNT(*) FROM dormitory WHERE maphong= '" + IdRoomTrans.Text + "'";
            string CheckIDRoomQuerry = "SELECT COUNT(*) FROM student WHERE masv = '" + MaSVTrans.Text + "'";
            string getGioiTInh = "Select gioitinh From student where masv = '" + MaSVTrans.Text + "'";
            string GioiTinhPhong = "select gioitinh from student , Student_residence where student.masv = Student_residence.masv and maphong= '" + IdRoomTransTo.Text + "'";
            string updateNumSV = "Update dormitory SET soluongSVdango = soluongSVdango + 1 where maphong= '" + IdRoomTransTo.Text + "'";
            string updateNumSVTo = "Update dormitory SET soluongSVdango = soluongSVdango - 1 where maphong= '" + IdRoomTrans.Text + "'";
            string getDataNumRoom = "Select soluongSVdango from dormitory where maphong= '" + IdRoomTransTo.Text + "'";
            string GetMaxNumRoom = "Select soluongSVtoida from dormitory_items where maphong= '" + IdRoomTransTo.Text + "'";
            string UpdateNtru = "update student_residence set maphong= '"+IdRoomTransTo.Text+"' where masv = '"+MaSVTrans.Text+"'";

            //COMMAND
            SqlCommand Check = new SqlCommand(CheckIDQuerry, Conn);
            SqlCommand CheckID = new SqlCommand(CheckIDRoomQuerry, Conn);
            SqlCommand checkGioiTinh = new SqlCommand(getGioiTInh, Conn);
            SqlCommand checkGioiTinhPhong = new SqlCommand(GioiTinhPhong, Conn);
            SqlCommand GetRoom = new SqlCommand(getDataNumRoom, Conn);
            SqlCommand getMaxSv = new SqlCommand(GetMaxNumRoom, Conn);


            if (MaSVTrans.Text == "" || IdRoomTrans.Text == "")
            {
                MessageBox.Show("Có thông tin để trống!!");
                Conn.Close();
                Conn.Dispose();
            } 
            else if(Check.ExecuteScalar().ToString() == "0" || CheckID.ExecuteScalar().ToString() == "0"){
                MessageBox.Show("Không có phòng này hoặc không tồn tại sinh viên");
                Conn.Close();
                Conn.Dispose();
            }
            else if (checkGioiTinhPhong.ExecuteScalar() != null && checkGioiTinh.ExecuteScalar().ToString() != checkGioiTinhPhong.ExecuteScalar().ToString())
            {

                MessageBox.Show("Giới tính của sinh viên không trùng khớp với phòng");
                Conn.Close();
                Conn.Dispose();

            }
            else if (GetRoom.ExecuteScalar().ToString() == getMaxSv.ExecuteScalar().ToString())
            {
                MessageBox.Show("Phòng này đã đầy vui lòng nhập phòng khác");
                Conn.Close();
                Conn.Dispose();
            }
            else
            {
                ConnectAndQuerry(query);
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                ConnectAndQuerry(updateNumSV);
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                ConnectAndQuerry(UpdateNtru);
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                ConnectAndQuerry(updateNumSVTo);
                LoadTable(QuerryTrans, tableTrans, TableTranfer);
            }
        }

        private void TableTranfer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaSVTrans.ReadOnly = true;
            IdRoomTrans.Enabled = true;
            int i;
            i = TableTranfer.CurrentRow.Index;
            MaSVTrans.Text = TableTranfer.Rows[i].Cells[0].Value.ToString();
            IdRoomTrans.Text = TableTranfer.Rows[i].Cells[1].Value.ToString(); ;
            DateTrans.Text = TableTranfer.Rows[i].Cells[2].Value.ToString(); ;
        }

        private void DelTrans_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "DELETE FROM room_transfer where maphong= '" + IdRoomTrans.Text + "'";
            if (IdRoomTrans.Text == "")
            {
                MessageBox.Show("Nhập mã phòng để xoá!!");
            }
            else
            {
                
                ConnectAndQuerry(query);
                LoadTable(QuerryTrans, tableTrans, TableTranfer);
            }
        }

        private void EditTrans_Click(object sender, EventArgs e)

        { 
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "UPDATE room_transfer SET ngaychuyen = '"+DateTrans.Text+"' WHERE masv = '"+MaSVTrans.Text+"' AND maphong= '"+IdRoomTrans.Text+"'" ;
            if (IdRoomTrans.Text == "" || MaSVTrans.Text == "")
            {
                MessageBox.Show("Trống mã phòng hoặc mã sinh viên!");
            }
            else
            {
                ConnectAndQuerry(query);
                LoadTable(QuerryTrans, tableTrans, TableTranfer);
            }
        }

        private void tabNtru_Paint(object sender, PaintEventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            LoadTable(QueryNtru, tableNtru, NtruTable);
        }

        private void InitNtru_Click(object sender, EventArgs e)
        {
            MaSVNtru.ReadOnly = false;
            IdRoomNtru.Enabled = false;
            MaSVNtru.Text= "";
            IdRoomNtru.Text = "";
            DateNtru.Text = "";
        }

        private void NtruTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaSVNtru.ReadOnly = true;
            IdRoomNtru.Enabled = true;
            int i;
            i = NtruTable.CurrentRow.Index;
            MaSVNtru.Text = NtruTable.Rows[i].Cells[0].Value.ToString();
            IdRoomNtru.Text = NtruTable.Rows[i].Cells[1].Value.ToString();
            DateNtru.Text = NtruTable.Rows[i].Cells[2].Value.ToString();
        }

        private void AddNtru_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();


            //QUERY
            string query = "INSERT INTO Student_residence(masv,maphong,ngayvao) VALUES ('" + MaSVNtru.Text + "',N'" + IdRoomNtru.Text + "','" + DateNtru.Text + "')";
            string CheckIDQuerry = "SELECT COUNT(*) FROM dormitory WHERE maphong= '" + IdRoomNtru.Text + "'";
            string CheckIDRoomQuerry = "SELECT COUNT(*) FROM student WHERE masv = '" + MaSVNtru.Text + "'";
            string CheckIDSVQuerry = "SELECT COUNT(*) FROM Student_residence WHERE masv = '" + MaSVNtru.Text + "'";
            string getGioiTInh = "Select gioitinh From student where masv = '" + MaSVNtru.Text + "'";
            string GioiTinhPhong = "select gioitinh from student , Student_residence where student.masv = Student_residence.masv and maphong= '" + IdRoomNtru.Text + "'";
            string updateNumSV = "Update dormitory SET soluongSVdango = soluongSVdango + 1 where maphong= '"+ IdRoomNtru .Text+ "'";
            string getDataNumRoom = "Select soluongSVdango from dormitory where maphong= '"+IdRoomNtru.Text+"'";
            string GetMaxNumRoom = "Select soluongSVtoida from dormitory_items where maphong= '" + IdRoomNtru.Text + "'";


            //COMMAND
            SqlCommand Check = new SqlCommand(CheckIDQuerry, Conn);
            SqlCommand CheckID = new SqlCommand(CheckIDRoomQuerry, Conn);
            SqlCommand checkGioiTinh = new SqlCommand(getGioiTInh , Conn);
            SqlCommand checkIDSVPhong = new SqlCommand(CheckIDSVQuerry, Conn);
            SqlCommand checkGioiTinhPhong = new SqlCommand(GioiTinhPhong, Conn);
            SqlCommand GetRoom = new SqlCommand(getDataNumRoom, Conn);
            SqlCommand getMaxSv = new SqlCommand(GetMaxNumRoom,Conn);

            if (MaSVNtru.Text == "" || IdRoomNtru.Text == "")
            {
                MessageBox.Show("Có thành phần để trống");
                Conn.Close();
                Conn.Dispose();
            } else if (Check.ExecuteScalar().ToString() == "0" || CheckID.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("Không tồn tại phòng hoặc không tồn tại sinh viên");
                Conn.Close();
                Conn.Dispose();
            }
            else if (checkGioiTinhPhong.ExecuteScalar() != null && checkGioiTinh.ExecuteScalar().ToString() != checkGioiTinhPhong.ExecuteScalar().ToString())
            {
           
                    MessageBox.Show("Giới tính của sinh viên mới đến không trùng giới tính của các sinh viên trong phòng");
                    Conn.Close();
                    Conn.Dispose();
                
            }
            else if (GetRoom.ExecuteScalar().ToString() == getMaxSv.ExecuteScalar().ToString())
            {
                MessageBox.Show("Phòng này đã đầy vui lòng nhập phòng khác");
                Conn.Close();
                Conn.Dispose();
            }
            else if (checkIDSVPhong.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Đã có sinh viên này!!");
                Conn.Close();
                Conn.Dispose();
            }
            else
            {
                ConnectAndQuerry(query);
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                ConnectAndQuerry(updateNumSV);
                LoadTable(QueryNtru, tableNtru, NtruTable);
                
            }
        }

        private void DelNtru_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string updateNumSV = "Update dormitory SET soluongSVdango = soluongSVdango - 1 where maphong= '" + IdRoomNtru.Text + "'";
            string query = "DELETE FROM Student_residence WHERE masv = '"+MaSVNtru.Text+"' AND maphong= '"+IdRoomNtru.Text+"'";

            if(MaSVNtru.Text== ""|| IdRoomNtru.Text == "")
            {
                MessageBox.Show("Có thông tin để trống");
            }
            else
            {
                ConnectAndQuerry(query);
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                ConnectAndQuerry(updateNumSV);
                LoadTable(QueryNtru, tableNtru, NtruTable);
            }
        }

        private void EditNtru_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "UPDATE Student_residence SET ngayvao = '" + DateNtru.Text + "' WHERE masv = '" + MaSVNtru.Text + "' AND maphong= '" + IdRoomNtru.Text + "'";
            if(MaSVNtru.Text == "" || IdRoomNtru.Text == "")
            {
                MessageBox.Show("Có thông tin để trống");
            }
            else
            {
                ConnectAndQuerry(query);

                LoadTable(QueryNtru, tableNtru, NtruTable);
            }
        }

        private void SearchPKTX_btn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (PKTXCBSearch.SelectedIndex == 0)
            {
                Conn.Open();
                if (SearchPKTXTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã phòng để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM dormitory WHERE maphong= '" + SearchPKTXTxt.Text + "' ";
                    LoadTable(query, tablePKTX, PKTXtable);

                }
                Conn.Close();
            }
            else if (PKTXCBSearch.SelectedIndex == 1)
            {
                Conn.Open();
                if (SearchPKTXTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập số phòng để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM dormitory WHERE Họ = '" + SearchPKTXTxt.Text + "' ";
                    LoadTable(query, tablePKTX, PKTXtable);

                }
                Conn.Close();
            }
            else if (PKTXCBSearch.SelectedIndex == 2)
            {
                Conn.Open();
                if (SearchPKTXTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập số toà để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM dormitory WHERE sotoa = '" + SearchPKTXTxt.Text + "' ";
                    LoadTable(query, tablePKTX, PKTXtable);

                }
                Conn.Close();
            }
            else if (PKTXCBSearch.SelectedIndex == 3)
            {
                Conn.Open();
                if (SearchPKTXTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập số lượng sinh viên đang ở để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM dormitory WHERE soluongSVdango = '" + SearchPKTXTxt.Text + "' ";
                    LoadTable(query, tablePKTX, PKTXtable);

                }
                Conn.Close();
            }
            
            else
            {
                MessageBox.Show("Vui Lòng chọn trường tìm kiếm ");
            }
        }

        private void IdRoomTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void MaSVTrans_TextChanged(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            
            string query = "SELECT maphongFROM Student_residence where masv = '" + MaSVTrans.Text + "'";
            SqlCommand GetRoom = new SqlCommand(query, Conn);
            if (GetRoom.ExecuteScalar() != null)
            {
                IdRoomTrans.Text = GetRoom.ExecuteScalar().ToString();
                
                
            }
            else
            {
                IdRoomTrans.Text = "";
            }
            
        }

        private void SearchDDP_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            switch (ItemsRoomCB.SelectedIndex)
            {
                case 0:
                    Conn.Open();
                    if (SearchDDPKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập Mã phòng để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM dormitory_items WHERE maphong= '" + SearchDDPKTXTxt.Text + "' ";
                        LoadTable(query, tableDD, TableDDPKTX);

                    }
                    Conn.Close();
                    break;
                case 1:
                    Conn.Open();
                    if (SearchDDPKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập số lượng quạt để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM dormitory_items WHERE soluongquat = '" + SearchDDPKTXTxt.Text + "' ";
                        LoadTable(query, tableDD, TableDDPKTX);

                    }
                    Conn.Close();
                    break;
                case 2:
                    Conn.Open();
                    if (SearchDDPKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập số toà để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM dormitory_items WHERE soluonggiuong = '" + SearchDDPKTXTxt.Text + "' ";
                        LoadTable(query, tableDD, TableDDPKTX);

                    }
                    Conn.Close();
                    break;
                case 3:
                    Conn.Open();
                    if (SearchDDPKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập số lượng nệm để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM dormitory_items WHERE soluongnem = '" + SearchDDPKTXTxt.Text + "' ";
                        LoadTable(query, tableDD, TableDDPKTX);

                    }
                    Conn.Close();
                    break;
                case 4:
                    Conn.Open();
                    if (SearchDDPKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập số lượng bàn để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM dormitory_items WHERE soluongban = '" + SearchDDPKTXTxt.Text + "' ";
                        LoadTable(query, tableDD, TableDDPKTX);

                    }
                    Conn.Close();
                    break;
                case 5:
                    Conn.Open();
                    if (SearchDDPKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập số lượng ổ điện để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM dormitory_items WHERE soluongSVdango = '" + SearchDDPKTXTxt.Text + "' ";
                        LoadTable(query, tableDD, TableDDPKTX);

                    }
                    Conn.Close();
                    break;
                case 6:
                    Conn.Open();
                    if (SearchDDPKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập số lượng sinh viên tối đa để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        string query = "SELECT * FROM dormitory_items WHERE soluongSVtoida = '" + SearchDDPKTXTxt.Text + "' ";
                        LoadTable(query, tableDD, TableDDPKTX);

                    }
                    Conn.Close();
                    break;
                default :
                    MessageBox.Show("Vui lòng chọn trường tìm kiếm");
                    Conn.Close();
                    break;
            }
        }

        private void SearchTrans_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (TransCb.SelectedIndex == 0)
            {
                Conn.Open();
                if (IdRoom.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã sinh viên để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM room_transfer WHERE masv = '" + MaSVTrans.Text + "' ";
                    LoadTable(query, tableTrans, TableTranfer);

                }
                Conn.Close();
            }
            else if (TransCb.SelectedIndex == 1)
            {
                Conn.Open();
                if (IdRoomTrans.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã phòng để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM room_transfer WHERE maphong= '" + IdRoomTrans.Text + "' ";
                    LoadTable(query, tableTrans, TableTranfer);

                }
                Conn.Close();
            }
            else if (TransCb.SelectedIndex == 2)
            {
                Conn.Open();
                if (SearchDateTrans.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập ngày chuyển để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM room_transfer WHERE ngaychuyen = '" + SearchDateTrans.Text + "' ";
                    LoadTable(query, tableTrans, TableTranfer);

                }
                Conn.Close();
            }
            else if (TransCb.SelectedIndex == 3)
            {
                Conn.Open();
                if (IdRoomTransTo.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã phòng chuyển đến để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM room_transfer WHERE maphongchuyentoi = '" + IdRoomTransTo.Text + "' ";
                    LoadTable(query, tableTrans, TableTranfer);

                }
                Conn.Close();
            }

            else
            {
                MessageBox.Show("Vui Lòng chọn trường tìm kiếm ");
            }
        }

        private void SearchNtru_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (NtruCb.SelectedIndex == 0)
            {
                Conn.Open();
                if (SearchNtruTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã sinh viên để tìm kiếm ");
                    Conn.Close();
                }
                else
                {
                    string query = "SELECT * FROM Student_residence WHERE masv = '" + SearchNtruTxt.Text + "' ";
                    LoadTable(query, tableNtru, NtruTable);

                }
                Conn.Close();
            }
            else if (NtruCb.SelectedIndex == 1)
            {
                Conn.Open();
                if (SearchDateNtru.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Ngày vào để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM Student_residence WHERE ngayvao = '" + SearchDateNtru.Text + "' ";
                    LoadTable(query, tableNtru, NtruTable);

                }
                Conn.Close();
            }
            else if (NtruCb.SelectedIndex == 2)
            {
                Conn.Open();
                if (SearchNtruTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập mã phòng để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM Student_residence WHERE maphong= '" + SearchNtruTxt.Text + "' ";
                    LoadTable(query, tableNtru, NtruTable);

                }
                Conn.Close();
            }

            else
            {
                MessageBox.Show("Vui Lòng chọn trường tìm kiếm ");
            }
        }

        private void NtruCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NtruCb.SelectedIndex == 1)
            {
                SearchDateNtru.Visible = true;
            }
            else
            {
                SearchDateNtru.Visible = false;
            }
        }

        private void TransCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransCb.SelectedIndex == 2)
            {
                SearchDateTrans.Visible = true;
            }
            else
            {
                SearchDateTrans.Visible = false;
            }
        }

        private void OutPKTX_Click(object sender, EventArgs e)
        {
            DSPKTXSreen dSPKTXSreen = new DSPKTXSreen();
            dSPKTXSreen.ShowDialog();
        }

        private void OutDDPKTX_Click(object sender, EventArgs e)
        {
            DSDDPKTXSreen dSDDPKTXSreen = new DSDDPKTXSreen();
            dSDDPKTXSreen.ShowDialog();
        }

        private void OutNtru_Click(object sender, EventArgs e)
        {
            DSNTruScrees dSNTruScrees = new DSNTruScrees();
            dSNTruScrees.ShowDialog();  
        }

        private void outChuyenPhong_Click(object sender, EventArgs e)
        {
            DSChuyenPhongScreen dSChuyenPhongScreen = new DSChuyenPhongScreen();
            dSChuyenPhongScreen.ShowDialog();
        }
    }
}