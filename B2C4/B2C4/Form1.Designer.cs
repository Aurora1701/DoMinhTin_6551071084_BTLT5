namespace B2C4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpNgaySinh = new DateTimePicker();
            numSoBuoiTuan = new NumericUpDown();
            cboGoiTap = new ComboBox();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(381, 19);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(224, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(381, 70);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(224, 27);
            txtSDT.TabIndex = 1;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(381, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 2;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 22);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 73);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 118);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 167);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 269);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 7;
            label5.Text = "Số buổi / tuần";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 217);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 8;
            label6.Text = "Gói tập:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(371, 162);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(349, 27);
            dtpNgaySinh.TabIndex = 9;
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(381, 262);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(249, 27);
            numSoBuoiTuan.TabIndex = 10;
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboGoiTap
            // 
            cboGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(381, 217);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(250, 28);
            cboGoiTap.TabIndex = 11;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm");
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(310, 311);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(194, 68);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(cboGoiTap);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpNgaySinh;
        private NumericUpDown numSoBuoiTuan;
        private ComboBox cboGoiTap;
        private Button btnDangKy;
        private ToolTip toolTip1;
    }
}
