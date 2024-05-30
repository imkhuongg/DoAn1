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
    public partial class DSNhanVienScreen : Form
    {
        SqlConnection Conn;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DSNhanVienScreen()
        {
            InitializeComponent();
        }

        private void DSNhanVienScreen_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                Conn = new SqlConnection(ConnectDatabase.ConnDb);
                Conn.Open();
                reportViewer1.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1"));
                string sql = "select * from user_table";
                command = new SqlCommand(sql, Conn);
                adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(table);
                ReportDataSource reportDataSouce = new ReportDataSource();
                reportDataSouce.Name = "DataSet1";
                reportDataSouce.Value = table;
                reportViewer1.LocalReport.DataSources.Add(reportDataSouce);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                throw;
            }
            this.reportViewer1.RefreshReport();
            
        }
    }
}
