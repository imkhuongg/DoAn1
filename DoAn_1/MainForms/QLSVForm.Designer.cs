namespace DoAn_1.MainForms
{
    partial class QLSVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchQLSVDate = new System.Windows.Forms.DateTimePicker();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchList = new System.Windows.Forms.ComboBox();
            this.DelSvBtn = new System.Windows.Forms.Button();
            this.SearchSvBtn = new System.Windows.Forms.Button();
            this.EditSvBtn = new System.Windows.Forms.Button();
            this.AddSvBtn = new System.Windows.Forms.Button();
            this.InitBtn = new System.Windows.Forms.Button();
            this.SVTable = new System.Windows.Forms.DataGridView();
            this.EditInfView = new System.Windows.Forms.Panel();
            this.KhoaCB = new System.Windows.Forms.ComboBox();
            this.SvClassTxBox = new System.Windows.Forms.ComboBox();
            this.GioiTinhCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NgaySinhTxbox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FNameTxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LNameTxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSVTxBox = new System.Windows.Forms.TextBox();
            this.TableCtn = new System.Windows.Forms.Panel();
            this.SVTableCtn = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SVTable)).BeginInit();
            this.EditInfView.SuspendLayout();
            this.TableCtn.SuspendLayout();
            this.SVTableCtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SearchQLSVDate);
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.SearchList);
            this.panel1.Controls.Add(this.DelSvBtn);
            this.panel1.Controls.Add(this.SearchSvBtn);
            this.panel1.Controls.Add(this.EditSvBtn);
            this.panel1.Controls.Add(this.AddSvBtn);
            this.panel1.Controls.Add(this.InitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(867, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 572);
            this.panel1.TabIndex = 4;
            // 
            // SearchQLSVDate
            // 
            this.SearchQLSVDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQLSVDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SearchQLSVDate.Location = new System.Drawing.Point(28, 397);
            this.SearchQLSVDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.SearchQLSVDate.Name = "SearchQLSVDate";
            this.SearchQLSVDate.Size = new System.Drawing.Size(144, 26);
            this.SearchQLSVDate.TabIndex = 15;
            this.SearchQLSVDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchTxt.Location = new System.Drawing.Point(28, 364);
            this.SearchTxt.Multiline = true;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(144, 27);
            this.SearchTxt.TabIndex = 6;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // SearchList
            // 
            this.SearchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.SearchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchList.ForeColor = System.Drawing.SystemColors.Menu;
            this.SearchList.FormattingEnabled = true;
            this.SearchList.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Họ",
            "Tên",
            "Khoá",
            "Khoa",
            "Lớp",
            "Ngày sinh"});
            this.SearchList.Location = new System.Drawing.Point(28, 330);
            this.SearchList.Name = "SearchList";
            this.SearchList.Size = new System.Drawing.Size(144, 26);
            this.SearchList.TabIndex = 5;
            this.SearchList.SelectedIndexChanged += new System.EventHandler(this.SearchList_SelectedIndexChanged);
            // 
            // DelSvBtn
            // 
            this.DelSvBtn.FlatAppearance.BorderSize = 0;
            this.DelSvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelSvBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DelSvBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DelSvBtn.Location = new System.Drawing.Point(0, 130);
            this.DelSvBtn.Name = "DelSvBtn";
            this.DelSvBtn.Size = new System.Drawing.Size(200, 61);
            this.DelSvBtn.TabIndex = 4;
            this.DelSvBtn.Text = "Xoá";
            this.DelSvBtn.UseVisualStyleBackColor = true;
            this.DelSvBtn.Click += new System.EventHandler(this.DelSvBtn_Click);
            // 
            // SearchSvBtn
            // 
            this.SearchSvBtn.FlatAppearance.BorderSize = 0;
            this.SearchSvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchSvBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchSvBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchSvBtn.Location = new System.Drawing.Point(3, 264);
            this.SearchSvBtn.Name = "SearchSvBtn";
            this.SearchSvBtn.Size = new System.Drawing.Size(194, 60);
            this.SearchSvBtn.TabIndex = 3;
            this.SearchSvBtn.Text = "Tìm kiếm sinh viên Theo";
            this.SearchSvBtn.UseVisualStyleBackColor = true;
            this.SearchSvBtn.Click += new System.EventHandler(this.SearchSvBtn_Click);
            // 
            // EditSvBtn
            // 
            this.EditSvBtn.FlatAppearance.BorderSize = 0;
            this.EditSvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSvBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.EditSvBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EditSvBtn.Location = new System.Drawing.Point(0, 197);
            this.EditSvBtn.Name = "EditSvBtn";
            this.EditSvBtn.Size = new System.Drawing.Size(200, 61);
            this.EditSvBtn.TabIndex = 2;
            this.EditSvBtn.Text = "Sửa Sinh Viên";
            this.EditSvBtn.UseVisualStyleBackColor = true;
            this.EditSvBtn.Click += new System.EventHandler(this.EditSvBtn_Click);
            // 
            // AddSvBtn
            // 
            this.AddSvBtn.FlatAppearance.BorderSize = 0;
            this.AddSvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSvBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddSvBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddSvBtn.Location = new System.Drawing.Point(0, 66);
            this.AddSvBtn.Name = "AddSvBtn";
            this.AddSvBtn.Size = new System.Drawing.Size(200, 63);
            this.AddSvBtn.TabIndex = 1;
            this.AddSvBtn.Text = "Thêm Sinh Viên";
            this.AddSvBtn.UseVisualStyleBackColor = true;
            this.AddSvBtn.Click += new System.EventHandler(this.AddSvBtn_Click);
            // 
            // InitBtn
            // 
            this.InitBtn.FlatAppearance.BorderSize = 0;
            this.InitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.InitBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InitBtn.Location = new System.Drawing.Point(0, 0);
            this.InitBtn.Name = "InitBtn";
            this.InitBtn.Size = new System.Drawing.Size(200, 60);
            this.InitBtn.TabIndex = 0;
            this.InitBtn.Text = "Khởi tạo Ô nhập";
            this.InitBtn.UseVisualStyleBackColor = true;
            this.InitBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // SVTable
            // 
            this.SVTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SVTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SVTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SVTable.GridColor = System.Drawing.SystemColors.Control;
            this.SVTable.Location = new System.Drawing.Point(29, 30);
            this.SVTable.Name = "SVTable";
            this.SVTable.RowHeadersWidth = 51;
            this.SVTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SVTable.Size = new System.Drawing.Size(742, 255);
            this.SVTable.TabIndex = 5;
            this.SVTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SVTable_CellContentClick);
            // 
            // EditInfView
            // 
            this.EditInfView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditInfView.Controls.Add(this.KhoaCB);
            this.EditInfView.Controls.Add(this.SvClassTxBox);
            this.EditInfView.Controls.Add(this.GioiTinhCB);
            this.EditInfView.Controls.Add(this.label8);
            this.EditInfView.Controls.Add(this.NgaySinhTxbox);
            this.EditInfView.Controls.Add(this.label7);
            this.EditInfView.Controls.Add(this.label6);
            this.EditInfView.Controls.Add(this.label5);
            this.EditInfView.Controls.Add(this.label3);
            this.EditInfView.Controls.Add(this.FNameTxBox);
            this.EditInfView.Controls.Add(this.label2);
            this.EditInfView.Controls.Add(this.LNameTxBox);
            this.EditInfView.Controls.Add(this.label1);
            this.EditInfView.Controls.Add(this.MaSVTxBox);
            this.EditInfView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditInfView.Location = new System.Drawing.Point(0, 334);
            this.EditInfView.Name = "EditInfView";
            this.EditInfView.Size = new System.Drawing.Size(867, 238);
            this.EditInfView.TabIndex = 6;
            // 
            // KhoaCB
            // 
            this.KhoaCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.KhoaCB.FormattingEnabled = true;
            this.KhoaCB.Location = new System.Drawing.Point(89, 103);
            this.KhoaCB.Name = "KhoaCB";
            this.KhoaCB.Size = new System.Drawing.Size(155, 30);
            this.KhoaCB.TabIndex = 19;
            this.KhoaCB.SelectedIndexChanged += new System.EventHandler(this.KhoaCB_SelectedIndexChanged);
            // 
            // SvClassTxBox
            // 
            this.SvClassTxBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SvClassTxBox.FormattingEnabled = true;
            this.SvClassTxBox.Location = new System.Drawing.Point(359, 105);
            this.SvClassTxBox.Name = "SvClassTxBox";
            this.SvClassTxBox.Size = new System.Drawing.Size(164, 30);
            this.SvClassTxBox.TabIndex = 18;
            // 
            // GioiTinhCB
            // 
            this.GioiTinhCB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinhCB.FormattingEnabled = true;
            this.GioiTinhCB.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GioiTinhCB.Location = new System.Drawing.Point(656, 109);
            this.GioiTinhCB.Margin = new System.Windows.Forms.Padding(2);
            this.GioiTinhCB.Name = "GioiTinhCB";
            this.GioiTinhCB.Size = new System.Drawing.Size(92, 28);
            this.GioiTinhCB.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(587, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Giới tính";
            // 
            // NgaySinhTxbox
            // 
            this.NgaySinhTxbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhTxbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgaySinhTxbox.Location = new System.Drawing.Point(103, 197);
            this.NgaySinhTxbox.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NgaySinhTxbox.Name = "NgaySinhTxbox";
            this.NgaySinhTxbox.Size = new System.Drawing.Size(148, 26);
            this.NgaySinhTxbox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(310, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(28, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(607, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên";
            // 
            // FNameTxBox
            // 
            this.FNameTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FNameTxBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FNameTxBox.Location = new System.Drawing.Point(656, 23);
            this.FNameTxBox.Multiline = true;
            this.FNameTxBox.Name = "FNameTxBox";
            this.FNameTxBox.Size = new System.Drawing.Size(137, 27);
            this.FNameTxBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(346, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ";
            // 
            // LNameTxBox
            // 
            this.LNameTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LNameTxBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LNameTxBox.Location = new System.Drawing.Point(386, 25);
            this.LNameTxBox.Multiline = true;
            this.LNameTxBox.Name = "LNameTxBox";
            this.LNameTxBox.Size = new System.Drawing.Size(137, 25);
            this.LNameTxBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV";
            // 
            // MaSVTxBox
            // 
            this.MaSVTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaSVTxBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaSVTxBox.Location = new System.Drawing.Point(103, 27);
            this.MaSVTxBox.Multiline = true;
            this.MaSVTxBox.Name = "MaSVTxBox";
            this.MaSVTxBox.Size = new System.Drawing.Size(137, 25);
            this.MaSVTxBox.TabIndex = 0;
            // 
            // TableCtn
            // 
            this.TableCtn.Controls.Add(this.SVTableCtn);
            this.TableCtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableCtn.Location = new System.Drawing.Point(0, 0);
            this.TableCtn.Name = "TableCtn";
            this.TableCtn.Size = new System.Drawing.Size(867, 335);
            this.TableCtn.TabIndex = 7;
            // 
            // SVTableCtn
            // 
            this.SVTableCtn.Controls.Add(this.SVTable);
            this.SVTableCtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SVTableCtn.Location = new System.Drawing.Point(32, 12);
            this.SVTableCtn.Name = "SVTableCtn";
            this.SVTableCtn.Size = new System.Drawing.Size(799, 301);
            this.SVTableCtn.TabIndex = 6;
            this.SVTableCtn.TabStop = false;
            this.SVTableCtn.Text = "Bảng Sinh Viên";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(35, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xuất file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 572);
            this.Controls.Add(this.TableCtn);
            this.Controls.Add(this.EditInfView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "QLSVForm";
            this.Text = "QLSVForm";
            this.Load += new System.EventHandler(this.QLSVForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SVTable)).EndInit();
            this.EditInfView.ResumeLayout(false);
            this.EditInfView.PerformLayout();
            this.TableCtn.ResumeLayout(false);
            this.SVTableCtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchSvBtn;
        private System.Windows.Forms.Button EditSvBtn;
        private System.Windows.Forms.Button AddSvBtn;
        private System.Windows.Forms.Button InitBtn;
        private System.Windows.Forms.DataGridView SVTable;
        private System.Windows.Forms.Panel EditInfView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaSVTxBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FNameTxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LNameTxBox;
        private System.Windows.Forms.DateTimePicker NgaySinhTxbox;
        private System.Windows.Forms.Panel TableCtn;
        private System.Windows.Forms.Button DelSvBtn;
        private System.Windows.Forms.GroupBox SVTableCtn;
        private System.Windows.Forms.ComboBox SearchList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GioiTinhCB;
        private System.Windows.Forms.DateTimePicker SearchQLSVDate;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox KhoaCB;
        private System.Windows.Forms.ComboBox SvClassTxBox;
        private System.Windows.Forms.Button button1;
    }
}