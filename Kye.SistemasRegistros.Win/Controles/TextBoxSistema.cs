using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace Kye.SistemasRegistros.Win.Controles;

public class TextBoxSistema : TextBox
{
    public TextBoxSistema()
    {
        TextAlign = HorizontalAlignment.Left;
        Font = new Font("Segoe UI", 18F);
        BackColor = Color.FromArgb(55, 55, 55);
        BorderStyle = BorderStyle.None;
        
    }

    private const int EM_SETRECT = 0xB2;
    private const int WM_PAINT = 0xF;

    [StructLayout(LayoutKind.Sequential)]
    private struct RECT
    {
        public int Left, Top, Right, Bottom;
    }

    [DllImport("user32.dll")]
    private static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, ref RECT lpRect);

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == WM_PAINT)
        {
            if (Multiline)
            {
                // Calcula el alto del texto
                Size textSize = TextRenderer.MeasureText(Text, Font);
                // Obtiene el rectángulo del cliente
                GetClientRect(Handle, out RECT rect);
                // Centra verticalmente el texto
                int topMargin = (ClientSize.Height - textSize.Height) / 2;
                rect.Top = topMargin;
                // Actualiza el rectángulo de dibujo
                SendMessage(Handle, EM_SETRECT, IntPtr.Zero, ref rect);
            }
        }
    }
}
