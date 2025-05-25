namespace Kye.SistemasRegistros.Win
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lineShape1 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            lineShape2 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lineShape1
            // 
            lineShape1.LineColor = Color.FromArgb(61, 61, 61);
            lineShape1.LineWidth = 2;
            lineShape1.Location = new Point(24, 99);
            lineShape1.Name = "lineShape1";
            lineShape1.Size = new Size(308, 23);
            lineShape1.TabIndex = 1;
            lineShape1.Text = "lineShape1";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(21, 21, 21);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 18F);
            txtUsuario.ForeColor = Color.WhiteSmoke;
            txtUsuario.Location = new Point(33, 71);
            txtUsuario.MaxLength = 100;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingresa tu usuario";
            txtUsuario.Size = new Size(290, 32);
            txtUsuario.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lineShape2
            // 
            lineShape2.LineColor = Color.FromArgb(61, 61, 61);
            lineShape2.LineWidth = 2;
            lineShape2.Location = new Point(24, 193);
            lineShape2.Name = "lineShape2";
            lineShape2.Size = new Size(308, 23);
            lineShape2.TabIndex = 1;
            lineShape2.Text = "lineShape1";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(21, 21, 21);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(33, 163);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Ingresa tu Contraseña";
            txtPassword.Size = new Size(290, 32);
            txtPassword.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.AutoEllipsis = true;
            btnIngresar.BackColor = Color.FromArgb(53, 196, 80);
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Segoe UI", 14F);
            btnIngresar.ForeColor = Color.WhiteSmoke;
            btnIngresar.Location = new Point(208, 239);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(124, 41);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 5;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(24, 141);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 6;
            label2.Text = "CONTRASEÑA";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(695, 318);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(lineShape2);
            Controls.Add(lineShape1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Controles.TextBoxSistema textBoxSistema1;
        private Controles.LineShape lineShape1;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private Controles.LineShape lineShape2;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Label label2;
    }
}