using System.ComponentModel;

namespace Kye.SistemasRegistros.Win.Controles;

public class LineShape : Control
{
    private int lineWidth = 2;
    private Color lineColor = Color.FromArgb(67, 67, 67);

    [Category("Appearance")]
    [Description("Specifies the width of the line.")]
    [DefaultValue(1)]
    public int LineWidth
    {
        get => lineWidth;
        set
        {
            lineWidth = value;
            Invalidate(); // Redibuja el control al cambiar la propiedad
        }
    }

    [Category("Appearance")]
    [Description("Specifies the color of the line.")]
    [DefaultValue(typeof(Color), "Black")]
    public Color LineColor
    {
        get => lineColor;
        set
        {
            lineColor = value;
            Invalidate(); // Redibuja el control al cambiar la propiedad
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var pen = new Pen(LineColor, LineWidth))
        {
            // Dibuja una línea horizontal en el centro del control
            int y = this.Height / 2;
            e.Graphics.DrawLine(pen, 0, y, this.Width, y);
        }
    }

}
