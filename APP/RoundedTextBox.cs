using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rtxt
{
    public class RoundedTextBox : UserControl
    {
        private int borderRadius = 15;
        private Color borderColor = Color.Gray;
        private TextBox textBox1 = new TextBox();

        public RoundedTextBox()
        {
            this.DoubleBuffered = true;
            this.Padding = new Padding(10, 7, 10, 7); // Space for the rounded border
            this.Size = new Size(250, 30);

            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            this.Controls.Add(textBox1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = GetFigurePath(this.ClientRectangle, borderRadius))
            using (Pen pen = new Pen(borderColor, 1))
            {
                this.Region = new Region(path); // Cuts the corners of the control
                graph.DrawPath(pen, path);      // Draws the border
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}