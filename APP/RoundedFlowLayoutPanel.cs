using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Rflp
{
    public class RoundedFlowLayoutPanel : FlowLayoutPanel
    {
        public int BorderRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                float radius = BorderRadius;
                RectangleF rect = new RectangleF(0, 0, this.Width - 1, this.Height - 1);

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path); // This clips the content inside the corners

                using (Pen pen = new Pen(Color.Gray, 1.0f)) // Optional: Draw a border
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}