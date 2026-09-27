namespace B2C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                if (string.IsNullOrEmpty(hoTen))
                {
                    txtHoTen.Focus();
                }
                else
                {
                    txtSDT.Focus();
                }
                return;
            }
            string goiTap = cboGoiTap.SelectedItem != null ? cboGoiTap.SelectedItem.ToString() : "Chưa chọn";
            decimal soBuoi = numSoBuoiTuan.Value;
            string thongTin = $"ĐĂNG KÝ HỘI VIÊN THÀNH CÔNG!\n\n" +
                              $"- Họ và tên: {hoTen}\n" +
                              $"- Số điện thoại: {sdt}\n" +
                              $"- Gói tập: {goiTap}\n" +
                              $"- Số buổi/tuần: {soBuoi} buổi";

            MessageBox.Show(
                thongTin,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

