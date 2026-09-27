namespace B1C5
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
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(608, 62);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(608, 114);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.KeyPress += txtChiNhapSo_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(608, 166);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 2;
            txtDonGia.KeyPress += txtChiNhapSo_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(554, 225);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 76);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(678, 225);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(85, 76);
            btnXoaTrang.TabIndex = 4;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(12, 12);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(467, 424);
            lstKetQua.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 65);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã SP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 121);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 169);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 8;
            label3.Text = "Đơn giá:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
