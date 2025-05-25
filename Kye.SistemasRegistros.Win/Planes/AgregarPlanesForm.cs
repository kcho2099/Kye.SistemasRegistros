using Kye.SistemasRegistros.CasosUso.Planes;
using Kye.SistemasRegistros.DTO.Planes;

namespace Kye.SistemasRegistros.Win.Planes;

public partial class AgregarPlanesForm : Form
{

    Navegacion _navegacion;
    AgregarPlanes _agregarPlanes;

    public AgregarPlanesForm(Navegacion navegacion, AgregarPlanes agregarPlanes)
    {
        InitializeComponent();
        _navegacion = navegacion;
        _agregarPlanes = agregarPlanes;
    }

    private void Navegar<T>() where T : class
    {
        if (this.Parent != null)
        {
            _navegacion.Navegar<T>(this.Parent);
        }

        this.Close();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Navegar<ConsultarPlanesForm>();
    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {
        var tienePromocion = cmbPromo.SelectedItem != null && cmbPromo.SelectedItem.ToString() == "SI";

        var resultado = await _agregarPlanes.Agregar(new PlanesDTO
        {
            NombrePlan = txtNombrePlan.Text,
            CostoBase = Convert.ToDecimal(txtCostoBase.Text),
            DescripcionPromocion = txtPromocion.Text,
            DuracionMeses = Convert.ToInt32(txtDuracionMeses.Text),
            FechaFinPromocion = !DateTime.TryParse(txtFechaFin.Text, out _) ? null : DateTime.Parse(txtFechaFin.Text),
            FechaInicioPromocion = !DateTime.TryParse(txtFechaInicio.Text, out _) ? null : DateTime.Parse(txtFechaInicio.Text),
            TienePromocion = tienePromocion,
            TipoDescuento = cmbTipoDescuento.SelectedItem?.ToString() ?? string.Empty, // Evita error si es null
            ValorDescuento = string.IsNullOrEmpty(txtDescuento.Text) ? (decimal?)null : Convert.ToDecimal(txtDescuento.Text),
        });

        if (!resultado.accion)
        {
            MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show(resultado.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);



        Navegar<ConsultarPlanesForm>();
    }
}
