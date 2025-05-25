namespace Kye.SistemasRegistros.Win.Planes
{
    partial class AgregarPlanesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPlanesForm));
            txtNombrePlan = new TextBox();
            txtCostoBase = new TextBox();
            txtDuracionMeses = new TextBox();
            cmbTipoDescuento = new ComboBox();
            txtDescuento = new TextBox();
            txtFechaFin = new MaskedTextBox();
            txtFechaInicio = new MaskedTextBox();
            cmbPromo = new ComboBox();
            txtPromocion = new Kye.SistemasRegistros.Win.Controles.TextBoxSistema();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lineShape1 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            btnAtras = new PictureBox();
            lineShape2 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lineShape3 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lineShape4 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lineShape7 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lineShape5 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lineShape6 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // txtNombrePlan
            // 
            txtNombrePlan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombrePlan.BackColor = Color.FromArgb(55, 55, 55);
            txtNombrePlan.BorderStyle = BorderStyle.None;
            txtNombrePlan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePlan.ForeColor = Color.Snow;
            txtNombrePlan.Location = new Point(25, 90);
            txtNombrePlan.Name = "txtNombrePlan";
            txtNombrePlan.PlaceholderText = "Ingresa nombre del plan";
            txtNombrePlan.Size = new Size(1090, 32);
            txtNombrePlan.TabIndex = 0;
            // 
            // txtCostoBase
            // 
            txtCostoBase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCostoBase.BackColor = Color.FromArgb(55, 55, 55);
            txtCostoBase.BorderStyle = BorderStyle.None;
            txtCostoBase.Font = new Font("Segoe UI", 18F);
            txtCostoBase.ForeColor = Color.Snow;
            txtCostoBase.Location = new Point(27, 169);
            txtCostoBase.Name = "txtCostoBase";
            txtCostoBase.PlaceholderText = "Ingresa el costo base";
            txtCostoBase.Size = new Size(483, 32);
            txtCostoBase.TabIndex = 1;
            // 
            // txtDuracionMeses
            // 
            txtDuracionMeses.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDuracionMeses.BackColor = Color.FromArgb(55, 55, 55);
            txtDuracionMeses.BorderStyle = BorderStyle.None;
            txtDuracionMeses.Font = new Font("Segoe UI", 18F);
            txtDuracionMeses.ForeColor = Color.Snow;
            txtDuracionMeses.Location = new Point(553, 169);
            txtDuracionMeses.Name = "txtDuracionMeses";
            txtDuracionMeses.PlaceholderText = "Ingresa la duracion de meses";
            txtDuracionMeses.Size = new Size(324, 32);
            txtDuracionMeses.TabIndex = 2;
            // 
            // cmbTipoDescuento
            // 
            cmbTipoDescuento.BackColor = Color.FromArgb(55, 55, 55);
            cmbTipoDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDescuento.Font = new Font("Segoe UI", 18F);
            cmbTipoDescuento.ForeColor = Color.Snow;
            cmbTipoDescuento.FormattingEnabled = true;
            cmbTipoDescuento.Items.AddRange(new object[] { "MONTO", "PORCENTAJE" });
            cmbTipoDescuento.Location = new Point(14, 431);
            cmbTipoDescuento.Name = "cmbTipoDescuento";
            cmbTipoDescuento.Size = new Size(506, 40);
            cmbTipoDescuento.TabIndex = 3;
            // 
            // txtDescuento
            // 
            txtDescuento.BackColor = Color.FromArgb(55, 55, 55);
            txtDescuento.BorderStyle = BorderStyle.None;
            txtDescuento.Font = new Font("Segoe UI", 18F);
            txtDescuento.ForeColor = Color.Snow;
            txtDescuento.Location = new Point(557, 435);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PlaceholderText = "Ingresa el valor del descuento";
            txtDescuento.Size = new Size(336, 32);
            txtDescuento.TabIndex = 4;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaFin.BackColor = Color.FromArgb(55, 55, 55);
            txtFechaFin.BorderStyle = BorderStyle.None;
            txtFechaFin.Culture = new System.Globalization.CultureInfo("es-MX");
            txtFechaFin.Font = new Font("Segoe UI", 18F);
            txtFechaFin.ForeColor = Color.Snow;
            txtFechaFin.Location = new Point(929, 336);
            txtFechaFin.Mask = "00/00/0000";
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(195, 32);
            txtFechaFin.TabIndex = 5;
            txtFechaFin.ValidatingType = typeof(DateTime);
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaInicio.BackColor = Color.FromArgb(55, 55, 55);
            txtFechaInicio.BorderStyle = BorderStyle.None;
            txtFechaInicio.Culture = new System.Globalization.CultureInfo("es-MX");
            txtFechaInicio.Font = new Font("Segoe UI", 18F);
            txtFechaInicio.ForeColor = Color.Snow;
            txtFechaInicio.Location = new Point(690, 338);
            txtFechaInicio.Mask = "00/00/0000";
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(188, 32);
            txtFechaInicio.TabIndex = 6;
            txtFechaInicio.ValidatingType = typeof(DateTime);
            // 
            // cmbPromo
            // 
            cmbPromo.BackColor = Color.FromArgb(55, 55, 55);
            cmbPromo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPromo.Font = new Font("Segoe UI", 18F);
            cmbPromo.ForeColor = Color.Snow;
            cmbPromo.FormattingEnabled = true;
            cmbPromo.Items.AddRange(new object[] { "SI", "NO" });
            cmbPromo.Location = new Point(14, 248);
            cmbPromo.Name = "cmbPromo";
            cmbPromo.Size = new Size(506, 40);
            cmbPromo.TabIndex = 7;
            // 
            // txtPromocion
            // 
            txtPromocion.BackColor = Color.FromArgb(55, 55, 55);
            txtPromocion.BorderStyle = BorderStyle.None;
            txtPromocion.Font = new Font("Segoe UI", 18F);
            txtPromocion.ForeColor = Color.Snow;
            txtPromocion.Location = new Point(26, 336);
            txtPromocion.Name = "txtPromocion";
            txtPromocion.PlaceholderText = "Ingresa la promocion";
            txtPromocion.Size = new Size(603, 32);
            txtPromocion.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(21, 196, 80);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.ForeColor = Color.Snow;
            btnGuardar.Location = new Point(890, 908);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(243, 41);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 10;
            label1.Text = "Nombre plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(14, 151);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 10;
            label2.Text = "Costo base";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(538, 149);
            label3.Name = "label3";
            label3.Size = new Size(106, 17);
            label3.TabIndex = 10;
            label3.Text = "Duracion meses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(14, 228);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 10;
            label4.Text = "Tiene promocion?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(14, 316);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 10;
            label5.Text = "Promocion";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(681, 318);
            label6.Name = "label6";
            label6.Size = new Size(152, 17);
            label6.TabIndex = 10;
            label6.Text = "Fecha inicio promocion";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(916, 318);
            label7.Name = "label7";
            label7.Size = new Size(135, 17);
            label7.TabIndex = 10;
            label7.Text = "Fecha fin promocion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(15, 411);
            label8.Name = "label8";
            label8.Size = new Size(103, 17);
            label8.TabIndex = 10;
            label8.Text = "Tipo descuento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(544, 411);
            label9.Name = "label9";
            label9.Size = new Size(107, 17);
            label9.TabIndex = 10;
            label9.Text = "Valor descuento";
            // 
            // lineShape1
            // 
            lineShape1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lineShape1.LineColor = Color.FromArgb(67, 67, 67);
            lineShape1.LineWidth = 2;
            lineShape1.Location = new Point(13, 128);
            lineShape1.Name = "lineShape1";
            lineShape1.Size = new Size(1120, 10);
            lineShape1.TabIndex = 11;
            lineShape1.Text = "lineShape1";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(26, 30);
            btnAtras.SizeMode = PictureBoxSizeMode.Zoom;
            btnAtras.TabIndex = 12;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lineShape2
            // 
            lineShape2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lineShape2.LineColor = Color.FromArgb(67, 67, 67);
            lineShape2.LineWidth = 2;
            lineShape2.Location = new Point(14, 207);
            lineShape2.Name = "lineShape2";
            lineShape2.Size = new Size(506, 10);
            lineShape2.TabIndex = 13;
            lineShape2.Text = "lineShape2";
            // 
            // lineShape3
            // 
            lineShape3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineShape3.LineColor = Color.FromArgb(67, 67, 67);
            lineShape3.LineWidth = 2;
            lineShape3.Location = new Point(544, 207);
            lineShape3.Name = "lineShape3";
            lineShape3.Size = new Size(353, 10);
            lineShape3.TabIndex = 13;
            lineShape3.Text = "lineShape2";
            // 
            // lineShape4
            // 
            lineShape4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lineShape4.LineColor = Color.FromArgb(67, 67, 67);
            lineShape4.LineWidth = 2;
            lineShape4.Location = new Point(14, 374);
            lineShape4.Name = "lineShape4";
            lineShape4.Size = new Size(641, 10);
            lineShape4.TabIndex = 13;
            lineShape4.Text = "lineShape2";
            // 
            // lineShape7
            // 
            lineShape7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lineShape7.LineColor = Color.FromArgb(67, 67, 67);
            lineShape7.LineWidth = 2;
            lineShape7.Location = new Point(544, 473);
            lineShape7.Name = "lineShape7";
            lineShape7.Size = new Size(375, 10);
            lineShape7.TabIndex = 13;
            lineShape7.Text = "lineShape2";
            // 
            // lineShape5
            // 
            lineShape5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineShape5.LineColor = Color.FromArgb(67, 67, 67);
            lineShape5.LineWidth = 2;
            lineShape5.Location = new Point(681, 374);
            lineShape5.Name = "lineShape5";
            lineShape5.Size = new Size(210, 10);
            lineShape5.TabIndex = 14;
            lineShape5.Text = "lineShape5";
            // 
            // lineShape6
            // 
            lineShape6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineShape6.LineColor = Color.FromArgb(67, 67, 67);
            lineShape6.LineWidth = 2;
            lineShape6.Location = new Point(916, 374);
            lineShape6.Name = "lineShape6";
            lineShape6.Size = new Size(217, 10);
            lineShape6.TabIndex = 14;
            lineShape6.Text = "lineShape5";
            // 
            // AgregarPlanesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(1145, 961);
            Controls.Add(lineShape6);
            Controls.Add(lineShape5);
            Controls.Add(txtCostoBase);
            Controls.Add(txtNombrePlan);
            Controls.Add(txtPromocion);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtFechaFin);
            Controls.Add(txtDuracionMeses);
            Controls.Add(txtDescuento);
            Controls.Add(lineShape3);
            Controls.Add(lineShape7);
            Controls.Add(lineShape4);
            Controls.Add(lineShape2);
            Controls.Add(btnAtras);
            Controls.Add(lineShape1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(cmbPromo);
            Controls.Add(cmbTipoDescuento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarPlanesForm";
            Text = "AgregarPlanesForm";
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombrePlan;
        private TextBox txtCostoBase;
        private TextBox txtDuracionMeses;
        private ComboBox cmbTipoDescuento;
        private TextBox txtDescuento;
        private MaskedTextBox txtFechaFin;
        private MaskedTextBox txtFechaInicio;
        private ComboBox cmbPromo;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Controles.TextBoxSistema txtPromocion;
        private Controles.LineShape lineShape1;
        private PictureBox btnAtras;
        private Controles.LineShape lineShape2;
        private Controles.LineShape lineShape3;
        private Controles.LineShape lineShape4;
        private Controles.LineShape lineShape5;
        private Controles.LineShape lineShape6;
        private Controles.LineShape lineShape7;
    }
}