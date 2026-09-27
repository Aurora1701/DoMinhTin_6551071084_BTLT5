using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B4C4
{
    public partial class frmBenhNhan : Form
    {
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private List<string> danhSachBenhNhan = new List<string>();
        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            int tuoi = (int)numTuoi.Value;
            string trieuChung = txtTrieuChung.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string thongTin = $"{hoTen} - {tuoi} tuổi - {trieuChung}";
            danhSachBenhNhan.Add(thongTin);
            lstBenhNhan.Items.Add(thongTin);

            txtHoTen.Clear();
            txtTrieuChung.Clear();
            numTuoi.Value = numTuoi.Minimum;
            txtHoTen.Focus();
        }
    }
}
