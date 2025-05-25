namespace Kye.SistemasRegistros.Win
{
    partial class BuscarMiembroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarMiembroForm));
            pictureBox1 = new PictureBox();
            lineShape1 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            txtBuscar = new Kye.SistemasRegistros.Win.Controles.TextBoxSistema();
            btnBuscar = new Button();
            btnAtras = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 447);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lineShape1
            // 
            lineShape1.LineColor = Color.FromArgb(61, 61, 61);
            lineShape1.LineWidth = 2;
            lineShape1.Location = new Point(66, 93);
            lineShape1.Name = "lineShape1";
            lineShape1.Size = new Size(351, 23);
            lineShape1.TabIndex = 1;
            lineShape1.Text = "lineShape1";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(37, 37, 37);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 18F);
            txtBuscar.ForeColor = Color.Snow;
            txtBuscar.Location = new Point(82, 68);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Nombre o ID del miembro";
            txtBuscar.Size = new Size(323, 32);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(51, 196, 80);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 14F);
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(66, 122);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(351, 41);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(7, 9);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(26, 30);
            btnAtras.SizeMode = PictureBoxSizeMode.Zoom;
            btnAtras.TabIndex = 4;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            btnAtras.MouseEnter += btnAtras_MouseEnter;
            btnAtras.MouseLeave += btnAtras_MouseLeave;
            // 
            // BuscarMiembroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(477, 660);
            Controls.Add(btnAtras);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lineShape1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuscarMiembroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscarMiembroForm";
            Load += BuscarMiembroForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Controles.LineShape lineShape1;
        private Controles.TextBoxSistema txtBuscar;
        private Button btnBuscar;
        private Button button1;
        private PictureBox btnAtras;
    }
}