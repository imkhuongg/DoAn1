namespace DoAn_1.MainForms
{
    partial class QLNhanVien
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
            this.SVTableCtn = new System.Windows.Forms.GroupBox();
            this.NVTable = new System.Windows.Forms.DataGridView();
            this.TableCtn = new System.Windows.Forms.Panel();
            this.EditInfView = new System.Windows.Forms.Panel();
            this.Positiontxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FNameTxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LNameTxBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaTxBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.InitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RePass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchList = new System.Windows.Forms.ComboBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SVTableCtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NVTable)).BeginInit();
            this.TableCtn.SuspendLayout();
            this.EditInfView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SVTableCtn
            // 
            this.SVTableCtn.Controls.Add(this.NVTable);
            this.SVTableCtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SVTableCtn.Location = new System.Drawing.Point(4, 3);
            this.SVTableCtn.Name = "SVTableCtn";
            this.SVTableCtn.Size = new System.Drawing.Size(827, 310);
            this.SVTableCtn.TabIndex = 6;
            this.SVTableCtn.TabStop = false;
            this.SVTableCtn.Text = "Bảng nhân viên";
            // 
            // NVTable
            // 
            this.NVTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NVTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NVTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVTable.GridColor = System.Drawing.SystemColors.Control;
            this.NVTable.Location = new System.Drawing.Point(29, 30);
            this.NVTable.Name = "NVTable";
            this.NVTable.RowHeadersWidth = 51;
            this.NVTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NVTable.Size = new System.Drawing.Size(742, 255);
            this.NVTable.TabIndex = 5;
            this.NVTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NVTable_CellClick);
            this.NVTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NVTable_CellClick);
            // 
            // TableCtn
            // 
            this.TableCtn.Controls.Add(this.SVTableCtn);
            this.TableCtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableCtn.Location = new System.Drawing.Point(0, 0);
            this.TableCtn.Name = "TableCtn";
            this.TableCtn.Size = new System.Drawing.Size(832, 313);
            this.TableCtn.TabIndex = 10;
            // 
            // EditInfView
            // 
            this.EditInfView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditInfView.Controls.Add(this.Positiontxt);
            this.EditInfView.Controls.Add(this.emailTxt);
            this.EditInfView.Controls.Add(this.label6);
            this.EditInfView.Controls.Add(this.label5);
            this.EditInfView.Controls.Add(this.label3);
            this.EditInfView.Controls.Add(this.FNameTxBox);
            this.EditInfView.Controls.Add(this.label2);
            this.EditInfView.Controls.Add(this.LNameTxBox);
            this.EditInfView.Controls.Add(this.label1);
            this.EditInfView.Controls.Add(this.MaTxBox);
            this.EditInfView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditInfView.Location = new System.Drawing.Point(0, 312);
            this.EditInfView.Name = "EditInfView";
            this.EditInfView.Size = new System.Drawing.Size(832, 221);
            this.EditInfView.TabIndex = 9;
            // 
            // Positiontxt
            // 
            this.Positiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Positiontxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Positiontxt.Location = new System.Drawing.Point(386, 106);
            this.Positiontxt.Multiline = true;
            this.Positiontxt.Name = "Positiontxt";
            this.Positiontxt.Size = new System.Drawing.Size(229, 23);
            this.Positiontxt.TabIndex = 18;
            // 
            // emailTxt
            // 
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.emailTxt.Location = new System.Drawing.Point(103, 107);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(202, 23);
            this.emailTxt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(343, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vị trí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(52, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "email";
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
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // MaTxBox
            // 
            this.MaTxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaTxBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaTxBox.Location = new System.Drawing.Point(103, 27);
            this.MaTxBox.Multiline = true;
            this.MaTxBox.Name = "MaTxBox";
            this.MaTxBox.Size = new System.Drawing.Size(137, 25);
            this.MaTxBox.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddBtn.Location = new System.Drawing.Point(0, 66);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(200, 63);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.RePass);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SearchTxt);
            this.panel1.Controls.Add(this.SearchList);
            this.panel1.Controls.Add(this.DelBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.InitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(832, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 533);
            this.panel1.TabIndex = 8;
            // 
            // RePass
            // 
            this.RePass.FlatAppearance.BorderSize = 0;
            this.RePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RePass.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RePass.Location = new System.Drawing.Point(3, 264);
            this.RePass.Name = "RePass";
            this.RePass.Size = new System.Drawing.Size(194, 60);
            this.RePass.TabIndex = 17;
            this.RePass.Text = "Reset mật khẩu nhân viên";
            this.RePass.UseVisualStyleBackColor = true;
            this.RePass.Click += new System.EventHandler(this.RePass_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(33, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xuất file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchTxt.Location = new System.Drawing.Point(33, 418);
            this.SearchTxt.Multiline = true;
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(144, 27);
            this.SearchTxt.TabIndex = 6;
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
            "Mã nhân viên",
            "Họ",
            "Tên",
            "email",
            "Vị trí"});
            this.SearchList.Location = new System.Drawing.Point(33, 384);
            this.SearchList.Name = "SearchList";
            this.SearchList.Size = new System.Drawing.Size(144, 26);
            this.SearchList.TabIndex = 5;
            // 
            // DelBtn
            // 
            this.DelBtn.FlatAppearance.BorderSize = 0;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DelBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DelBtn.Location = new System.Drawing.Point(0, 130);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(200, 61);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "Xoá";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchBtn.Location = new System.Drawing.Point(3, 319);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(194, 60);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Tìm kiếm Theo";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EditBtn.Location = new System.Drawing.Point(0, 197);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(200, 61);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Sửa";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 533);
            this.ControlBox = false;
            this.Controls.Add(this.TableCtn);
            this.Controls.Add(this.EditInfView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.SVTableCtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NVTable)).EndInit();
            this.TableCtn.ResumeLayout(false);
            this.EditInfView.ResumeLayout(false);
            this.EditInfView.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SVTableCtn;
        private System.Windows.Forms.DataGridView NVTable;
        private System.Windows.Forms.Panel TableCtn;
        private System.Windows.Forms.Panel EditInfView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FNameTxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LNameTxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaTxBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button InitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox SearchList;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox Positiontxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Button RePass;
    }
}