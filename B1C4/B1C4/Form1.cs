namespace B1C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatThoiGianVaTrangThai();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGianVaTrangThai();
        }
        private void CapNhatThoiGianVaTrangThai()
        {
            DateTime bayGio = DateTime.Now;

            lblGioHienTai.Text = bayGio.ToString("HH:mm:ss");
            int gioHienTai = bayGio.Hour;
            if (gioHienTai >= 6 && gioHienTai < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }
        private void mnuDoiMauNen_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = cd.Color;
                }
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
