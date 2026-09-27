namespace B3C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmsCongViec_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string congViec = txtCongViecMoi.Text.Trim();

            if (!string.IsNullOrEmpty(congViec))
            {
                lstCongViec.Items.Add(congViec);
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void mnuDanhDauHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                int index = lstCongViec.SelectedIndex;
                string itemHienTai = lstCongViec.SelectedItem.ToString();
                string tienTo = "[Hoàn thành] ";

                if (!itemHienTai.StartsWith(tienTo))
                {
                    lstCongViec.Items[index] = tienTo + itemHienTai;
                }
            }
        }

        private void mnuXoaCongViecNay_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn công việc cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ danh sách công việc không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
