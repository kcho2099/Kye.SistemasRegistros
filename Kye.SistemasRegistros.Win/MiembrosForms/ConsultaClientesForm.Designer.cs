namespace Kye.SistemasRegistros.Win.MiembrosForms
{
    partial class ConsultaClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientesForm));
            dgvClientes = new DataGridView();
            Actualizar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            IdMiembro = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            WhatsApp = new DataGridViewTextBoxColumn();
            CorreoElectronico = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            MembresiaAtual = new DataGridViewTextBoxColumn();
            txtBuscar = new Kye.SistemasRegistros.Win.Controles.TextBoxSistema();
            lineShape1 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            btnAtras = new PictureBox();
            btnNuevo = new Button();
            lblBuscar = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = Color.FromArgb(55, 55, 55);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Actualizar, Eliminar, IdMiembro, NombreCompleto, Celular, WhatsApp, CorreoElectronico, FechaNacimiento, FechaRegistro, MembresiaAtual });
            dgvClientes.GridColor = Color.Black;
            dgvClientes.Location = new Point(12, 133);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Size = new Size(1105, 777);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // Actualizar
            // 
            Actualizar.HeaderText = "";
            Actualizar.Image = (Image)resources.GetObject("Actualizar.Image");
            Actualizar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Actualizar.Name = "Actualizar";
            Actualizar.Resizable = DataGridViewTriState.True;
            Actualizar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IdMiembro
            // 
            IdMiembro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IdMiembro.HeaderText = "Clave";
            IdMiembro.Name = "IdMiembro";
            IdMiembro.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Celular
            // 
            Celular.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Celular.HeaderText = "Telefono";
            Celular.Name = "Celular";
            Celular.ReadOnly = true;
            // 
            // WhatsApp
            // 
            WhatsApp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WhatsApp.HeaderText = "WhatsApp";
            WhatsApp.Name = "WhatsApp";
            WhatsApp.ReadOnly = true;
            // 
            // CorreoElectronico
            // 
            CorreoElectronico.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CorreoElectronico.HeaderText = "Correo Electronico";
            CorreoElectronico.Name = "CorreoElectronico";
            CorreoElectronico.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaNacimiento.HeaderText = "Fecha Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // MembresiaAtual
            // 
            MembresiaAtual.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MembresiaAtual.HeaderText = "Membresia Actual";
            MembresiaAtual.Name = "MembresiaAtual";
            MembresiaAtual.ReadOnly = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.BackColor = Color.FromArgb(55, 55, 55);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 18F);
            txtBuscar.ForeColor = Color.Snow;
            txtBuscar.Location = new Point(398, 65);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingresa nombre o clave";
            txtBuscar.Size = new Size(323, 32);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // lineShape1
            // 
            lineShape1.Anchor = AnchorStyles.Top;
            lineShape1.LineColor = Color.FromArgb(71, 71, 71);
            lineShape1.LineWidth = 2;
            lineShape1.Location = new Point(381, 103);
            lineShape1.Name = "lineShape1";
            lineShape1.Size = new Size(357, 10);
            lineShape1.TabIndex = 2;
            lineShape1.Text = "lineShape1";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(26, 30);
            btnAtras.SizeMode = PictureBoxSizeMode.Zoom;
            btnAtras.TabIndex = 10;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            btnAtras.MouseEnter += btnAtras_MouseEnter;
            btnAtras.MouseLeave += btnAtras_MouseLeave;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(51, 196, 80);
            btnNuevo.BackgroundImageLayout = ImageLayout.None;
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.Font = new Font("Segoe UI", 14F);
            btnNuevo.ForeColor = Color.Snow;
            btnNuevo.Location = new Point(1019, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 41);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Silver;
            lblBuscar.Location = new Point(381, 47);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(0, 19);
            lblBuscar.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.BackColor = Color.FromArgb(51, 80, 196);
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 14F);
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(759, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 41);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            // 
            // ConsultaClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(1129, 922);
            Controls.Add(lblBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnNuevo);
            Controls.Add(btnAtras);
            Controls.Add(lineShape1);
            Controls.Add(txtBuscar);
            Controls.Add(dgvClientes);
            Name = "ConsultaClientesForm";
            Text = "ConsultaClientesForm";
            Load += ConsultaClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Controles.TextBoxSistema txtBuscar;
        private Controles.LineShape lineShape1;
        private PictureBox btnAtras;
        private Button btnNuevo;
        private Label lblBuscar;
        private Button btnBuscar;
        private DataGridViewImageColumn Actualizar;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewTextBoxColumn IdMiembro;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn WhatsApp;
        private DataGridViewTextBoxColumn CorreoElectronico;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn MembresiaAtual;
    }
}