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

namespace DoAn_1.MainForms.ReportScreen
{
    public partial class SVReportTKScreen : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        
        public SVReportTKScreen()
        {
            InitializeComponent();
        }
       
        private void SVReportTKScreen_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                Conn.Open();
                reportViewer1.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SVKTX_TK"));
                string sql = "select student.masv , student.ho,student.ten , student.gioitinh,student.ngaysinh , student.malop , dormitory.sophong , dormitory.sotoa from student \r\njoin Student_residence on Student_residence.masv = student.masv\r\njoin dormitory on dormitory.maphong = Student_residence.maphong";
                command = new SqlCommand(sql, Conn);
                adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(table);
                ReportDataSource reportDataSouce = new ReportDataSource();
                reportDataSouce.Name = "SVKTX_TK";
                reportDataSouce.Value = table;
                reportViewer1.LocalReport.DataSources.Add(reportDataSouce);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                throw;
            }


           
        }
    }
}
