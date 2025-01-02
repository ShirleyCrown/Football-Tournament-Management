using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

public class RoundedButton : Button
{
    private int borderRadius = 20;
    private int borderSize = 2;
    private Color borderColor = Color.Black;

    public int BorderRadius
    {
        get => borderRadius;
        set { borderRadius = value; this.Invalidate(); }
    }
    public int BorderSize
    {
        get => borderSize;
        set { borderSize = value; this.Invalidate(); }
    }
    public Color BorderColor
    {
        get => borderColor;
        set { borderColor = value; this.Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = GetFigurePath())
        using (Pen pen = new Pen(borderColor, Math.Max(1, borderSize)))
        {
            this.Region = new Region(path);

            g.FillPath(new SolidBrush(this.BackColor), path);

            if (borderSize > 0)
            {
                pen.Alignment = PenAlignment.Inset;
                g.DrawPath(pen, path);
            }
        }

        TextRenderer.DrawText(
            g,
            this.Text,
            this.Font,
            this.ClientRectangle,
            this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }

    private GraphicsPath GetFigurePath()
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = Math.Max(0, borderRadius * 2F - 1);

        path.StartFigure();
        path.AddArc(0, 0, curveSize, curveSize, 180, 90);
        path.AddArc(this.Width - curveSize - 1, 0, curveSize, curveSize, 270, 90);
        path.AddArc(this.Width - curveSize - 1, this.Height - curveSize - 1, curveSize, curveSize, 0, 90);
        path.AddArc(0, this.Height - curveSize - 1, curveSize, curveSize, 90, 90);
        path.CloseFigure();

        return path;
    }
}
