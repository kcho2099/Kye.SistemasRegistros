using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.Win.Controles;

public class LineaSheapVertical:Control
{
    private int lineWidth = 2;
    private Color lineColor = Color.Black;

    [Category("Appearance")]
    [Description("Specifies the width of the line.")]
    [DefaultValue(2)]
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
            // Dibuja una línea vertical en el centro del control
            int x = Width / 2;
            e.Graphics.DrawLine(pen, x, 0, x, Height);
        }
    }
}
