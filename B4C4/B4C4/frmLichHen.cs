using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B4C4
{
    public partial class frmLichHen : Form
    {
        public frmLichHen()
        {
            InitializeComponent();
        }
        private List<string> danhSachLichHen = new List<string>();

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string ten = txtTenBenhNhan.Text.Trim();
            string thoiGian = dtpNgayGio.Value.ToString("dd/MM/yyyy HH:mm");

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBenhNhan.Focus();
                return;
            }

            string thongTinHen = $"{thoiGian} - BN: {ten}";
            danhSachLichHen.Add(thongTinHen);
            lstLichHen.Items.Add(thongTinHen);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
