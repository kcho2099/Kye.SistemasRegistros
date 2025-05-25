namespace Kye.SistemasRegistros.Win.Planes
{
    partial class ConsultarPlanesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPlanesForm));
            btnAgregar = new Button();
            btnAtras = new PictureBox();
            dgvPlanes = new DataGridView();
            NombrePlan = new DataGridViewTextBoxColumn();
            CostoBase = new DataGridViewTextBoxColumn();
            DuracionMeses = new DataGridViewTextBoxColumn();
            TienePromocion = new DataGridViewTextBoxColumn();
            FechaInicioPromocion = new DataGridViewTextBoxColumn();
            FechaFinPromocion = new DataGridViewTextBoxColumn();
            TipoDescuento = new DataGridViewTextBoxColumn();
            ValorDescuento = new DataGridViewTextBoxColumn();
            lblBuscar = new Label();
            btnBuscar = new Button();
            lineShape1 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            txtBuscar = new Kye.SistemasRegistros.Win.Controles.TextBoxSistema();
            IdPlan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Location = new Point(1058, 19);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(26, 30);
            btnAtras.SizeMode = PictureBoxSizeMode.Zoom;
            btnAtras.TabIndex = 13;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // dgvPlanes
            // 
            dgvPlanes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Columns.AddRange(new DataGridViewColumn[] { NombrePlan, CostoBase, DuracionMeses, TienePromocion, FechaInicioPromocion, FechaFinPromocion, TipoDescuento, ValorDescuento, IdPlan });
            dgvPlanes.Location = new Point(12, 104);
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.Size = new Size(1121, 845);
            dgvPlanes.TabIndex = 14;
            // 
            // NombrePlan
            // 
            NombrePlan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombrePlan.HeaderText = "Nombre Plan";
            NombrePlan.Name = "NombrePlan";
            NombrePlan.ReadOnly = true;
            // 
            // CostoBase
            // 
            CostoBase.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CostoBase.HeaderText = "Costo Base";
            CostoBase.Name = "CostoBase";
            CostoBase.ReadOnly = true;
            // 
            // DuracionMeses
            // 
            DuracionMeses.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DuracionMeses.HeaderText = "Duracion Meses";
            DuracionMeses.Name = "DuracionMeses";
            // 
            // TienePromocion
            // 
            TienePromocion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TienePromocion.HeaderText = "Tiene Promocion";
            TienePromocion.Name = "TienePromocion";
            TienePromocion.ReadOnly = true;
            // 
            // FechaInicioPromocion
            // 
            FechaInicioPromocion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaInicioPromocion.HeaderText = "Fecha Inicio";
            FechaInicioPromocion.Name = "FechaInicioPromocion";
            FechaInicioPromocion.ReadOnly = true;
            // 
            // FechaFinPromocion
            // 
            FechaFinPromocion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaFinPromocion.HeaderText = "Fecha Fin";
            FechaFinPromocion.Name = "FechaFinPromocion";
            FechaFinPromocion.ReadOnly = true;
            // 
            // TipoDescuento
            // 
            TipoDescuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoDescuento.HeaderText = "Tipo Descuento";
            TipoDescuento.Name = "TipoDescuento";
            TipoDescuento.ReadOnly = true;
            // 
            // ValorDescuento
            // 
            ValorDescuento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ValorDescuento.HeaderText = "Valor Descuento";
            ValorDescuento.Name = "ValorDescuento";
            ValorDescuento.ReadOnly = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Silver;
            lblBuscar.Location = new Point(379, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(0, 19);
            lblBuscar.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.BackColor = Color.FromArgb(51, 80, 196);
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 14F);
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(757, 41);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 41);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lineShape1
            // 
            lineShape1.Anchor = AnchorStyles.Top;
            lineShape1.LineColor = Color.FromArgb(71, 71, 71);
            lineShape1.LineWidth = 2;
            lineShape1.Location = new Point(379, 79);
            lineShape1.Name = "lineShape1";
            lineShape1.Size = new Size(357, 10);
            lineShape1.TabIndex = 16;
            lineShape1.Text = "lineShape1";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.BackColor = Color.FromArgb(55, 55, 55);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 18F);
            txtBuscar.ForeColor = Color.Snow;
            txtBuscar.Location = new Point(396, 41);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ingresa nombre o clave";
            txtBuscar.Size = new Size(323, 32);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // IdPlan
            // 
            IdPlan.HeaderText = "IdPlan";
            IdPlan.Name = "IdPlan";
            IdPlan.ReadOnly = true;
            IdPlan.Visible = false;
            // 
            // ConsultarPlanesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(1145, 961);
            Controls.Add(lblBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lineShape1);
            Controls.Add(txtBuscar);
            Controls.Add(dgvPlanes);
            Controls.Add(btnAtras);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultarPlanesForm";
            Text = "ConsultarPlanesForm";
            Load += ConsultarPlanesForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private PictureBox btnAtras;
        private DataGridView dgvPlanes;
        private Label lblBuscar;
        private Button btnBuscar;
        private Controles.LineShape lineShape1;
        private Controles.TextBoxSistema txtBuscar;
        private DataGridViewTextBoxColumn NombrePlan;
        private DataGridViewTextBoxColumn CostoBase;
        private DataGridViewTextBoxColumn DuracionMeses;
        private DataGridViewTextBoxColumn TienePromocion;
        private DataGridViewTextBoxColumn FechaInicioPromocion;
        private DataGridViewTextBoxColumn FechaFinPromocion;
        private DataGridViewTextBoxColumn TipoDescuento;
        private DataGridViewTextBoxColumn ValorDescuento;
        private DataGridViewTextBoxColumn IdPlan;
    }
}