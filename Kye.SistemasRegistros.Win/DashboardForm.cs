using Kye.SistemasRegistros.Win.MiembrosForms;
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
    public partial class DashboardForm : Form
    {
        BuscarMiembroForm _buscarMiembroForm;

        public DashboardForm(BuscarMiembroForm buscarMiembroForm)
        {
            this.SuspendLayout();

            InitializeComponent();
            _buscarMiembroForm = buscarMiembroForm;

            this.ResumeLayout();
        }

        private void BuscarMiembro_Click(object sender, EventArgs e)
        {
            _buscarMiembroForm.ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
