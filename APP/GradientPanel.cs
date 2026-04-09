using System;
using System.Drawing.Drawing2D;

namespace GPanel
{
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }

        public Color BottomColor { get; set; }

        public float Angle { get; set; }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    LinearGradientBrush brush=new LinearGradientBrush(this.ClientRectangle,this.TopColor,this.BottomColor,this.Angle);
        //    Graphics g = e.Graphics;
        //    g.FillRectangle(brush, this.ClientRectangle);
        //    base.OnPaint(e);
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            // Force the form to redraw its background
            this.Invalidate();
        }
    }
}
