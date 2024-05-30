namespace DoAn_1.MainForms.Component
{
    partial class ChangeNameScreen
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
            this.HoTxtBox = new System.Windows.Forms.TextBox();
            this.TenTxtBox = new System.Windows.Forms.TextBox();
            this.lablq1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HoTxtBox
            // 
            this.HoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HoTxtBox.Location = new System.Drawing.Point(191, 31);
            this.HoTxtBox.Name = "HoTxtBox";
            this.HoTxtBox.Size = new System.Drawing.Size(149, 29);
            this.HoTxtBox.TabIndex = 0;
            // 
            // TenTxtBox
            // 
            this.TenTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TenTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenTxtBox.Location = new System.Drawing.Point(191, 88);
            this.TenTxtBox.Name = "TenTxtBox";
            this.TenTxtBox.Size = new System.Drawing.Size(149, 29);
            this.TenTxtBox.TabIndex = 1;
            // 
            // lablq1
            // 
            this.lablq1.AutoSize = true;
            this.lablq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lablq1.Location = new System.Drawing.Point(139, 33);
            this.lablq1.Name = "lablq1";
            this.lablq1.Size = new System.Drawing.Size(35, 24);
            this.lablq1.TabIndex = 2;
            this.lablq1.Text = "Họ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(130, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(191, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đổi thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(117, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // emailTxtB
            // 
            this.emailTxtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.emailTxtB.Location = new System.Drawing.Point(191, 138);
            this.emailTxtB.Name = "emailTxtB";
            this.emailTxtB.Size = new System.Drawing.Size(149, 29);
            this.emailTxtB.TabIndex = 5;
            // 
            // ChangeNameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxtB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lablq1);
            this.Controls.Add(this.TenTxtBox);
            this.Controls.Add(this.HoTxtBox);
            this.Name = "ChangeNameScreen";
            this.Text = "Đổi tên";
            this.Load += new System.EventHandler(this.ChangeNameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HoTxtBox;
        private System.Windows.Forms.TextBox TenTxtBox;
        private System.Windows.Forms.Label lablq1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTxtB;
    }
}