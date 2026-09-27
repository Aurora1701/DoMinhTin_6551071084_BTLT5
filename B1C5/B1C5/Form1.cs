namespace B1C5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                e.Handled = true;
            }
        }
        private void txtChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuongStr = txtSoLuong.Text.Trim();
            string donGiaStr = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(soLuongStr) || string.IsNullOrEmpty(donGiaStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sản phẩm, Số lượng và Đơn giá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long soLuong = long.Parse(soLuongStr);
            decimal donGia = decimal.Parse(donGiaStr);
            decimal thanhTien = soLuong * donGia;

            string dongKetQua = $"{maSP} | SL: {soLuong} | Đơn giá: {donGia:#,##0} VNĐ | Thành tiền: {thanhTien:#,##0} VNĐ";
            lstKetQua.Items.Add(dongKetQua);
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }
    }
}
