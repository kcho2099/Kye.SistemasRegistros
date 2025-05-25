using Kye.SistemasRegistros.CasosUso.Contactos;
using Kye.SistemasRegistros.CasosUso.Miembros;
using Kye.SistemasRegistros.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Kye.SistemasRegistros.Win.MiembrosForms
{
    public partial class ConsultaClientesForm : Form
    {
        ConsultarMiembros _consultarMiembros;
        Navegacion _navegacion;
        EliminarMiembro _eliminarMiembro;


        public ConsultaClientesForm(ConsultarMiembros consultarMiembros, Navegacion navegacion, EliminarMiembro eliminarMiembro)
        {
            InitializeComponent();
            _consultarMiembros = consultarMiembros;
            dgvClientes.AutoGenerateColumns = false;
            _navegacion = navegacion;
            _eliminarMiembro = eliminarMiembro;
        }

        private async void ConsultaClientesForm_Load(object sender, EventArgs e)
        {
            PasarClave.Clave = 0;

            dgvClientes.Columns["IdMiembro"]!.DataPropertyName = "Clave";
            dgvClientes.Columns["NombreCompleto"]!.DataPropertyName = "NombreCompleto";
            dgvClientes.Columns["Celular"]!.DataPropertyName = "Celular";
            dgvClientes.Columns["WhatsApp"]!.DataPropertyName = "WhatsApp";
            dgvClientes.Columns["CorreoElectronico"]!.DataPropertyName = "CorreoElectronico";
            dgvClientes.Columns["FechaNacimiento"]!.DataPropertyName = "FechaNacimiento";
            dgvClientes.Columns["FechaRegistro"]!.DataPropertyName = "FechaRegistro";
            dgvClientes.Columns["MembresiaAtual"]!.DataPropertyName = "NombrePlan";

            dgvClientes.DataSource = await _consultarMiembros.ConsultarClientes(string.Empty);
        }

        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgvClientes.Rows[e.RowIndex].Cells["IdMiembro"].Value?.ToString();
                int idMiembro = int.TryParse(cellValue, out _) ? int.Parse(cellValue) : 0;

                if (dgvClientes.Columns[e.ColumnIndex].Name == "Actualizar")
                {
                    PasarClave.Clave = idMiembro;
                    Navegar<AgregarMiembroForm>();
                }
                else if (dgvClientes.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Llamar al método de eliminación
                    var result = MessageBox.Show("¿Desea eliminar el cliente?", "Eliminar contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var eliminar = await _eliminarMiembro.Eliminar(idMiembro);

                        if (!eliminar.Accion)
                        {
                            MessageBox.Show(eliminar.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        MessageBox.Show(eliminar.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        var contactos = await _consultarMiembros.ConsultarClientes(txtBuscar.Text);
                        dgvClientes.DataSource = contactos;


                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Navegar<AgregarMiembroForm>();
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
            Navegar<DashboardForm>();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = await _consultarMiembros.ConsultarClientes(txtBuscar.Text);
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnAtras_MouseEnter(object sender, EventArgs e)
        {
            btnAtras.BackColor = Color.FromArgb(66, 66, 66);
        }

        private void btnAtras_MouseLeave(object sender, EventArgs e)
        {
            btnAtras.BackColor = Color.FromArgb(55, 55, 55);
        }
    }
}
