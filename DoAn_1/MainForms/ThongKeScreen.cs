using Microsoft.Reporting.WinForms;
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
using DoAn_1.MainForms.ReportScreen;

namespace DoAn_1.MainForms
{
    public partial class ThongKeScreen : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableSV = new DataTable();
        DataTable tablePKTX = new DataTable();
        DataTable tablePay = new DataTable();
        string querySV = "select student.masv, student.ho ,student.ten,student.gioitinh,student.ngaysinh, student.malop, dormitory.sophong , dormitory.sotoa\r\nfrom student\r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on dormitory.maphong = Student_residence.maphong\r\norder by dormitory.sotoa";
        string queryPKTX = "select dormitory.maphong , dormitory.sophong, dormitory.sotoa, dormitory_items.soluongSVtoida , dormitory.soluongSVdango from dormitory\r\njoin dormitory_items on dormitory_items.maphong = dormitory.maphong";
        string queryPay = "select dormitory.sophong,dormitory.sotoa ,payment.tongtiendien,payment.tongtiennuoc,payment.tienphong , payment.tongtien , payment.ngaythanhtoan , payment.ghichu \r\nfrom payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\norder by sotoa";
        public ThongKeScreen()
        {
            InitializeComponent();

            SVDate.Format = DateTimePickerFormat.Custom;
            SVDate.CustomFormat = "yyyy/MM/dd";

            
            DatePay.Format = DateTimePickerFormat.Custom;
            DatePay.CustomFormat = "yyyy/MM/dd";
        }
        void ConnectAndQuerry(string query)
        {

            command = Conn.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();

            Conn.Close();
            Conn.Dispose();
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
        //HoaDonTK_TLix
        private void ThongKeScreen_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            LoadTable(querySV, tableSV, TableSVKTX);
            LoadTable(queryPKTX , tablePKTX , KTXTable);
            LoadTable(queryPay, tablePay , PayTable);

            SVDate.Visible = false;
            DatePay.Visible = false;
           
        }

        private void SVCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SVCB.SelectedIndex == 2 )
            {
                SVDate.Visible = true;
                SVTxt.Visible = false;
            }
            else
            {
                SVDate.Visible = false;
                SVTxt.Visible = true;
            }
        }

        private void PayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PayCB.SelectedIndex == 5 ) {
                DatePay.Visible = true;
                PayTxt.Visible = false;
            }
            else
            {
                PayTxt.Visible = true;
                DatePay.Visible = false;
            }
        }

        private void SVSrearchBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            switch (SVCB.SelectedIndex)
            {
                case 0:
                    if(SVTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select student.masv ,student.ho , student.ten ,student.ngaysinh,student.gioitinh,student.malop  , dormitory.sophong , dormitory.sotoa\r\nfrom student \r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on Student_residence.maphong = dormitory.maphong\r\nwhere student.masv = '" + SVTxt.Text+"'";
                        LoadTable(query, tableSV, TableSVKTX);
                        Conn.Close();
                    }
                    break;
                case 1:
                    if (SVTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select student.masv ,student.ho , student.ten ,student.ngaysinh,student.gioitinh,student.malop  , dormitory.sophong , dormitory.sotoa\r\nfrom student \r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on Student_residence.maphong = dormitory.maphong\r\nwhere student.[ten] = N'" + SVTxt.Text + "'";
                        LoadTable(query, tableSV, TableSVKTX);
                        Conn.Close();
                    }
                    break;
                case 2:
                    if (SVDate.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select student.masv ,student.ho , student.ten ,student.ngaysinh,student.gioitinh,student.malop  , dormitory.sophong , dormitory.sotoa\r\nfrom student \r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on Student_residence.maphong = dormitory.maphong\r\nwhere student.ngaysinh = '" + SVDate.Text + "'";
                        LoadTable(query, tableSV, TableSVKTX);
                        Conn.Close();
                    }
                    break;
                case 3:
                    if (SVTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select student.masv ,student.ho , student.ten ,student.ngaysinh,student.gioitinh ,student.malop , dormitory.sophong , dormitory.sotoa\r\nfrom student \r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on Student_residence.maphong = dormitory.maphong\r\nwhere student.gioitinh = N'" + SVTxt.Text + "'";
                        LoadTable(query, tableSV, TableSVKTX);
                        Conn.Close();
                    }
                    break;
                case 4:
                    if (SVTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select student.masv ,student.ho , student.ten ,student.ngaysinh,student.gioitinh,student.malop  , dormitory.sophong , dormitory.sotoa\r\nfrom student \r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on Student_residence.maphong = dormitory.maphong\r\nwhere student.[malop] = '" + SVTxt.Text + "'";
                        LoadTable(query, tableSV, TableSVKTX);
                        Conn.Close();
                    }
                    break;
                case 5:
                    if (SVTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                   
                    break;
                case 6:
                    if (SVTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select student.masv ,student.ho , student.ten ,student.ngaysinh,student.gioitinh,student.malop  , dormitory.sophong , dormitory.sotoa\r\nfrom student \r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on Student_residence.maphong = dormitory.maphong\r\nwhere dormitory.sophong = '" + SVTxt.Text + "'";
                        LoadTable(query, tableSV, TableSVKTX);
                        Conn.Close();
                    }
                    break;
                case 7:
                    if (SVTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select student.masv ,student.ho , student.ten ,student.ngaysinh,student.gioitinh,student.malop  , dormitory.sophong , dormitory.sotoa\r\nfrom student \r\njoin Student_residence on student.masv = Student_residence.masv\r\njoin dormitory on Student_residence.maphong = dormitory.maphong\r\nwhere dormitory.sotoa = '" + SVTxt.Text + "'";
                        LoadTable(query, tableSV, TableSVKTX);
                        Conn.Close();
                    }
                    break;
                default:
                    MessageBox.Show("Vui lòng chon trường tìm kiếm");
                    Conn.Close();
                    break;

            }
        }

        private void SVTxt_TextChanged(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            
            if (SVTxt.Text == "")
            {
                LoadTable(querySV, tableSV, TableSVKTX);
            }
        }

        private void SearchPKTXBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            switch(CBPKTX.SelectedIndex)
            {
                case 0:
                    if(PKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select dormitory.maphong ,dormitory.sophong , dormitory.sotoa , dormitory_items.soluongSVtoida , dormitory.soluongSVdango\r\nfrom dormitory \r\njoin dormitory_items on dormitory.maphong = dormitory_items.maphong\r\nwhere dormitory.maphong = '"+PKTXTxt.Text+"'";
                        LoadTable(query, tablePKTX, KTXTable);
                        Conn.Close();
                    }
                    break;
                case 1:
                    if (PKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select dormitory.maphong ,dormitory.sophong , dormitory.sotoa , dormitory_items.soluongSVtoida , dormitory.soluongSVdango\r\nfrom dormitory \r\njoin dormitory_items on dormitory.maphong = dormitory_items.maphong\r\nwhere dormitory.sophong = '" + PKTXTxt.Text + "'";
                        LoadTable(query, tablePKTX, KTXTable);
                        Conn.Close();
                    }
                    break;
                case 2:
                    if (PKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select dormitory.maphong ,dormitory.sophong , dormitory.sotoa , dormitory_items.soluongSVtoida , dormitory.soluongSVdango\r\nfrom dormitory \r\njoin dormitory_items on dormitory.maphong = dormitory_items.maphong\r\nwhere dormitory.sotoa = '" + PKTXTxt.Text + "'";
                        LoadTable(query, tablePKTX, KTXTable);
                        Conn.Close();
                    }
                    break;
                case 3:
                    if (PKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select dormitory.maphong ,dormitory.sophong , dormitory.sotoa , dormitory_items.soluongSVtoida , dormitory.soluongSVdango\r\nfrom dormitory \r\njoin dormitory_items on dormitory.maphong = dormitory_items.maphong\r\nwhere dormitory_items.soluongSVtoida = '" + PKTXTxt.Text + "'";
                        LoadTable(query, tablePKTX, KTXTable);
                        Conn.Close();
                    }
                    break;
                case 4:
                    if (PKTXTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {
                        string query = "select dormitory.maphong ,dormitory.sophong , dormitory.sotoa , dormitory_items.soluongSVtoida , dormitory.soluongSVdango\r\nfrom dormitory \r\njoin dormitory_items on dormitory.maphong = dormitory_items.maphong\r\nwhere dormitory.soluongSVdango = '" + PKTXTxt.Text + "'";
                        LoadTable(query, tablePKTX, KTXTable);
                        Conn.Close();
                    }
                    break;
                default :
                    MessageBox.Show("Vui lòng chon trường tìm kiếm");
                    Conn.Close();
                    break;

            }
        }

        private void PKTXTxt_TextChanged(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (PKTXTxt.Text == "")
            {
                LoadTable(queryPKTX, tablePKTX, KTXTable);
            }
        }

        private void SearchPayBtn_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "";
            switch(PayCB.SelectedIndex)
            {
                case 0:
                    if(PayTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere dormitory.maphong = '"+PayTxt.Text+"'";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    }
                    break;
                case 1:
                    if (PayTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere dormitory.sotoa = '" + PayTxt.Text + "'";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    }
                    break;
                case 2:
                    if (PayTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere payment.tongtiendien = '" + PayTxt.Text + "'";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    }
                    break;
                case 3:
                    if (PayTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere payment.tongtiennuoc = '" + PayTxt.Text + "'";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    }
                    break;
                case 4:
                    if (PayTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere payment.tienphong = '" + PayTxt.Text + "'";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    }
                    break;
                case 5:
                    if (PayTxt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere payment.tongtien = '" + PayTxt.Text + "'";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    }
                    break;
                case 6:
                    if (DatePay.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập thông tin");
                        Conn.Close();
                    }
                    else
                    {

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere payment.ngaythanhtoan = '" + DatePay.Text + "'";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    }
                    break;
                case 7:
                    

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere payment.ngaythanhtoan IS NULL";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    
                    break;
                case 8:
                   

                        query = "select dormitory.sophong , dormitory.sotoa , payment.tongtiendien, payment.tongtiennuoc , payment.tienphong, payment.tongtien, payment.ngaythanhtoan , payment.ghichu from payment\r\njoin dormitory on payment.maphong = dormitory.maphong\r\nwhere payment.ngaythanhtoan IS NOT NULL";
                        LoadTable(query, tablePay, PayTable);
                        Conn.Close();
                    
                   break ;
                default:
                    MessageBox.Show("Vui lòng chon trường tìm kiếm");
                    Conn.Close();
                    break;
            }
        }

        private void PayTxt_TextChanged(object sender, EventArgs e)
        {
            Conn = new SqlConnection(ConnectDatabase.ConnDb);
            if (PayTxt.Text == "")
            {
                LoadTable(queryPay, tablePay, PayTable);
            }
        }

        private void SVReportBtn_Click(object sender, EventArgs e)
        {
            SVReportTKScreen SVRp = new SVReportTKScreen();
            SVRp.ShowDialog();
        }

        private void PKTXReportBtn_Click(object sender, EventArgs e)
        {
            PKTXTKSreen pKTXTKSreen = new PKTXTKSreen();
            pKTXTKSreen.ShowDialog();
        }

        private void PaymentRpBtn_Click(object sender, EventArgs e)
        {
           PaymentTKScreen paymentTKScreen = new PaymentTKScreen();
            paymentTKScreen.ShowDialog();
        }
    }
}
