namespace B4C4
{
    partial class frmBenhNhan
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
            txtHoTen = new MaskedTextBox();
            numTuoi = new NumericUpDown();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lstBenhNhan = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(597, 51);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 0;
            // 
            // numTuoi
            // 
            numTuoi.Location = new Point(597, 104);
            numTuoi.Name = "numTuoi";
            numTuoi.Size = new Size(150, 27);
            numTuoi.TabIndex = 1;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(597, 156);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(125, 27);
            txtTrieuChung.TabIndex = 2;
            // 
            // btnLuuTam
            // 
            btnLuuTam.Location = new Point(584, 200);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(163, 106);
            btnLuuTam.TabIndex = 3;
            btnLuuTam.Text = "Lưu tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(12, 38);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(286, 384);
            lstBenhNhan.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 51);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 104);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "Tuổi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 159);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 7;
            label3.Text = "Triệu chứng";
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(numTuoi);
            Controls.Add(txtHoTen);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtHoTen;
        private NumericUpDown numTuoi;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private ListBox lstBenhNhan;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}