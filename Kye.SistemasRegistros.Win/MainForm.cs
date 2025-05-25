using Kye.SistemasRegistros.CasosUso.Usuarios;
using Kye.SistemasRegistros.Entities;
using Kye.SistemasRegistros.Win.MembresiasForms;
using Kye.SistemasRegistros.Win.MiembrosForms;
using Kye.SistemasRegistros.Win.Planes;
using Microsoft.Extensions.DependencyInjection;

namespace Kye.SistemasRegistros.Win;

public partial class MainForm : Form
{

    private readonly IServiceProvider _serviceProvider;
    private readonly AgregarUsuario _agregarUsuario;

    public MainForm(
        IServiceProvider serviceProvider,
        AgregarUsuario agregarUsuario
        )
    {
        InitializeComponent();

        // this.SuspendLayout();

        _serviceProvider = serviceProvider;

        HelperScoped.ScopeActual = _serviceProvider.CreateScope();
        HelperScoped.FormActual = HelperScoped.ScopeActual.ServiceProvider.GetRequiredService<DashboardForm>();

        _agregarUsuario = agregarUsuario;

        AbrirPanelHijo((Form)HelperScoped.FormActual);

        //this.ResumeLayout();

    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        await _agregarUsuario.Agregar(
            new DTO.Usuarios.AddUsuarioDTO
            {
                NombreUsuario = "JuanC",
                Password = "EmmaEda",
                Rol = "Administrador"
            });

        lblMiembros.Text = Entities.Resources.Textos.Miembros;
        lblMembresias.Text = Entities.Resources.Textos.Membresias;
        lblPlanes.Text = Entities.Resources.Textos.Planes;
        lblPagos.Text = Entities.Resources.Textos.Pagos;
        lblCheckIn.Text = Entities.Resources.Textos.Movimientos;
        lblBitacora.Text = Entities.Resources.Textos.Bitacora_Sistema;

        lblUsuario.Text = SesionUsuario.NombreUsuario;
        lblRol.Text = SesionUsuario.Rol;

        #region Menu Sahdows
        lblMiembros.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        lblMembresias.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        lblPlanes.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        lblPagos.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        lblCheckIn.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        lblBitacora.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        lblUsuario.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        lblRol.Padding = new Padding(left: 0, top: 0, right: pnlMenu.Width, bottom: 0);
        #endregion

    }

    private void AbrirPanelHijo(Form formHijo)
    {
        pnlBody.Controls.Clear();

        formHijo.TopLevel = false;
        formHijo.FormBorderStyle = FormBorderStyle.None;
        formHijo.Dock = DockStyle.Fill;

        pnlBody.Controls.Add(formHijo);
        pnlBody.Tag = formHijo;
        formHijo.BringToFront();
        formHijo.Show();
    }

    private void lblMiembros_Click_1(object sender, EventArgs e)
    {
        Form formHijo = (Form)HelperScoped.FormActual;

        if (formHijo != null)
        {
            pnlBody.Controls.Clear();
            formHijo.Dispose();
            HelperScoped.ScopeActual?.Dispose();
        }

        HelperScoped.ScopeActual = _serviceProvider.CreateScope();
        HelperScoped.FormActual = HelperScoped.ScopeActual.ServiceProvider.GetRequiredService<ConsultaClientesForm>();
        formHijo = (Form)HelperScoped.FormActual;

        AbrirPanelHijo(formHijo);
    }

    private void lblMiembros_MouseEnter(object sender, EventArgs e)
    {
        var lbl = (Label)sender;
        lbl.BackColor = Color.FromArgb(66, 66, 66);
    }

    private void lblMiembros_MouseLeave(object sender, EventArgs e)
    {
        var lbl = (Label)sender;
        lbl.BackColor = Color.FromArgb(55, 55, 55);
    }

    private void lblMembresias_Click(object sender, EventArgs e)
    {
        Form formHijo = (Form)HelperScoped.FormActual;

        if (formHijo != null)
        {
            pnlBody.Controls.Clear();
            formHijo.Dispose();
            HelperScoped.ScopeActual?.Dispose();
        }

        HelperScoped.ScopeActual = _serviceProvider.CreateScope();
        HelperScoped.FormActual = HelperScoped.ScopeActual.ServiceProvider.GetRequiredService<ConsultaMembresiasForm>();
        formHijo = (Form)HelperScoped.FormActual;

        AbrirPanelHijo(formHijo);
    }

    private void lblPlanes_Click(object sender, EventArgs e)
    {
        Form formHijo = (Form)HelperScoped.FormActual;

        if (formHijo != null)
        {
            pnlBody.Controls.Clear();
            formHijo.Dispose();
            HelperScoped.ScopeActual?.Dispose();
        }

        HelperScoped.ScopeActual = _serviceProvider.CreateScope();
        HelperScoped.FormActual = HelperScoped.ScopeActual.ServiceProvider.GetRequiredService<ConsultarPlanesForm>();
        formHijo = (Form)HelperScoped.FormActual;

        AbrirPanelHijo(formHijo);
    }

    
}
