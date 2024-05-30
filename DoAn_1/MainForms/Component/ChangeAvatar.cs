using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_1.MainForms.Component
{
    public partial class ChangeAvatar : Form
    {
        private string destinationFolder;
        private string savePath;
        public ChangeAvatar()
        {
            InitializeComponent();
        }
        private void SaveImage(string imagePath)
        {
            this.destinationFolder = @"\DoAn1\DoAn_1\access";
            if (!Directory.Exists(destinationFolder))
            {
                MessageBox.Show("Destination folder does not exist.");
                return;
            }

            // Lấy tên file và định dạng file
            string fileName = Path.GetFileName(imagePath);
           this.savePath = Path.Combine(destinationFolder, fileName);

            // Kiểm tra xem tập tin đã tồn tại chưa
            if (File.Exists(savePath))
            {
                // Lấy phần mở rộng của tên file
                string fileExtension = Path.GetExtension(fileName);

                // Lấy phần không có phần mở rộng của tên file
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

                // Số lượng lần trùng tên file
                int count = 1;

                // Tạo một tên mới cho tập tin
                string uniqueFileName = fileName;

                while (File.Exists(Path.Combine(destinationFolder, uniqueFileName)))
                {
                    uniqueFileName = $"{fileNameWithoutExtension}_{count}{fileExtension}";
                    count++;
                }

                // Tạo đường dẫn mới
                this.savePath = Path.Combine(destinationFolder, uniqueFileName);
            }

            // Copy file ảnh vào vị trí mới
            File.Copy(imagePath, this.savePath, true);
            MessageBox.Show("Image saved successfully at: " + this.savePath);
        }
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Thiết lập các thuộc tính của hộp thoại chọn file
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn của file đã chọn
                     this.savePath = openFileDialog1.FileName;

                    // Hiển thị ảnh trên PictureBox (nếu cần)
                    pictureBox1.ImageLocation = savePath;

                    // Lưu ảnh vào một vị trí cụ thể
                    SaveImage(savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(ConnectDatabase.ConnDb);
            Conn.Open();
            string query = "update user_table set imageNV = '"+this.savePath +"' where username = '"+Properties.Settings.Default.username+"'";
            SqlCommand cmd = new SqlCommand(query , Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("Thay đổi thành công");

        }
    }
}
