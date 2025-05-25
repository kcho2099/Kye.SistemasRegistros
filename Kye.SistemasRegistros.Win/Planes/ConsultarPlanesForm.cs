using Kye.SistemasRegistros.CasosUso.Planes;
using Kye.SistemasRegistros.Entities;

namespace Kye.SistemasRegistros.Win.Planes;

public partial class ConsultarPlanesForm : Form
{
    ConsultarPlanes _consultarPlanes;
    Navegacion _navegacion;

    public ConsultarPlanesForm(ConsultarPlanes consultarPlanes, Navegacion navegacion)
    {
        InitializeComponent();
        _consultarPlanes = consultarPlanes;
        dgvPlanes.AutoGenerateColumns = false;
        _navegacion = navegacion;
    }

    private async void btnBuscar_Click(object sender, EventArgs e)
    {

        var consulta = await _consultarPlanes.Get(txtBuscar.Text);

        dgvPlanes.DataSource = consulta.Planes;

    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        _navegacion.Navegar<DashboardForm>(this);
    }

    private void ConsultarPlanesForm_Load(object sender, EventArgs e)
    {
        PasarClave.Clave = 0;

        dgvPlanes.Columns["NombrePlan"]!.DataPropertyName = "NombrePlan";
        dgvPlanes.Columns["CostoBase"]!.DataPropertyName = "CostoBase";
        dgvPlanes.Columns["DuracionMeses"]!.DataPropertyName = "DuracionMeses";
        dgvPlanes.Columns["TienePromocion"]!.DataPropertyName = "TienePromocion";
        dgvPlanes.Columns["FechaInicioPromocion"]!.DataPropertyName = "FechaInicioPromocion";
        dgvPlanes.Columns["FechaFinPromocion"]!.DataPropertyName = "FechaFinPromocion";
        dgvPlanes.Columns["TipoDescuento"]!.DataPropertyName = "TipoDescuento";
        dgvPlanes.Columns["ValorDescuento"]!.DataPropertyName = "ValorDescuento";
        dgvPlanes.Columns["IdPlan"]!.DataPropertyName = "IdPlan";

    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      Navegar<AgregarPlanesForm>();
    }

    private void Navegar<T>() where T : class
    {
        if (this.Parent != null)
        {
            _navegacion.Navegar<T>(this.Parent);
        }

        this.Close();
    }
}
