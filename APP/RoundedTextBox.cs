using System;
using System.Drawing.Drawing2D;

public class RoundedTextBox : TextBox
{
    // Adjust this to change how round the corners are
    public int BorderRadius { get; set; } = 5;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        GraphicsPath path = new GraphicsPath();
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        int d = BorderRadius * 2;
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        this.Region = new Region(path);

        // Optional: Draw a custom border to make it look cleaner
        //using (Pen pen = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize))
        //{
        //    pen.Alignment = PenAlignment.Inset;
        //    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //    pevent.Graphics.DrawPath(pen, path);
        //}
    }
}
