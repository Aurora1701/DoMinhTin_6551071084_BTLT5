namespace B3C4
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
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            mnuDanhDauHoanThanh = new ToolStripMenuItem();
            mnuXoaCongViecNay = new ToolStripMenuItem();
            mnuXoaTatCa = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(108, 12);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(354, 27);
            txtCongViecMoi.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(503, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(214, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm công việc";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(108, 60);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(609, 364);
            lstCongViec.TabIndex = 2;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { mnuDanhDauHoanThanh, mnuXoaCongViecNay, mnuXoaTatCa });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(221, 76);
            cmsCongViec.Opening += cmsCongViec_Opening;
            // 
            // mnuDanhDauHoanThanh
            // 
            mnuDanhDauHoanThanh.Name = "mnuDanhDauHoanThanh";
            mnuDanhDauHoanThanh.Size = new Size(220, 24);
            mnuDanhDauHoanThanh.Text = "Đánh dấu hoàn thành";
            mnuDanhDauHoanThanh.Click += mnuDanhDauHoanThanh_Click;
            // 
            // mnuXoaCongViecNay
            // 
            mnuXoaCongViecNay.Name = "mnuXoaCongViecNay";
            mnuXoaCongViecNay.Size = new Size(220, 24);
            mnuXoaCongViecNay.Text = "Xóa công việc này";
            mnuXoaCongViecNay.Click += mnuXoaCongViecNay_Click;
            // 
            // mnuXoaTatCa
            // 
            mnuXoaTatCa.Name = "mnuXoaTatCa";
            mnuXoaTatCa.Size = new Size(220, 24);
            mnuXoaTatCa.Text = "Xóa tất cả";
            mnuXoaTatCa.Click += mnuXoaTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem mnuDanhDauHoanThanh;
        private ToolStripMenuItem mnuXoaCongViecNay;
        private ToolStripMenuItem mnuXoaTatCa;
    }
}
