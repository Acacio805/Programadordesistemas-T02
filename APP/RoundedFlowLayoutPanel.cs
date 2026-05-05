using Microsoft.Office.Interop.Excel;
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
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                float radius = BorderRadius;
                path.StartFigure();
                // Top Left
                path.AddArc(0, 0, radius, radius, 180, 90);
                // Top Right
                path.AddArc(Width - radius, 0, radius, radius, 270, 90);
                // Bottom Right
                path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
                // Bottom Left
                path.AddArc(0, Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                // Set the panel's region to this path to clip the background
                this.Region = new Region(path);

                //using (Pen pen = new Pen(Color.Gray, 1.0f)) // Optional: Draw a border
                //{
                //   e.Graphics.DrawPath(pen, path);
                //}
            }
        }
    }
}