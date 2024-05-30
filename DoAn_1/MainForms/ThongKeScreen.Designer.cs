namespace DoAn_1.MainForms
{
    partial class ThongKeScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SVReportBtn = new System.Windows.Forms.Button();
            this.SVDate = new System.Windows.Forms.DateTimePicker();
            this.SVCB = new System.Windows.Forms.ComboBox();
            this.SVTxt = new System.Windows.Forms.TextBox();
            this.SVSrearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableSVKTX = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PKTXReportBtn = new System.Windows.Forms.Button();
            this.CBPKTX = new System.Windows.Forms.ComboBox();
            this.PKTXTxt = new System.Windows.Forms.TextBox();
            this.SearchPKTXBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KTXTable = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DatePay = new System.Windows.Forms.DateTimePicker();
            this.PayCB = new System.Windows.Forms.ComboBox();
            this.PayTxt = new System.Windows.Forms.TextBox();
            this.SearchPayBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PayTable = new System.Windows.Forms.DataGridView();
            this.PaymentRpBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSVKTX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KTXTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1057, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sinh viên đang ở";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.SVReportBtn);
            this.panel2.Controls.Add(this.SVDate);
            this.panel2.Controls.Add(this.SVCB);
            this.panel2.Controls.Add(this.SVTxt);
            this.panel2.Controls.Add(this.SVSrearchBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(841, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 536);
            this.panel2.TabIndex = 1;
            // 
            // SVReportBtn
            // 
            this.SVReportBtn.BackColor = System.Drawing.Color.DimGray;
            this.SVReportBtn.Location = new System.Drawing.Point(36, 149);
            this.SVReportBtn.Name = "SVReportBtn";
            this.SVReportBtn.Size = new System.Drawing.Size(142, 36);
            this.SVReportBtn.TabIndex = 7;
            this.SVReportBtn.Text = "Xuất báo cáo";
            this.SVReportBtn.UseVisualStyleBackColor = false;
            this.SVReportBtn.Click += new System.EventHandler(this.SVReportBtn_Click);
            // 
            // SVDate
            // 
            this.SVDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SVDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SVDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SVDate.Location = new System.Drawing.Point(10, 117);
            this.SVDate.Name = "SVDate";
            this.SVDate.Size = new System.Drawing.Size(200, 26);
            this.SVDate.TabIndex = 6;
            this.SVDate.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // SVCB
            // 
            this.SVCB.BackColor = System.Drawing.Color.DimGray;
            this.SVCB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SVCB.ForeColor = System.Drawing.Color.White;
            this.SVCB.FormattingEnabled = true;
            this.SVCB.Items.AddRange(new object[] {
            "Mã SV",
            "Tên",
            "Ngày sinh",
            "Giới tính",
            "Lớp",
            "Khoá",
            "Số phòng",
            "Số Toà"});
            this.SVCB.Location = new System.Drawing.Point(9, 55);
            this.SVCB.Name = "SVCB";
            this.SVCB.Size = new System.Drawing.Size(200, 26);
            this.SVCB.TabIndex = 5;
            this.SVCB.SelectedIndexChanged += new System.EventHandler(this.SVCB_SelectedIndexChanged);
            // 
            // SVTxt
            // 
            this.SVTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SVTxt.Location = new System.Drawing.Point(9, 85);
            this.SVTxt.Name = "SVTxt";
            this.SVTxt.Size = new System.Drawing.Size(201, 26);
            this.SVTxt.TabIndex = 4;
            this.SVTxt.TextChanged += new System.EventHandler(this.SVTxt_TextChanged);
            // 
            // SVSrearchBtn
            // 
            this.SVSrearchBtn.BackColor = System.Drawing.Color.DimGray;
            this.SVSrearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SVSrearchBtn.Location = new System.Drawing.Point(7, 3);
            this.SVSrearchBtn.Name = "SVSrearchBtn";
            this.SVSrearchBtn.Size = new System.Drawing.Size(203, 47);
            this.SVSrearchBtn.TabIndex = 3;
            this.SVSrearchBtn.Text = "Tìm kiếm theo";
            this.SVSrearchBtn.UseVisualStyleBackColor = false;
            this.SVSrearchBtn.Click += new System.EventHandler(this.SVSrearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 536);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableSVKTX);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thông tin sinh viên đang ở";
            // 
            // TableSVKTX
            // 
            this.TableSVKTX.BackgroundColor = System.Drawing.Color.White;
            this.TableSVKTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSVKTX.Location = new System.Drawing.Point(22, 28);
            this.TableSVKTX.Name = "TableSVKTX";
            this.TableSVKTX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSVKTX.Size = new System.Drawing.Size(789, 488);
            this.TableSVKTX.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1057, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Các phòng KTX";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.PKTXReportBtn);
            this.panel4.Controls.Add(this.CBPKTX);
            this.panel4.Controls.Add(this.PKTXTxt);
            this.panel4.Controls.Add(this.SearchPKTXBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(844, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 536);
            this.panel4.TabIndex = 2;
            // 
            // PKTXReportBtn
            // 
            this.PKTXReportBtn.BackColor = System.Drawing.Color.DimGray;
            this.PKTXReportBtn.Location = new System.Drawing.Point(35, 117);
            this.PKTXReportBtn.Name = "PKTXReportBtn";
            this.PKTXReportBtn.Size = new System.Drawing.Size(142, 36);
            this.PKTXReportBtn.TabIndex = 8;
            this.PKTXReportBtn.Text = "Xuất báo cáo";
            this.PKTXReportBtn.UseVisualStyleBackColor = false;
            this.PKTXReportBtn.Click += new System.EventHandler(this.PKTXReportBtn_Click);
            // 
            // CBPKTX
            // 
            this.CBPKTX.BackColor = System.Drawing.Color.DimGray;
            this.CBPKTX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CBPKTX.ForeColor = System.Drawing.Color.White;
            this.CBPKTX.FormattingEnabled = true;
            this.CBPKTX.Items.AddRange(new object[] {
            "Mã phòng",
            "Số phòng",
            "Số toà",
            "Số lượng sinh viên tối đa",
            "Số lượng sinh viên đang ở"});
            this.CBPKTX.Location = new System.Drawing.Point(5, 55);
            this.CBPKTX.Name = "CBPKTX";
            this.CBPKTX.Size = new System.Drawing.Size(200, 26);
            this.CBPKTX.TabIndex = 2;
            // 
            // PKTXTxt
            // 
            this.PKTXTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PKTXTxt.Location = new System.Drawing.Point(5, 85);
            this.PKTXTxt.Name = "PKTXTxt";
            this.PKTXTxt.Size = new System.Drawing.Size(201, 26);
            this.PKTXTxt.TabIndex = 1;
            this.PKTXTxt.TextChanged += new System.EventHandler(this.PKTXTxt_TextChanged);
            // 
            // SearchPKTXBtn
            // 
            this.SearchPKTXBtn.BackColor = System.Drawing.Color.DimGray;
            this.SearchPKTXBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPKTXBtn.Location = new System.Drawing.Point(3, 3);
            this.SearchPKTXBtn.Name = "SearchPKTXBtn";
            this.SearchPKTXBtn.Size = new System.Drawing.Size(203, 47);
            this.SearchPKTXBtn.TabIndex = 0;
            this.SearchPKTXBtn.Text = "Tìm kiếm theo";
            this.SearchPKTXBtn.UseVisualStyleBackColor = false;
            this.SearchPKTXBtn.Click += new System.EventHandler(this.SearchPKTXBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 536);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KTXTable);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 522);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng thông tin các phòng";
            // 
            // KTXTable
            // 
            this.KTXTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KTXTable.BackgroundColor = System.Drawing.Color.White;
            this.KTXTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KTXTable.Location = new System.Drawing.Point(3, 29);
            this.KTXTable.Name = "KTXTable";
            this.KTXTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.KTXTable.Size = new System.Drawing.Size(825, 487);
            this.KTXTable.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1057, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thông tin thanh toán";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.PaymentRpBtn);
            this.panel6.Controls.Add(this.DatePay);
            this.panel6.Controls.Add(this.PayCB);
            this.panel6.Controls.Add(this.PayTxt);
            this.panel6.Controls.Add(this.SearchPayBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(844, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 536);
            this.panel6.TabIndex = 3;
            // 
            // DatePay
            // 
            this.DatePay.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DatePay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePay.Location = new System.Drawing.Point(7, 117);
            this.DatePay.Name = "DatePay";
            this.DatePay.Size = new System.Drawing.Size(200, 26);
            this.DatePay.TabIndex = 7;
            this.DatePay.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // PayCB
            // 
            this.PayCB.BackColor = System.Drawing.Color.DimGray;
            this.PayCB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PayCB.ForeColor = System.Drawing.Color.White;
            this.PayCB.FormattingEnabled = true;
            this.PayCB.Items.AddRange(new object[] {
            "Số phòng",
            "Số toà",
            "Tổng tiền điện",
            "Tổng tiền nước",
            "Tiền phòng",
            "Tổng tiền",
            "Ngày thanh toán",
            "Phòng chưa thanh toán",
            "Phòng đã thanh toán"});
            this.PayCB.Location = new System.Drawing.Point(6, 55);
            this.PayCB.Name = "PayCB";
            this.PayCB.Size = new System.Drawing.Size(200, 26);
            this.PayCB.TabIndex = 5;
            this.PayCB.SelectedIndexChanged += new System.EventHandler(this.PayCB_SelectedIndexChanged);
            // 
            // PayTxt
            // 
            this.PayTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PayTxt.Location = new System.Drawing.Point(6, 85);
            this.PayTxt.Name = "PayTxt";
            this.PayTxt.Size = new System.Drawing.Size(201, 26);
            this.PayTxt.TabIndex = 4;
            this.PayTxt.TextChanged += new System.EventHandler(this.PayTxt_TextChanged);
            // 
            // SearchPayBtn
            // 
            this.SearchPayBtn.BackColor = System.Drawing.Color.DimGray;
            this.SearchPayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPayBtn.Location = new System.Drawing.Point(4, 3);
            this.SearchPayBtn.Name = "SearchPayBtn";
            this.SearchPayBtn.Size = new System.Drawing.Size(203, 47);
            this.SearchPayBtn.TabIndex = 3;
            this.SearchPayBtn.Text = "Tìm kiếm theo";
            this.SearchPayBtn.UseVisualStyleBackColor = false;
            this.SearchPayBtn.Click += new System.EventHandler(this.SearchPayBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(839, 536);
            this.panel5.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PayTable);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 522);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng thông tin thanh toán";
            // 
            // PayTable
            // 
            this.PayTable.BackgroundColor = System.Drawing.Color.White;
            this.PayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayTable.Location = new System.Drawing.Point(3, 34);
            this.PayTable.Name = "PayTable";
            this.PayTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PayTable.Size = new System.Drawing.Size(825, 482);
            this.PayTable.TabIndex = 0;
            // 
            // PaymentRpBtn
            // 
            this.PaymentRpBtn.BackColor = System.Drawing.Color.DimGray;
            this.PaymentRpBtn.Location = new System.Drawing.Point(39, 149);
            this.PaymentRpBtn.Name = "PaymentRpBtn";
            this.PaymentRpBtn.Size = new System.Drawing.Size(142, 36);
            this.PaymentRpBtn.TabIndex = 9;
            this.PaymentRpBtn.Text = "Xuất báo cáo";
            this.PaymentRpBtn.UseVisualStyleBackColor = false;
            this.PaymentRpBtn.Click += new System.EventHandler(this.PaymentRpBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1057, 542);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Báo cáo danh sách";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ThongKeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 572);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeScreen";
            this.Text = "ThongKeScreen";
            this.Load += new System.EventHandler(this.ThongKeScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableSVKTX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KTXTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PayTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TableSVKTX;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView KTXTable;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView PayTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox PKTXTxt;
        private System.Windows.Forms.Button SearchPKTXBtn;
        private System.Windows.Forms.ComboBox CBPKTX;
        private System.Windows.Forms.ComboBox SVCB;
        private System.Windows.Forms.TextBox SVTxt;
        private System.Windows.Forms.Button SVSrearchBtn;
        private System.Windows.Forms.ComboBox PayCB;
        private System.Windows.Forms.TextBox PayTxt;
        private System.Windows.Forms.Button SearchPayBtn;
        private System.Windows.Forms.DateTimePicker SVDate;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.Button SVReportBtn;
        private System.Windows.Forms.Button PKTXReportBtn;
        private System.Windows.Forms.Button PaymentRpBtn;
        private System.Windows.Forms.TabPage tabPage4;
    }
}