namespace B4C4
{
    partial class frmLichHen
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
            dtpNgayGio = new DateTimePicker();
            txtTenBenhNhan = new TextBox();
            btnDatLich = new Button();
            lstLichHen = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dtpNgayGio
            // 
            dtpNgayGio.Location = new Point(469, 49);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(250, 27);
            dtpNgayGio.TabIndex = 0;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(469, 123);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(250, 27);
            txtTenBenhNhan.TabIndex = 1;
            // 
            // btnDatLich
            // 
            btnDatLich.Location = new Point(514, 200);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(158, 98);
            btnDatLich.TabIndex = 2;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(12, 12);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(254, 404);
            lstLichHen.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 49);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Ngày hẹn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Họ tên:";
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstLichHen);
            Controls.Add(btnDatLich);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(dtpNgayGio);
            Name = "frmLichHen";
            Text = "frmLichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayGio;
        private TextBox txtTenBenhNhan;
        private Button btnDatLich;
        private ListBox lstLichHen;
        private Label label1;
        private Label label2;
    }
}