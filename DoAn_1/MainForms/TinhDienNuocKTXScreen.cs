using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_1.MainForms.ReportScreen;


namespace DoAn_1.MainForms
{
    public partial class TinhDienNuocKTXScreen : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        DataTable tableDonGia = new DataTable();
        DataTable tableCongTo = new DataTable();
        DataTable tableNuoc = new DataTable();
        DataTable tablePay = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        String QueryTBDonGia = "SELECT * FROM bill";
        String QueryTBCongTo = "SELECT * FROM ElecDevice";
        String QueryTBPay = "SELECT * FROM payment";
        String QueryTBNuoc = "SELECT * FROM waterPay";
        
        public TinhDienNuocKTXScreen()
        {
            InitializeComponent();

            DateElec.Format = DateTimePickerFormat.Custom;
            DateElec.CustomFormat = "yyyy/MM/dd";

            DateWater.Format = DateTimePickerFormat.Custom;
            DateWater.CustomFormat = "yyyy/MM/dd";
           
            DatePayTxt.Format = DateTimePickerFormat.Custom;
            DatePayTxt.CustomFormat = "yyyy/MM/dd";
        
            SearchPayDate.Format = DateTimePickerFormat.Custom;
            SearchPayDate.CustomFormat = "yyyy/MM/dd";
            //          LoadForm(new DonGiaTxtBtn());
           
            SearchWaterDate.Format = DateTimePickerFormat.Custom;
            SearchWaterDate.CustomFormat = "yyyy/MM/dd";
            
            SearchDateElec.Format = DateTimePickerFormat.Custom;
            SearchDateElec.CustomFormat = "yyyy/MM/dd";

           

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

        void ConnectAndQuerry(string query)
        {

            command = Conn.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();

            Conn.Close();
            Conn.Dispose();
        }
        

        private void DienNuocTab_Paint(object sender, PaintEventArgs e)
        {
            string QueryPKTX = "SELECT sotoa FROM building";
            string val = "sotoa";
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            LoadTable(QueryTBDonGia, tableDonGia, DonGiaTable);
            LoadTable(QueryTBCongTo, tableCongTo, ElecTable);
            LoadTable(QueryTBNuoc , tableNuoc , WaterTable);
            LoadTable(QueryTBPay , tablePay , PaymentTable);
            loadComboBox(QueryPKTX, val, NumBuildWtTxt);
            Conn.Close();
        }

        private void TinhDienNuocKTXScreen_Load(object sender, EventArgs e)
        {
            SearchDateElec.Visible = false;
            SearchWaterDate.Visible = false;
            SearchPayDate.Visible = false;
            IdRoomPayTxt.ReadOnly = true;
            IdPayTxtB.ReadOnly = true;
            PayTxt.ReadOnly = true;
        }

        private void InitBtn_Click(object sender, EventArgs e)
        {
            
            BillWaterTxt.Text = "";
            BillRoomTxt.Text = "";
            IdRoomBuild.Text = "";
            BillElecTxt.Text = "";
        }

        private void AddBillBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "insert into bill(dongiadien , dongianuoc, dongiaphong, maphong) values ('" + BillElecTxt.Text + "','" + BillWaterTxt.Text + "','" + BillRoomTxt.Text + "','" + IdRoomBuild.Text + "')";
            string checkIdRoom = "Select count(*) from dormitory where maphong = '" + IdRoomBuild.Text + "'";

            string checkIdRoom2 = "Select count(*) from bill where maphong = '" + IdRoomBuild.Text + "'";


            SqlCommand cmd = new SqlCommand(checkIdRoom, Conn);
         
            SqlCommand check2 = new SqlCommand(checkIdRoom2, Conn);

            if (BillWaterTxt.Text == "" || BillRoomTxt.Text == "" || IdRoomBuild.Text == "" || BillElecTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                Conn.Close();
            }
            else if (cmd.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("Mã phòng không tồn tại!");
                Conn.Close();
            }
            
            else if (check2.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Đã có mà phòng trong phiếu này vui lòng nhập lại");
                Conn.Close();
            }
            else
            {
                ConnectAndQuerry(query);
                LoadTable(QueryTBDonGia, tableDonGia, DonGiaTable);
                MessageBox.Show("Thêm thành công");
            }

        }

        private void EditBillBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "Update bill SET dongiadien = '" + BillElecTxt.Text + "' ,dongianuoc = '" + BillWaterTxt.Text + "' , dongiaphong = '" + BillRoomTxt.Text + "' where maphong = '" + IdRoomBuild.Text + "' ";

            if ( BillWaterTxt.Text == "" || BillRoomTxt.Text == "" || IdRoomBuild.Text == "" || BillElecTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin để sửa");
                Conn.Close();
            }
            else
            {

                ConnectAndQuerry(query);
                MessageBox.Show("Sửa thành công");
                LoadTable(QueryTBDonGia, tableDonGia, DonGiaTable);

            }
        }

        private void DonGiaTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int i;
            i = DonGiaTable.CurrentRow.Index;

            
            BillElecTxt.Text = DonGiaTable.Rows[i].Cells[0].Value.ToString();
            BillWaterTxt.Text = DonGiaTable.Rows[i].Cells[1].Value.ToString();
            BillRoomTxt.Text = DonGiaTable.Rows[i].Cells[2].Value.ToString();
            IdRoomBuild.Text = DonGiaTable.Rows[i].Cells[3].Value.ToString();
        }

        private void DelBillBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "DELETE FROM bill where maphong = '" + IdRoomBuild.Text + "'";
            if ( IdRoomBuild.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số phiếu và mã phiếu để xoá");
                Conn.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc xoá đơn giá này!" , "" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    ConnectAndQuerry(query);
                    MessageBox.Show("Xoá thành công");
                    LoadTable(QueryTBDonGia, tableDonGia, DonGiaTable);
                }
                
            }
        }

        private void SearchBillBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (SearchCbox.SelectedIndex == 0)
            {
                Conn.Open();
                if (SearchBillTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập số phiếu để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM bill WHERE [Số phiếu] = '" + SearchBillTxt.Text + "' ";
                    LoadTable(query, tableDonGia, DonGiaTable);

                }
                Conn.Close();
            }
            else if (SearchCbox.SelectedIndex == 1)
            {
                Conn.Open();
                if (SearchBillTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM bill WHERE dongiadien = '" + SearchBillTxt.Text + "' ";
                    LoadTable(query, tableDonGia, DonGiaTable);

                }
                Conn.Close();
            }
            else if (SearchCbox.SelectedIndex == 2)
            {
                Conn.Open();
                if (SearchBillTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM bill WHERE dongianuoc = '" + SearchBillTxt.Text + "' ";
                    LoadTable(query, tableDonGia, DonGiaTable);

                }
                Conn.Close();
            }
            else if (SearchCbox.SelectedIndex == 3)
            {
                Conn.Open();
                if (SearchBillTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM bill WHERE dongiaphong = '" + SearchBillTxt.Text + "' ";
                    LoadTable(query, tableDonGia, DonGiaTable);

                }
                Conn.Close();
            }
            else if (SearchCbox.SelectedIndex == 4)
            {
                Conn.Open();
                if (SearchBillTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM bill WHERE maphong = '" + SearchBillTxt.Text + "' ";
                    LoadTable(query, tableDonGia, DonGiaTable);

                }
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn trường tìm kiếm");
                Conn.Close();
            }

        }

        private void InitElecBtn_Click(object sender, EventArgs e)
        {
            IdRoomElelcTxt.ReadOnly = false;
            IdRoomElelcTxt.Text = "";
            IdElecTxt.Text = "";
            ElecTypeTxt.Text = "";
            indexElecTxt.Text = "";
            DateElec.Text = "";

        }

        private void ElecTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdRoomElelcTxt.ReadOnly = true;
            int i;
            i = ElecTable.CurrentRow.Index;

            IdRoomElelcTxt.Text = ElecTable.Rows[i].Cells[0].Value.ToString();
            IdElecTxt.Text = ElecTable.Rows[i].Cells[1].Value.ToString();
            ElecTypeTxt.Text = ElecTable.Rows[i].Cells[2].Value.ToString();
            indexElecTxt.Text = ElecTable.Rows[i].Cells[3].Value.ToString();
            DateElec.Text = ElecTable.Rows[i].Cells[4].Value.ToString();
        }

        private void AddElecBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "insert into ElecDevice(maphong,macongto,loaicongto,chisodien,ngaychotsodien) values ('" + IdRoomElelcTxt.Text + "','" + IdElecTxt.Text + "','" + ElecTypeTxt.Text + "','" + indexElecTxt.Text + "','" + DateElec.Text + "')";
            string checkdate = "Select count(*) from ElecDevice where ngaychotsodien = '" + DateElec.Text + "' and  maphong = '" + IdRoomElelcTxt.Text + "'";
            string checkIdRoom = "Select count(*) from dormitory where maphong = '" + IdRoomElelcTxt.Text + "'";
            string checkIDde = "Select count(*) from ElecDevice where macongto = '"+IdElecTxt.Text+"'";
            string autoInsert = "with RoomCountPerBuilding AS (\r\n    SELECT sotoa, COUNT(maphong) AS RoomCount\r\n    FROM dormitory\r\n\twhere soluongSVdango > 0\r\n    GROUP BY sotoa\r\n\t\r\n)\r\ninsert into payment(maphong,tongtiendien,tongtiennuoc,tienphong,tongtien,ngaychotsodien,ngaychotsonuoc)\r\nselect dormitory.maphong, bill.dongiadien * ElecDevice.chisodien as tongtiendien , bill.dongianuoc * (waterPay.tongsokhoi / RoomCountPerBuilding.RoomCount)   as tongtiennuoc, bill.dongiaphong as tienphong,\r\n(bill.dongiadien * ElecDevice.chisodien) +(bill.dongianuoc * (waterPay.tongsokhoi / RoomCountPerBuilding.RoomCount)) +bill.dongiaphong  as tongtien,\r\nElecDevice.ngaychotsodien,waterPay.ngaychotsonuoc\r\nfrom  dormitory \r\njoin ElecDevice on dormitory.maphong = ElecDevice.maphong\r\njoin bill on dormitory.maphong = bill.maphong\r\njoin waterPay on waterPay.sotoa = dormitory.sotoa\r\njoin RoomCountPerBuilding on waterPay.sotoa = RoomCountPerBuilding.sotoa\r\nwhere dormitory.soluongSVdango > 0 and ElecDevice.maphong = '"+IdRoomElelcTxt.Text+"' and ElecDevice.ngaychotsodien = '"+DateElec.Text+"'\r\n";

            SqlCommand cm1 = new SqlCommand(checkdate, Conn);
            SqlCommand cm2 = new SqlCommand(checkIdRoom, Conn);
            SqlCommand cm3 = new SqlCommand(checkIDde, Conn);


            if (IdRoomElelcTxt.Text == "" || IdElecTxt.Text == "" || ElecTypeTxt.Text == "" || indexElecTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin để thêm");
                Conn.Close();
            }
            else if (cm1.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Phòng này đã có ngày kiểm tra" + DateElec.Text);
                Conn.Close();
            }
            else if (cm2.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("Không có mã phòng này");
            }
            else if(cm3.ExecuteScalar().ToString().CompareTo("0") != 0)
            {
                DialogResult result = MessageBox.Show("Mã công tơ đã có trong danh sách , bạn có chắc đây là mã công tơ của phòng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if(result == DialogResult.Yes)
                {
                    ConnectAndQuerry(query);
                    Conn = new SqlConnection(ConnectDatabase.ConnDb);
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                    }

                    ConnectAndQuerry(autoInsert);
                    LoadTable(QueryTBCongTo, tableCongTo, ElecTable);
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
            {
                ConnectAndQuerry(query);
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
               
                ConnectAndQuerry(autoInsert);
                LoadTable(QueryTBCongTo, tableCongTo, ElecTable);
                MessageBox.Show("Thêm thành công");


            }

        }

        private void EditElecBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "Update ElecDevice SET ngaychotsodien = '" + DateElec.Text + "' ,macongto = '" + IdElecTxt.Text + "' , loaicongto = N'" + ElecTypeTxt.Text + "', chisodien = '" + indexElecTxt.Text + "' where maphong = '" + IdRoomElelcTxt.Text + "'";

            if (IdRoomElelcTxt.Text == "" || IdElecTxt.Text == "" || ElecTypeTxt.Text == "" || indexElecTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin để sửa");
                Conn.Close();
            }
            else
            {

                ConnectAndQuerry(query);
                MessageBox.Show("Sửa thành công");
                LoadTable(QueryTBCongTo, tableCongTo, ElecTable);

            }
        }

        private void DelElecBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
           
            string query = "DELETE FROM ElecDevice where maphong = '" + IdRoomElelcTxt.Text + "' and ngaychotsodien = '" + DateElec.Text + "'";
            if (IdRoomElelcTxt.Text == "" || DateElec.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã phòng và Ngày chốt số điện để xoá");
                Conn.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc xoá thông tin này", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ConnectAndQuerry(query);

                    LoadTable(QueryTBCongTo, tableCongTo, ElecTable);
                    MessageBox.Show("Xoá thành công");
                }
            }
        }

        private void SearchElecBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (SearchElecCb.SelectedIndex == 0)
            {
                Conn.Open();
                if (SearchElecTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã phòng để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM ElecDevice WHERE maphong = '" + SearchElecTxt.Text + "' ";
                    LoadTable(query, tableCongTo, ElecTable);

                }
                Conn.Close();
            }
            else if (SearchElecCb.SelectedIndex == 1)
            {
                Conn.Open();
                if (SearchElecTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Mã công tơ để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM ElecDevice WHERE macongto = '" + SearchElecTxt.Text + "' ";
                    LoadTable(query, tableCongTo, ElecTable);

                }
                Conn.Close();
            }
            else if (SearchElecCb.SelectedIndex == 2)
            {
                Conn.Open();
                if (SearchElecTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Loại công tơ để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM ElecDevice WHERE loaicongto = '" + SearchElecTxt.Text + "' ";
                    LoadTable(query, tableCongTo, ElecTable);

                }
                Conn.Close();
            }
            else if (SearchElecCb.SelectedIndex == 3)
            {
                Conn.Open();
                if (SearchElecTxt.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập chỉ số phòng để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM ElecDevice WHERE chisodien = '" + SearchElecTxt.Text + "' ";
                    LoadTable(query, tableCongTo, ElecTable);

                }
                Conn.Close();
            }
            else if (SearchElecCb.SelectedIndex == 4)
            {
                Conn.Open();
                if (SearchDateElec.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập Ngày chốt số điện để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM ElecDevice WHERE ngaychotsodien = '" + SearchDateElec.Text + "' ";
                    LoadTable(query, tableCongTo, ElecTable);

                }
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn trường tìm kiếm");
                Conn.Close();
            }
        }

        private void InitWaterBtn_Click(object sender, EventArgs e)
        {
            NumBuildWtTxt.Enabled = true;
            DateWater.Enabled = true;
            NumBuildWtTxt.Text = "";
            IdWaterDevTxt.Text = "";
            TypeDevTxt.Text = "";
            DinhMucTxt.Text = "";
            DatePayTxt.Text = "1/1/2001";
        }

        private void WaterTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = WaterTable.CurrentRow.Index;
            NumBuildWtTxt.Enabled = false;
            DateWater.Enabled = false;
            NumBuildWtTxt.Text = WaterTable.Rows[i].Cells[0].Value.ToString();
            IdWaterDevTxt.Text = WaterTable.Rows[i].Cells[1].Value.ToString();
            TypeDevTxt.Text = WaterTable.Rows[i].Cells[2].Value.ToString();
            DinhMucTxt.Text = WaterTable.Rows[i].Cells[3].Value.ToString();
            DateWater.Text = WaterTable.Rows[i].Cells[4].Value.ToString();
        }

        private void AddWaterBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string quey = "insert into waterPay(sotoa,madongho,loaidongho,tongsokhoi,ngaychotsonuoc) values ('"+ NumBuildWtTxt.Text+"','"+IdWaterDevTxt.Text+"','"+TypeDevTxt.Text+"','"+DinhMucTxt.Text+"','"+ DateWater.Text+"') ";
            string checkNumBuild = "Select count(*) from dormitory where sotoa = '"+ NumBuildWtTxt.Text+"'";
            string check = "select count(*) from waterPay where sotoa = '"+NumBuildWtTxt.Text+"' and ngaychotsonuoc = '"+ DateWater.Text+"'";
            string autoInsert = "with RoomCountPerBuilding AS (\r\n    SELECT sotoa, COUNT(maphong) AS RoomCount\r\n    FROM dormitory\r\n\twhere soluongSVdango > 0\r\n    GROUP BY sotoa\r\n\t\r\n)\r\ninsert into payment(maphong,tongtiendien,tongtiennuoc,tienphong,tongtien,ngaychotsodien,ngaychotsonuoc)\r\nselect dormitory.maphong, bill.dongiadien * ElecDevice.chisodien as tongtiendien , bill.dongianuoc * (waterPay.tongsokhoi / RoomCountPerBuilding.RoomCount)   as tongtiennuoc, bill.dongiaphong as tienphong,\r\n(bill.dongiadien * ElecDevice.chisodien) +(bill.dongianuoc * (waterPay.tongsokhoi / RoomCountPerBuilding.RoomCount)) +bill.dongiaphong  as tongtien,\r\nElecDevice.ngaychotsodien,waterPay.ngaychotsonuoc\r\nfrom  dormitory \r\njoin ElecDevice on dormitory.maphong = ElecDevice.maphong\r\njoin bill on dormitory.maphong = bill.maphong\r\njoin waterPay on waterPay.sotoa = dormitory.sotoa\r\njoin RoomCountPerBuilding on waterPay.sotoa = RoomCountPerBuilding.sotoa\r\nwhere dormitory.soluongSVdango > 0 and waterPay.sotoa = '"+NumBuildWtTxt.Text+"' and waterPay.ngaychotsonuoc = '"+DateWater.Text+"'\r\n";
        

            SqlCommand cmdNumBuil = new SqlCommand(checkNumBuild,Conn);
            SqlCommand cmdCheck = new SqlCommand(check , Conn);
            

            if (NumBuildWtTxt.Text == "" || IdWaterDevTxt.Text == "" || TypeDevTxt.Text == "" || DinhMucTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                Conn.Close();
            } else if (cmdNumBuil.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("không có số toà này");
                Conn.Close();
            } else if (cmdCheck.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Đã chốt số toà " + NumBuildWtTxt.Text + " vào ngày " + DateWater.Text);
                Conn.Close();
            }
            else
            {
                ConnectAndQuerry(quey);
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                ConnectAndQuerry(autoInsert);
                MessageBox.Show("Thêm thành công");

                LoadTable(QueryTBNuoc, tableNuoc, WaterTable);
            }
        }

        private void EditWaterBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "UPDATE waterPay SET madongho = '"+IdWaterDevTxt.Text+"',loaidongho = N'"+TypeDevTxt.Text+"' , tongsokhoi = '"+DinhMucTxt.Text+ "' where sotoa = '"+NumBuildWtTxt.Text+"' and madongho = '"+IdWaterDevTxt.Text+"'  ";
            string check = "select count(*) from waterPay where sotoa = '" + NumBuildWtTxt.Text + "' and ngaychotsonuoc = '" + DateWater.Text + "'";

            SqlCommand cmdCheck = new SqlCommand(check, Conn);

            if (IdWaterDevTxt.Text == "" || TypeDevTxt.Text == "" || DinhMucTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                Conn.Close();
            }
            else if (cmdCheck.ExecuteScalar().ToString() == "0")
            {
                MessageBox.Show("Không có mà phòng và ngày chốt số nước đã nhập!!!");
                Conn.Close();
            }
            else
            {
                ConnectAndQuerry(query);
                MessageBox.Show("Sửa thành công");
                LoadTable(QueryTBNuoc, tableNuoc, WaterTable);
            }
        }

        private void DelWaterBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();

            string query = "DELETE FROM waterPay where sotoa = '"+NumBuildWtTxt.Text+"' and ngaychotsonuoc = '"+DateWater.Text+"'";

            if (IdWaterDevTxt.Text == "" || DinhMucTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                Conn.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc xoá thông tin này", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ConnectAndQuerry(query);
                    MessageBox.Show("xoá thành công");
                    LoadTable(QueryTBNuoc, tableNuoc, WaterTable);
                }
            }
        }

        private void SearchBtnTxt_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (WaterCb.SelectedIndex == 0)
            {
                Conn.Open();
                if (SearchTxtB.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM waterPay WHERE sotoa = '" + SearchTxtB.Text + "' ";
                    LoadTable(query, tableNuoc, WaterTable);

                }
                Conn.Close();
            }
            else if (WaterCb.SelectedIndex == 1)
            {
                Conn.Open();
                if (SearchTxtB.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM waterPay WHERE madongho = '" + SearchTxtB.Text + "' ";
                    LoadTable(query, tableNuoc, WaterTable);

                }
                Conn.Close();
            }
            else if (WaterCb.SelectedIndex == 2)
            {
                Conn.Open();
                if (SearchTxtB.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM waterPay WHERE loaidongho = '" + SearchTxtB.Text + "' ";
                    LoadTable(query, tableNuoc, WaterTable);

                }
                Conn.Close();
            }
            else if (WaterCb.SelectedIndex == 3)
            {
                Conn.Open();
                if (SearchTxtB.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                    Conn.Close();

                }
                else
                {
                    string query = "SELECT * FROM ElecDevice WHERE tongsokhoi = '" + SearchTxtB.Text + "' ";
                    LoadTable(query, tableNuoc, WaterTable);

                }
                Conn.Close();
            }
            else if (WaterCb.SelectedIndex == 4)
            {
                Conn.Open();
                
                    string query = "SELECT * FROM ElecDevice WHERE ngaychotsonuoc = '" + SearchWaterDate.Text + "' ";
                    LoadTable(query, tableNuoc, WaterTable);

                
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn trường tìm kiếm");
                Conn.Close();
            }
        }

        private void TabDienNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            LoadTable(QueryTBPay, tablePay, PaymentTable);
        }

        private void PaymentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = PaymentTable.CurrentRow.Index;
            IdPayTxtB.Text = PaymentTable.Rows[i].Cells[0].Value.ToString();
            IdRoomPayTxt.Text = PaymentTable.Rows[i].Cells[1].Value.ToString();
            PayTxt.Text = PaymentTable.Rows[i].Cells[5].Value.ToString();
            DatePayTxt.Text =  PaymentTable.Rows[i].Cells[8].Value.ToString();
            NodeTxtB.Text = PaymentTable.Rows[i].Cells[9].Value.ToString();
        }

        private void EditPayBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "UPDATE payment set ngaythanhtoan = '"+DatePayTxt.Text+"' , ghichu = '"+NodeTxtB.Text+"' where maphieu = '"+IdPayTxtB.Text+"'";

            if(IdPayTxtB.Text == "")
            {
                MessageBox.Show("Vui lòng click vào dòng thông tin muốn xoá");
                Conn.Close();
            }
            else
            {
                
                ConnectAndQuerry(query);
                LoadTable(QueryTBPay, tablePay, PaymentTable);
            }
        }

        private void SearchPayBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
           
            string query = "";
            switch (PayCb.SelectedIndex)
            {
                case 0 :
                    Conn.Open();
                    if (SearchPayTxtB.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        query = "SELECT * FROM payment WHERE maphieu = '" + SearchPayTxtB.Text + "' ";
                        LoadTable(query, tablePay, PaymentTable);

                    }
                    Conn.Close();
                    break;
                case 1:
                    Conn.Open();
                    if (SearchPayTxtB.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        query = "SELECT * FROM payment WHERE maphong = '" + SearchPayTxtB.Text + "' ";
                        LoadTable(query, tablePay, PaymentTable);

                    }
                    Conn.Close();
                    break;
                case 2:
                    Conn.Open();
                    if (SearchPayTxtB.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        query = "SELECT * FROM payment WHERE tongtiendien = '" + SearchPayTxtB.Text + "' ";
                        LoadTable(query, tablePay, PaymentTable);

                    }
                    Conn.Close();
                    break;
                case 3:
                    Conn.Open();
                    if (SearchPayTxtB.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        query = "SELECT * FROM payment WHERE tongtiennuoc = '" + SearchPayTxtB.Text + "' ";
                        LoadTable(query, tablePay, PaymentTable);

                    }
                    Conn.Close();
                    break;
                case 4:
                    Conn.Open();
                    if (SearchPayTxtB.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        query = "SELECT * FROM payment WHERE tienphong = '" + SearchPayTxtB.Text + "' ";
                        LoadTable(query, tablePay, PaymentTable);

                    }
                    Conn.Close();
                    break;
                case 5:
                    Conn.Open();
                    if (SearchTxtB.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        query = "SELECT * FROM payment WHERE tongtien = '" + SearchTxtB.Text + "' ";
                        LoadTable(query, tablePay, PaymentTable);

                    }
                    Conn.Close();
                    break;
                case 6:
                    
                    Conn.Open();
                    query = "SELECT * FROM payment WHERE ngaychotsodien = '" + SearchPayDate.Text + "' ";
                    LoadTable(query, tablePay, PaymentTable);
                    Conn.Close();
                    break;
                case 7:
                    
                    Conn.Open();
                    query = "SELECT * FROM payment WHERE ngaychotsonuoc = '" + SearchPayDate.Text + "' ";
                    LoadTable(query, tablePay, PaymentTable);
                    Conn.Close();
                    break;
                case 8:
                    
                    Conn.Open();
                    query = "SELECT * FROM payment WHERE ngaythanhtoan = '" + SearchPayDate.Text + "' ";
                    LoadTable(query, tableNuoc, WaterTable);
                    Conn.Close();
                    break;
                case 9:
                    Conn.Open();
                    if (SearchPayTxtB.Text == "")
                    {
                        MessageBox.Show("Vui Lòng nhập thông tin để tìm kiếm ");
                        Conn.Close();

                    }
                    else
                    {
                        query = "SELECT * FROM payment WHERE ghichu = '" + SearchPayTxtB.Text + "' ";
                        LoadTable(query, tablePay, PaymentTable);

                    }
                    Conn.Close();
                    break;
               
                case 10:
                    Conn.Open();
                    query = "SELECT * FROM payment WHERE ngaythanhtoan IS NULL ";
                    LoadTable(query, tablePay, PaymentTable);
                    Conn.Close();
                    break;
                case 11:
                    Conn.Open();
                    query = "SELECT * FROM payment WHERE ngaythanhtoan  IS NOT NULL ";
                    LoadTable(query, tablePay, PaymentTable);
                    Conn.Close();
                    break;
                default:
                    SearchPayDate.Visible = false;
                    MessageBox.Show("Vui Lòng chọn trường tìm kiếm");
                    Conn.Close();
                    break;
            }
        }

        private void PayCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(PayCb.SelectedIndex)
            {

                case 6:
                    SearchPayTxtB.Visible = false;
                    SearchPayDate.Visible = true;
                    break; 
                case 7:
                    SearchPayTxtB.Visible = false;
                    SearchPayDate.Visible = true;
                    break; 
                case 8:
                    SearchPayTxtB.Visible = false;
                    SearchPayDate.Visible = true;
                    break;
                case 10:
                    SearchPayTxtB.Visible = false;
                    SearchPayDate.Visible = false;
                    break;
                case 11:
                    SearchPayDate.Visible = false;
                    SearchPayTxtB.Visible = false;
                    break;
                default:

                    SearchPayTxtB.Visible = true;
                    SearchPayDate.Visible = false;
                    break;
            }
        }

        private void WaterCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WaterCb.SelectedIndex == 4)
            {
                SearchWaterDate.Visible = true;
            }
            else
            {
                SearchWaterDate.Visible = false;
            }
        }

        private void SearchElecCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SearchElecCb.SelectedIndex == 4) {
                SearchDateElec.Visible = true;
            } 
            else
            {
                SearchDateElec.Visible= false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSBillScreen dSBillScreen = new DSBillScreen();
            dSBillScreen.ShowDialog();
        }

        private void OutElecBtn_Click(object sender, EventArgs e)
        {
            DSTienDienScreen dSTienDienScreen = new DSTienDienScreen();
            dSTienDienScreen.ShowDialog();
        }

        private void OutWaterBtn_Click(object sender, EventArgs e)
        {
            DSTienNuocScreen dSTienNuocScreen = new DSTienNuocScreen();
            dSTienNuocScreen.ShowDialog();
        }

        private void OutPayBtn_Click(object sender, EventArgs e)
        {
            DSHoaDonScreen dSHoaDonScreen = new DSHoaDonScreen();
            dSHoaDonScreen.ShowDialog();
        }

        private void SearchBillTxt_TextChanged(object sender, EventArgs e)
        {
            if(SearchBillTxt.Text == "")
            {
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                LoadTable(QueryTBDonGia, tableDonGia, DonGiaTable);
            }
            
        }

        private void SearchElecTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchElecTxt.Text == "")
            {
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                LoadTable(QueryTBCongTo, tableCongTo, ElecTable);
            }
           
        }

        private void SearchTxtB_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxtB.Text == "")
            {
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                LoadTable(QueryTBNuoc, tableNuoc, WaterTable);
            }
        }

        private void NodeTxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchPayTxtB_TextChanged(object sender, EventArgs e)
        {
            if(SearchPayTxtB.Text == "")
            {
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                LoadTable(QueryTBPay, tablePay, PaymentTable);
            }
        }
    }
}
