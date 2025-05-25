using Kye.SistemasRegistros.CasosUso.Miembros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kye.SistemasRegistros.Win
{
    public partial class BuscarMiembroForm : Form
    {
        BuscarMiembroByNombreId _buscarMiembroByNombreId;

        public BuscarMiembroForm(BuscarMiembroByNombreId buscarMiembroByNombreId)
        {
            InitializeComponent();
            _buscarMiembroByNombreId = buscarMiembroByNombreId;
        }

        private void BuscarMiembroForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var miembro = await _buscarMiembroByNombreId.Buscar(txtBuscar.Text);
            if (miembro.accion)
            {
                pictureBox1.LoadAsync($"|DataDirectory|\\FotosMiembros\\{miembro.miembro.Fotografia}");
                this.Cursor = Cursors.Default;
                return;
            }
            this.Cursor = Cursors.Default;

            MessageBox.Show("Error cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            pictureBox1.Image = null;
            this.Close();
        }

        private void btnAtras_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAtras_MouseLeave(object sender, EventArgs e)
        {
            btnAtras.BackColor = Color.FromArgb(37, 37, 37);
        }

        private void btnAtras_MouseEnter(object sender, EventArgs e)
        {
            btnAtras.BackColor = Color.FromArgb(66, 66, 66);
        }
    }
}
