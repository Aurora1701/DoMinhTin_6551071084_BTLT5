namespace B4C4
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }
        private void mnuThongTinBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan f = new frmBenhNhan();
            f.MdiParent = this;
            f.Show();
        }
        private void mnuDatLichHen_Click(object sender, EventArgs e)
        {
            frmLichHen f = new frmLichHen();
            f.MdiParent = this;
            f.Show();
        }
    }
}
