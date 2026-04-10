using System;
using System.Drawing.Drawing2D;

namespace GPanel
{
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }

        public Color BottomColor { get; set; }

        public float Angle { get; set; }
        
        public GradientPanel()
        {
            this.BackColor = Color.White; // Cor padrão
        }
        public int _cornerRadius { get; set; } // Raio do canto

        public int CornerRadius { get; set; } = 0;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush =
                new LinearGradientBrush(this.ClientRectangle,
                                        TopColor,
                                        BottomColor,
                                        Angle))
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
