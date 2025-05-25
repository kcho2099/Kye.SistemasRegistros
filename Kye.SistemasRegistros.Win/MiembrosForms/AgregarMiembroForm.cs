using Kye.SistemasRegistros.CasosUso.Contactos;
using Kye.SistemasRegistros.CasosUso.Miembros;
using Kye.SistemasRegistros.CasosUso.Planes;
using Kye.SistemasRegistros.DTO.Contactos;
using Kye.SistemasRegistros.DTO.Membresias;
using Kye.SistemasRegistros.DTO.Miembros;
using Kye.SistemasRegistros.Entities;

namespace Kye.SistemasRegistros.Win.MiembrosForms;

public partial class AgregarMiembroForm : Form
{
    private readonly AgregarMiembro _agregarMiembro;
    private readonly BuscarMiembroByStringEmpty _buscarMiembroByStringEmpty;
    private readonly AddContacto _agregarContacto;
    private readonly ConsultarContactos _consultarContactos;
    private readonly IServiceProvider _serviceProvider;
    private readonly EliminarContacto _eliminarContacto;
    private readonly ActualizarMiembro _actualizarMiembro;
    private readonly Navegacion _navegacion;
    private readonly BuscarMiembroByNombreId _buscarMiembroByNombreId;
    private readonly ConsultarPlanes _consultarPlanes;
    private readonly AgregarMembresia _agregarMembresia;

    public AgregarMiembroForm(AgregarMiembro agregarMiembro,
        IServiceProvider serviceProvider,
        BuscarMiembroByStringEmpty buscarMiembroByStringEmpty,
        ConsultarContactos consultarContactos,
        AddContacto addContacto,
        EliminarContacto eliminarContacto,
        ActualizarMiembro actualizarMiembro,
        BuscarMiembroByNombreId buscarMiembroByNombreId,
        Navegacion navegacion,
        ConsultarPlanes consultarPlanes,
        AgregarMembresia agregarMembresia
        )

    {
        this.Text = Entities.Resources.Textos.Miembros;
        InitializeComponent();
        _agregarMiembro = agregarMiembro;
        _serviceProvider = serviceProvider;
        _buscarMiembroByStringEmpty = buscarMiembroByStringEmpty;
        _agregarContacto = addContacto;
        _consultarContactos = consultarContactos;
        _eliminarContacto = eliminarContacto;
        _actualizarMiembro = actualizarMiembro;
        _navegacion = navegacion;
        _buscarMiembroByNombreId = buscarMiembroByNombreId;
        _consultarPlanes = consultarPlanes;
        _agregarMembresia = agregarMembresia;
    }

    private async void AgregarMiembroForm_Load(object sender, EventArgs e)
    {

        dgvContactos.AutoGenerateColumns = false;

        dgvContactos.Columns["IdEmergencia"]!.DataPropertyName = "IdEmergencia";
        dgvContactos.Columns["NombreContacto"]!.DataPropertyName = "NombreContacto";
        dgvContactos.Columns["Parentesco"]!.DataPropertyName = "Parentesco";
        dgvContactos.Columns["TelefonoContacto"]!.DataPropertyName = "TelefonoContacto";

        pcFoto.Load("IconosApplicacion\\imagen_nueva.png");
        pcFoto.SizeMode = PictureBoxSizeMode.CenterImage;


        if (PasarClave.Clave == 0)
        {
            var query = await _buscarMiembroByStringEmpty.Buscar(string.Empty);

            if (query is null)
            {
                var cliente = new AddMiembrosDTO
                {
                    Celular = string.Empty,
                    CorreoElectronico = string.Empty,
                    FechaNacimiento = null,
                    FechaRegistro = DateTime.Now,
                    Fotografia = string.Empty,
                    Idhuella = null,
                    IdUsuarioRegistro = SesionUsuario.IdUsuario,
                    NombreCompleto = string.Empty,
                    WhatsApp = string.Empty
                };

                var result = await _agregarMiembro.Add(cliente);
                txtClave.Text = result.Cliente.Idmiembro.ToString();
            }
            else
            {
                txtClave.Text = query.Idmiembro.ToString();
                txtNombreCompleto.Text = query.NombreCompleto;
                txtEmail.Text = query.CorreoElectronico;
                txtTelefono.Text = query.Celular;
                txtWhatsApp.Text = query.WhatsApp;
                txtFechaNacimiento.Text = string.Empty;
            }
        }
        else
        {
            var query = await _buscarMiembroByNombreId.Buscar(PasarClave.Clave.ToString());

            txtClave.Text = query.miembro.Idmiembro.ToString();
            txtNombreCompleto.Text = query.miembro.NombreCompleto;
            txtEmail.Text = query.miembro.CorreoElectronico;
            txtTelefono.Text = query.miembro.Celular;
            txtWhatsApp.Text = query.miembro.WhatsApp;
            txtFechaNacimiento.Text = query.miembro.FechaNacimiento?.ToString("dd/MM/yyyy");
            var fotoPath = query.miembro.Fotografia;
            if (File.Exists(fotoPath))
            {
                pcFoto.Load(fotoPath);
            }

        }

        var claveMiembro = int.TryParse(txtClave.Text, out _) ? int.Parse(txtClave.Text) : 0;
        var contactos = await _consultarContactos.Get(claveMiembro);
        dgvContactos.DataSource = contactos.Contactos;



        var planes = await _consultarPlanes.Get(string.Empty);

        cmbPlan.DataSource = planes.Planes;
        cmbPlan.ValueMember = "IdPlan";
        cmbPlan.DisplayMember = "NombrePlan";

    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(txtNombreCompleto.Text))
        {
            errorProvider1.SetError(txtNombreCompleto, "El nombre es requerido");
            return;
        }

        if (string.IsNullOrEmpty(txtTelefono.Text))
        {
            errorProvider1.SetError(txtNombreCompleto, "El telefono es requerido");
            return;
        }

        if (string.IsNullOrEmpty(txtFechaNacimiento.Text))
        {
            errorProvider1.SetError(txtNombreCompleto, "La fecha nacimiento es requerido");
            return;
        }

        DateTime? fechaNacimiento = null;
        if (DateTime.TryParseExact(txtFechaNacimiento.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
            fechaNacimiento = parsedDate;
        }

        var actualizar = await _actualizarMiembro.Update(new DTO.UpdateMiembroDTO
        {
            Celular = txtTelefono.Text,
            WhatsApp = txtWhatsApp.Text,
            CorreoElectronico = txtEmail.Text,
            FechaNacimiento = fechaNacimiento,
            Fotografia = string.Empty,
            Id = int.Parse(txtClave.Text),
            Idhuella = null,
            NombreCompleto = txtNombreCompleto.Text
        });

        var Membresia = _agregarMembresia.Add(new AddMrembresiaDTO
        {
            IdMiembro = PasarClave.Clave,
            IdPlan = (int)cmbPlan.SelectedValue,
            FechaInicio = DateTime.Now,
            FechaProximoPago= DateTime.Now.AddMonths(1),
            FechaFin = null
        });

        if (!actualizar.accion)
        {
            MessageBox.Show(actualizar.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show(actualizar.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        Salir();

    }

    private void Salir()
    {
        if (this.Parent != null)
        {
            _navegacion.Navegar<ConsultaClientesForm>(this.Parent);
        }

        this.Close();
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Salir();
    }

    private void txtTelefono_TextChanged(object sender, EventArgs e)
    {
        var txt = (TextBox)sender;

        if (!long.TryParse(txt.Text, out _) && txt.Text.Length > 0)
        {
            txt.Text = txt.Text.Remove(txt.Text.Length - 1);
            txt.SelectionStart = txt.Text.Length;
        }

        if (string.IsNullOrWhiteSpace(txtWhatsApp.Text) && txt.TextLength == 10)
        {
            txtWhatsApp.Text = txt.Text;
        }
    }

    private void pcFoto_DoubleClick(object sender, EventArgs e)
    {

    }

    private async void btnAgregar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNombreContacto.Text))
        {
            errorProvider1.SetError(txtNombreContacto, "El nombre es requerido"); return;
        }

        if (string.IsNullOrEmpty(txtTelefonoContacto.Text))
        {
            errorProvider1.SetError(txtTelefonoContacto, "El telefono es requerido"); return;
        }
        var parentesco = cmbParentesco.SelectedItem as string;
        if (string.IsNullOrEmpty(parentesco))
        {
            errorProvider1.SetError(cmbParentesco, "El parentesco es requerido"); return;
        }

        var claveMiembro = int.TryParse(txtClave.Text, out _) ? int.Parse(txtClave.Text) : 0;

        await _agregarContacto.Add(new AgregarContactosDTO
        {
            Idmiembro = claveMiembro,
            NombreContacto = txtNombreContacto.Text,
            Parentesco = parentesco,
            TelefonoContacto = txtTelefonoContacto.Text
        });

        txtNombreContacto.Text = string.Empty;
        txtTelefonoContacto.Text = string.Empty;
        cmbParentesco.SelectedIndex = -1;

        var contactos = await _consultarContactos.Get(claveMiembro);

        if (contactos.Accion)
        {
            dgvContactos.DataSource = contactos.Contactos;
        }

    }

    private async void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvContactos.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
        {
            var cellValue = dgvContactos.Rows[e.RowIndex].Cells[1].Value?.ToString();
            if (cellValue != null && int.TryParse(cellValue, out int id))
            {
                var result = MessageBox.Show("¿Desea eliminar el contacto?", "Eliminar contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var eliminar = await _eliminarContacto.Delete(id);

                    if (!eliminar.Accion)
                    {
                        MessageBox.Show(eliminar.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show(eliminar.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var claveMiembro = int.TryParse(txtClave.Text, out _) ? int.Parse(txtClave.Text) : 0;
                    var contactos = await _consultarContactos.Get(claveMiembro);
                    if (contactos.Accion)
                    {
                        dgvContactos.DataSource = contactos.Contactos;
                    }
                }
            }
            else
            {
                MessageBox.Show("El valor de la celda no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void txtTelefonoContacto_TextChanged(object sender, EventArgs e)
    {
        var txt = (TextBox)sender;

        if (!long.TryParse(txt.Text, out _) && txt.Text.Length > 0)
        {
            txt.Text = txt.Text.Remove(txt.Text.Length - 1);
            txt.SelectionStart = txt.Text.Length;
        }
    }

    private void btnAtras_MouseEnter(object sender, EventArgs e)
    {
        btnAtras.BackColor = Color.FromArgb(66, 66, 66);
    }

    private void btnAtras_MouseLeave(object sender, EventArgs e)
    {
        btnAtras.BackColor = Color.FromArgb(55, 55, 55);
    }

    private void txtWhatsApp_TextChanged(object sender, EventArgs e)
    {
        var txt = (TextBox)sender;

        if (!long.TryParse(txt.Text, out _) && txt.Text.Length > 0)
        {
            txt.Text = txt.Text.Remove(txt.Text.Length - 1);
            txt.SelectionStart = txt.Text.Length;
        }
    }
}
