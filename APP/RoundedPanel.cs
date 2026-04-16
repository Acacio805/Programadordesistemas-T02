using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RPanel
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                float radius = CornerRadius;
                float diameter = radius * 2;
                RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

                path.StartFigure();
                // Top Left Arc
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                // Top Right Arc
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                // Bottom Right Arc
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                // Bottom Left Arc
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                // Set the region of the panel so it actually clips children
                this.Region = new Region(path);
            }
        }
    }
}