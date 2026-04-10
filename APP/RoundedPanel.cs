using System;
using System.Drawing.Drawing2D;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 20; // Raio do canto

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = new GraphicsPath())
        {
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // Desenha os cantos arredondados
            path.AddArc(rect.X, rect.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(rect.Width - CornerRadius, rect.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(rect.Width - CornerRadius, rect.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path); // Aplica o formato ao painel

            // Desenha a borda (opcional)
            using (Pen pen = new Pen(Color.LightGray, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}