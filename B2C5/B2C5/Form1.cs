using System.Drawing.Drawing2D;

namespace B2C5
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point diemTruoc;
        private Bitmap bmp;
        private Graphics gBmp;
        private Pen penVe;
        public Form1()
        {
            InitializeComponent();

            penVe = new Pen(Color.Black, 2f);
            penVe.StartCap = LineCap.Round;
            penVe.EndCap = LineCap.Round;

            bmp = new Bitmap(pnlCanvas.Width, pnlCanvas.Height);
            gBmp = Graphics.FromImage(bmp);
            gBmp.Clear(Color.White);
            gBmp.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                diemTruoc = e.Location;
                CapNhatThongTin(e.X, e.Y);
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            CapNhatThongTin(e.X, e.Y);

            if (isDrawing && e.Button == MouseButtons.Left)
            {
                gBmp.DrawLine(penVe, diemTruoc, e.Location);
                diemTruoc = e.Location;
                pnlCanvas.Invalidate();
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                CapNhatThongTin(e.X, e.Y);
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gBmp.Clear(Color.White);
                pnlCanvas.Invalidate();
                isDrawing = false;
                CapNhatThongTin(e.X, e.Y);
            }
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void CapNhatThongTin(int x, int y)
        {
            string trangThai = isDrawing ? "Đang vẽ..." : "Sẵn sàng";
            lblViTri.Text = $"Trạng thái: {trangThai} | Tọa độ: X = {x}, Y = {y}";
        }
    }
}
