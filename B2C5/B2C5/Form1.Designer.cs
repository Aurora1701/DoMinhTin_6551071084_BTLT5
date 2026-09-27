namespace B2C5
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
            pnlCanvas = new Panel();
            lblViTri = new Label();
            pnlCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Controls.Add(lblViTri);
            pnlCanvas.Dock = DockStyle.Top;
            pnlCanvas.Location = new Point(0, 0);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(800, 447);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViTri.Location = new Point(239, 417);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(354, 23);
            lblViTri.TabIndex = 0;
            lblViTri.Text = " Trạng thái: Sẵn sàng | Tọa độ: X = 0, Y = 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCanvas);
            Name = "Form1";
            Text = "Form1";
            pnlCanvas.ResumeLayout(false);
            pnlCanvas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCanvas;
        private Label lblViTri;
    }
}
