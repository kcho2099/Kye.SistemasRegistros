namespace Kye.SistemasRegistros.Win.MiembrosForms
{
    partial class AgregarMiembroForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMiembroForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pcFoto = new PictureBox();
            txtNombreCompleto = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtWhatsApp = new TextBox();
            lineShape1 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            btnAtras = new PictureBox();
            lineShape2 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lineShape3 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lineShape4 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lineaSheapVertical1 = new Kye.SistemasRegistros.Win.Controles.LineaSheapVertical();
            lineShape5 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            label5 = new Label();
            btnCapturar = new Button();
            btnGuardar = new Button();
            lineShape7 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            txtNombreContacto = new TextBox();
            label6 = new Label();
            cmbParentesco = new ComboBox();
            label7 = new Label();
            lineShape6 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            txtTelefonoContacto = new TextBox();
            label8 = new Label();
            btnAgregar = new Button();
            lineShape8 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            txtClave = new TextBox();
            label9 = new Label();
            txtFechaNacimiento = new MaskedTextBox();
            dgvContactos = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            IdEmergencia = new DataGridViewTextBoxColumn();
            NombreContacto = new DataGridViewTextBoxColumn();
            Parentesco = new DataGridViewTextBoxColumn();
            TelefonoContacto = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            cmbPlan = new ComboBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pcFoto
            // 
            pcFoto.BorderStyle = BorderStyle.FixedSingle;
            pcFoto.InitialImage = (Image)resources.GetObject("pcFoto.InitialImage");
            pcFoto.Location = new Point(12, 63);
            pcFoto.Name = "pcFoto";
            pcFoto.Size = new Size(243, 320);
            pcFoto.TabIndex = 0;
            pcFoto.TabStop = false;
            pcFoto.WaitOnLoad = true;
            pcFoto.DoubleClick += pcFoto_DoubleClick;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCompleto.BackColor = Color.FromArgb(55, 55, 55);
            txtNombreCompleto.BorderStyle = BorderStyle.None;
            txtNombreCompleto.Font = new Font("Segoe UI", 18F);
            txtNombreCompleto.ForeColor = Color.Snow;
            txtNombreCompleto.Location = new Point(289, 151);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.PlaceholderText = "Ingresar nombre completo";
            txtNombreCompleto.Size = new Size(820, 32);
            txtNombreCompleto.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(55, 55, 55);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Segoe UI", 18F);
            txtTelefono.ForeColor = Color.Snow;
            txtTelefono.Location = new Point(289, 227);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingresar Telefono";
            txtTelefono.Size = new Size(228, 32);
            txtTelefono.TabIndex = 2;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(55, 55, 55);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 18F);
            txtEmail.ForeColor = Color.Snow;
            txtEmail.Location = new Point(289, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "CorreoElectronico";
            txtEmail.Size = new Size(821, 32);
            txtEmail.TabIndex = 4;
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.BackColor = Color.FromArgb(55, 55, 55);
            txtWhatsApp.BorderStyle = BorderStyle.None;
            txtWhatsApp.Font = new Font("Segoe UI", 18F);
            txtWhatsApp.ForeColor = Color.Snow;
            txtWhatsApp.Location = new Point(577, 227);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.PlaceholderText = "Ingresar WhatsApp";
            txtWhatsApp.Size = new Size(230, 32);
            txtWhatsApp.TabIndex = 3;
            txtWhatsApp.TextChanged += txtWhatsApp_TextChanged;
            // 
            // lineShape1
            // 
            lineShape1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lineShape1.LineColor = Color.FromArgb(67, 67, 67);
            lineShape1.LineWidth = 2;
            lineShape1.Location = new Point(277, 180);
            lineShape1.Name = "lineShape1";
            lineShape1.Size = new Size(850, 14);
            lineShape1.TabIndex = 8;
            lineShape1.Text = "lineShape1";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(10, 11);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(26, 30);
            btnAtras.SizeMode = PictureBoxSizeMode.Zoom;
            btnAtras.TabIndex = 9;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            btnAtras.MouseEnter += btnAtras_MouseEnter;
            btnAtras.MouseLeave += btnAtras_MouseLeave;
            // 
            // lineShape2
            // 
            lineShape2.LineColor = Color.FromArgb(67, 67, 67);
            lineShape2.LineWidth = 2;
            lineShape2.Location = new Point(563, 256);
            lineShape2.Name = "lineShape2";
            lineShape2.Size = new Size(257, 14);
            lineShape2.TabIndex = 10;
            lineShape2.Text = "lineShape2";
            // 
            // lineShape3
            // 
            lineShape3.LineColor = Color.FromArgb(67, 67, 67);
            lineShape3.LineWidth = 2;
            lineShape3.Location = new Point(277, 256);
            lineShape3.Name = "lineShape3";
            lineShape3.Size = new Size(259, 14);
            lineShape3.TabIndex = 11;
            lineShape3.Text = "lineShape3";
            // 
            // lineShape4
            // 
            lineShape4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lineShape4.LineColor = Color.FromArgb(67, 67, 67);
            lineShape4.LineWidth = 2;
            lineShape4.Location = new Point(277, 344);
            lineShape4.Name = "lineShape4";
            lineShape4.Size = new Size(850, 10);
            lineShape4.TabIndex = 11;
            lineShape4.Text = "lineShape3";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(277, 129);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 12;
            label1.Text = "NOMBRE COMPLETO*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(277, 207);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 13;
            label2.Text = "TELEFONO*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(563, 205);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 13;
            label3.Text = "WHATSAPP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(279, 286);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 13;
            label4.Text = "EMAIL";
            // 
            // lineaSheapVertical1
            // 
            lineaSheapVertical1.LineColor = Color.FromArgb(73, 73, 73);
            lineaSheapVertical1.Location = new Point(261, 63);
            lineaSheapVertical1.Name = "lineaSheapVertical1";
            lineaSheapVertical1.Size = new Size(10, 369);
            lineaSheapVertical1.TabIndex = 14;
            lineaSheapVertical1.Text = "lineaSheapVertical1";
            // 
            // lineShape5
            // 
            lineShape5.LineColor = Color.FromArgb(67, 67, 67);
            lineShape5.LineWidth = 2;
            lineShape5.Location = new Point(279, 420);
            lineShape5.Name = "lineShape5";
            lineShape5.Size = new Size(257, 12);
            lineShape5.TabIndex = 11;
            lineShape5.Text = "lineShape3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(279, 371);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 13;
            label5.Text = "FECHA NACIMIENTO*";
            // 
            // btnCapturar
            // 
            btnCapturar.BackColor = Color.FromArgb(51, 80, 196);
            btnCapturar.Cursor = Cursors.Hand;
            btnCapturar.FlatStyle = FlatStyle.Popup;
            btnCapturar.Font = new Font("Segoe UI", 14F);
            btnCapturar.ForeColor = Color.Snow;
            btnCapturar.Location = new Point(12, 391);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.Size = new Size(245, 41);
            btnCapturar.TabIndex = 15;
            btnCapturar.Text = "Capturar";
            btnCapturar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(51, 196, 80);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.ForeColor = Color.Snow;
            btnGuardar.Location = new Point(871, 908);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(243, 41);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lineShape7
            // 
            lineShape7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lineShape7.LineColor = Color.FromArgb(67, 67, 67);
            lineShape7.LineWidth = 2;
            lineShape7.Location = new Point(10, 94);
            lineShape7.Name = "lineShape7";
            lineShape7.Size = new Size(563, 16);
            lineShape7.TabIndex = 8;
            lineShape7.Text = "lineShape1";
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreContacto.BackColor = Color.FromArgb(55, 55, 55);
            txtNombreContacto.BorderStyle = BorderStyle.None;
            txtNombreContacto.Font = new Font("Segoe UI", 18F);
            txtNombreContacto.ForeColor = Color.Snow;
            txtNombreContacto.Location = new Point(26, 62);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.PlaceholderText = "Ingresar nombre contacto";
            txtNombreContacto.Size = new Size(526, 32);
            txtNombreContacto.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(6, 34);
            label6.Name = "label6";
            label6.Size = new Size(160, 19);
            label6.TabIndex = 12;
            label6.Text = "NOMBRE CONTACTO**";
            // 
            // cmbParentesco
            // 
            cmbParentesco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbParentesco.BackColor = Color.FromArgb(55, 55, 55);
            cmbParentesco.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParentesco.FlatStyle = FlatStyle.Flat;
            cmbParentesco.Font = new Font("Segoe UI", 18F);
            cmbParentesco.ForeColor = Color.Snow;
            cmbParentesco.FormattingEnabled = true;
            cmbParentesco.Items.AddRange(new object[] { "Amiga/o", "Conyuge", "Hermana/o", "Hijo/a", "Madre", "Otro", "Padre" });
            cmbParentesco.Location = new Point(587, 59);
            cmbParentesco.Name = "cmbParentesco";
            cmbParentesco.RightToLeft = RightToLeft.No;
            cmbParentesco.Size = new Size(515, 40);
            cmbParentesco.Sorted = true;
            cmbParentesco.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(587, 34);
            label7.Name = "label7";
            label7.Size = new Size(109, 19);
            label7.TabIndex = 12;
            label7.Text = "PARENTESCO**";
            // 
            // lineShape6
            // 
            lineShape6.LineColor = Color.FromArgb(67, 67, 67);
            lineShape6.LineWidth = 2;
            lineShape6.Location = new Point(10, 177);
            lineShape6.Name = "lineShape6";
            lineShape6.Size = new Size(567, 10);
            lineShape6.TabIndex = 11;
            lineShape6.Text = "lineShape3";
            // 
            // txtTelefonoContacto
            // 
            txtTelefonoContacto.BackColor = Color.FromArgb(55, 55, 55);
            txtTelefonoContacto.BorderStyle = BorderStyle.None;
            txtTelefonoContacto.Font = new Font("Segoe UI", 18F);
            txtTelefonoContacto.ForeColor = Color.Snow;
            txtTelefonoContacto.Location = new Point(26, 143);
            txtTelefonoContacto.MaxLength = 10;
            txtTelefonoContacto.Name = "txtTelefonoContacto";
            txtTelefonoContacto.PlaceholderText = "Ingresar Telefono";
            txtTelefonoContacto.Size = new Size(530, 32);
            txtTelefonoContacto.TabIndex = 8;
            txtTelefonoContacto.TextChanged += txtTelefonoContacto_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(10, 123);
            label8.Name = "label8";
            label8.Size = new Size(160, 17);
            label8.TabIndex = 13;
            label8.Text = "TELEFONO CONTACTO**";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 14F);
            btnAgregar.ForeColor = Color.Snow;
            btnAgregar.Location = new Point(855, 134);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(243, 41);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar Contacto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lineShape8
            // 
            lineShape8.LineColor = Color.FromArgb(67, 67, 67);
            lineShape8.LineWidth = 2;
            lineShape8.Location = new Point(277, 112);
            lineShape8.Name = "lineShape8";
            lineShape8.Size = new Size(252, 14);
            lineShape8.TabIndex = 11;
            lineShape8.Text = "lineShape3";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(55, 55, 55);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Enabled = false;
            txtClave.Font = new Font("Segoe UI", 18F);
            txtClave.ForeColor = Color.Snow;
            txtClave.Location = new Point(289, 83);
            txtClave.MaxLength = 10;
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "0";
            txtClave.Size = new Size(224, 32);
            txtClave.TabIndex = 0;
            txtClave.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(277, 63);
            label9.Name = "label9";
            label9.Size = new Size(102, 17);
            label9.TabIndex = 13;
            label9.Text = "CLAVE CLIENTE";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.BackColor = Color.FromArgb(55, 55, 55);
            txtFechaNacimiento.BorderStyle = BorderStyle.None;
            txtFechaNacimiento.Culture = new System.Globalization.CultureInfo("es-MX");
            txtFechaNacimiento.Font = new Font("Segoe UI", 18F);
            txtFechaNacimiento.ForeColor = Color.Snow;
            txtFechaNacimiento.Location = new Point(289, 391);
            txtFechaNacimiento.Mask = "00/00/0000";
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(240, 32);
            txtFechaNacimiento.TabIndex = 5;
            txtFechaNacimiento.TextAlign = HorizontalAlignment.Center;
            txtFechaNacimiento.ValidatingType = typeof(DateTime);
            // 
            // dgvContactos
            // 
            dgvContactos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Columns.AddRange(new DataGridViewColumn[] { Eliminar, IdEmergencia, NombreContacto, Parentesco, TelefonoContacto });
            dgvContactos.Location = new Point(2, 219);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.Size = new Size(1109, 208);
            dgvContactos.TabIndex = 20;
            dgvContactos.CellContentClick += dgvContactos_CellContentClick;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            Eliminar.Frozen = true;
            Eliminar.HeaderText = "";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.Width = 269;
            // 
            // IdEmergencia
            // 
            IdEmergencia.Frozen = true;
            IdEmergencia.HeaderText = "Column1";
            IdEmergencia.Name = "IdEmergencia";
            IdEmergencia.ReadOnly = true;
            IdEmergencia.Visible = false;
            // 
            // NombreContacto
            // 
            NombreContacto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreContacto.HeaderText = "Nombre Contacto";
            NombreContacto.Name = "NombreContacto";
            NombreContacto.ReadOnly = true;
            NombreContacto.Resizable = DataGridViewTriState.True;
            NombreContacto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Parentesco
            // 
            Parentesco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Parentesco.HeaderText = "Parentesco";
            Parentesco.Name = "Parentesco";
            Parentesco.ReadOnly = true;
            // 
            // TelefonoContacto
            // 
            TelefonoContacto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TelefonoContacto.HeaderText = "Telefono Contacto";
            TelefonoContacto.Name = "TelefonoContacto";
            TelefonoContacto.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtTelefonoContacto);
            panel1.Controls.Add(dgvContactos);
            panel1.Controls.Add(txtNombreContacto);
            panel1.Controls.Add(lineShape6);
            panel1.Controls.Add(lineShape7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmbParentesco);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 466);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 427);
            panel1.TabIndex = 22;
            // 
            // cmbPlan
            // 
            cmbPlan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPlan.BackColor = Color.FromArgb(55, 55, 55);
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FlatStyle = FlatStyle.Flat;
            cmbPlan.Font = new Font("Segoe UI", 18F);
            cmbPlan.ForeColor = Color.Snow;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Amiga/o", "Conyuge", "Hermana/o", "Hijo/a", "Madre", "Otro", "Padre" });
            cmbPlan.Location = new Point(563, 388);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.RightToLeft = RightToLeft.No;
            cmbPlan.Size = new Size(564, 40);
            cmbPlan.Sorted = true;
            cmbPlan.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(563, 366);
            label10.Name = "label10";
            label10.Size = new Size(52, 19);
            label10.TabIndex = 12;
            label10.Text = "PLAN*";
            // 
            // AgregarMiembroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(1145, 961);
            Controls.Add(panel1);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(btnGuardar);
            Controls.Add(btnCapturar);
            Controls.Add(lineaSheapVertical1);
            Controls.Add(txtEmail);
            Controls.Add(cmbPlan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClave);
            Controls.Add(txtWhatsApp);
            Controls.Add(txtTelefono);
            Controls.Add(lineShape8);
            Controls.Add(lineShape5);
            Controls.Add(lineShape3);
            Controls.Add(lineShape2);
            Controls.Add(btnAtras);
            Controls.Add(pcFoto);
            Controls.Add(txtNombreCompleto);
            Controls.Add(lineShape1);
            Controls.Add(lineShape4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarMiembroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AgregarMiembroForm_Load;
            ((System.ComponentModel.ISupportInitialize)pcFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcFoto;
        private TextBox txtNombreCompleto;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtWhatsApp;
        private Controles.LineShape lineShape1;
        private PictureBox btnAtras;
        private Controles.LineShape lineShape2;
        private Controles.LineShape lineShape3;
        private Controles.LineShape lineShape4;
        private ErrorProvider errorProvider1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Controles.LineaSheapVertical lineaSheapVertical1;
        private Label label5;
        private Controles.LineShape lineShape5;
        private Button btnCapturar;
        private Button btnGuardar;
        private Label label6;
        private TextBox txtNombreContacto;
        private Controles.LineShape lineShape7;
        private ComboBox cmbParentesco;
        private Label label8;
        private Label label7;
        private TextBox txtTelefonoContacto;
        private Controles.LineShape lineShape6;
        private Button btnAgregar;
        private Label label9;
        private TextBox txtClave;
        private Controles.LineShape lineShape8;
        private MaskedTextBox txtFechaNacimiento;
        private DataGridView dgvContactos;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewTextBoxColumn IdEmergencia;
        private DataGridViewTextBoxColumn NombreContacto;
        private DataGridViewTextBoxColumn Parentesco;
        private DataGridViewTextBoxColumn TelefonoContacto;
        private Panel panel1;
        private ComboBox cmbPlan;
        private Label label10;
    }
}