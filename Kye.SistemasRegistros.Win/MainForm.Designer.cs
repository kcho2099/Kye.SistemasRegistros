namespace Kye.SistemasRegistros.Win
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlMenu = new Panel();
            lineShape1 = new Kye.SistemasRegistros.Win.Controles.LineShape();
            lblRol = new Label();
            picUser = new PictureBox();
            lblBitacora = new Label();
            lblUsuario = new Label();
            lblMiembros = new Label();
            lblCheckIn = new Label();
            lblPlanes = new Label();
            lblMembresias = new Label();
            lblPagos = new Label();
            pnlBody = new Panel();
            textosBindingSource = new BindingSource(components);
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.BackColor = Color.FromArgb(55, 55, 55);
            pnlMenu.Controls.Add(lineShape1);
            pnlMenu.Controls.Add(lblRol);
            pnlMenu.Controls.Add(picUser);
            pnlMenu.Controls.Add(lblBitacora);
            pnlMenu.Controls.Add(lblUsuario);
            pnlMenu.Controls.Add(lblMiembros);
            pnlMenu.Controls.Add(lblCheckIn);
            pnlMenu.Controls.Add(lblPlanes);
            pnlMenu.Controls.Add(lblMembresias);
            pnlMenu.Controls.Add(lblPagos);
            pnlMenu.Location = new Point(12, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(249, 961);
            pnlMenu.TabIndex = 0;
            // 
            // lineShape1
            // 
            lineShape1.ForeColor = Color.Coral;
            lineShape1.LineColor = Color.FromArgb(73, 73, 73);
            lineShape1.LineWidth = 2;
            lineShape1.Location = new Point(3, 100);
            lineShape1.Name = "lineShape1";
            lineShape1.Size = new Size(243, 23);
            lineShape1.TabIndex = 5;
            lineShape1.Text = "lineShape1";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.Window;
            lblRol.Location = new Point(107, 61);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(32, 15);
            lblRol.TabIndex = 4;
            lblRol.Text = "[Rol]";
            // 
            // picUser
            // 
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(12, 15);
            picUser.Name = "picUser";
            picUser.Size = new Size(84, 79);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 2;
            picUser.TabStop = false;
            picUser.WaitOnLoad = true;
            // 
            // lblBitacora
            // 
            lblBitacora.AccessibleRole = AccessibleRole.Text;
            lblBitacora.AutoSize = true;
            lblBitacora.Cursor = Cursors.Hand;
            lblBitacora.FlatStyle = FlatStyle.Flat;
            lblBitacora.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblBitacora.ForeColor = Color.Snow;
            lblBitacora.Location = new Point(3, 387);
            lblBitacora.Name = "lblBitacora";
            lblBitacora.Size = new Size(225, 32);
            lblBitacora.TabIndex = 1;
            lblBitacora.Tag = "Bitacora Sistema";
            lblBitacora.Text = "lblBitacoraSistemas";
            lblBitacora.MouseEnter += lblMiembros_MouseEnter;
            lblBitacora.MouseLeave += lblMiembros_MouseLeave;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Snow;
            lblUsuario.Location = new Point(102, 36);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(95, 25);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "[Usuario]";
            // 
            // lblMiembros
            // 
            lblMiembros.AutoSize = true;
            lblMiembros.Cursor = Cursors.Hand;
            lblMiembros.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblMiembros.ForeColor = Color.Snow;
            lblMiembros.Location = new Point(3, 152);
            lblMiembros.Name = "lblMiembros";
            lblMiembros.Padding = new Padding(0, 0, 90, 0);
            lblMiembros.Size = new Size(239, 32);
            lblMiembros.TabIndex = 1;
            lblMiembros.Text = "lblMiembros";
            lblMiembros.Click += lblMiembros_Click_1;
            lblMiembros.MouseEnter += lblMiembros_MouseEnter;
            lblMiembros.MouseLeave += lblMiembros_MouseLeave;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Cursor = Cursors.Hand;
            lblCheckIn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblCheckIn.ForeColor = Color.Snow;
            lblCheckIn.Location = new Point(3, 340);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(232, 32);
            lblCheckIn.TabIndex = 1;
            lblCheckIn.Text = "lblCheckIn               ";
            lblCheckIn.MouseEnter += lblMiembros_MouseEnter;
            lblCheckIn.MouseLeave += lblMiembros_MouseLeave;
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.Cursor = Cursors.Hand;
            lblPlanes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPlanes.ForeColor = Color.Snow;
            lblPlanes.Location = new Point(3, 199);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(110, 32);
            lblPlanes.TabIndex = 1;
            lblPlanes.Text = "lblPlanes";
            lblPlanes.Click += lblPlanes_Click;
            lblPlanes.MouseEnter += lblMiembros_MouseEnter;
            lblPlanes.MouseLeave += lblMiembros_MouseLeave;
            // 
            // lblMembresias
            // 
            lblMembresias.AutoSize = true;
            lblMembresias.Cursor = Cursors.Hand;
            lblMembresias.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblMembresias.ForeColor = Color.Snow;
            lblMembresias.Location = new Point(3, 246);
            lblMembresias.Name = "lblMembresias";
            lblMembresias.Size = new Size(234, 32);
            lblMembresias.TabIndex = 1;
            lblMembresias.Text = "lblMembresias         ";
            lblMembresias.Click += lblMembresias_Click;
            lblMembresias.MouseEnter += lblMiembros_MouseEnter;
            lblMembresias.MouseLeave += lblMiembros_MouseLeave;
            // 
            // lblPagos
            // 
            lblPagos.AutoSize = true;
            lblPagos.Cursor = Cursors.Hand;
            lblPagos.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPagos.ForeColor = Color.Snow;
            lblPagos.Location = new Point(3, 293);
            lblPagos.Name = "lblPagos";
            lblPagos.Size = new Size(104, 32);
            lblPagos.TabIndex = 1;
            lblPagos.Text = "lblPagos";
            lblPagos.MouseEnter += lblMiembros_MouseEnter;
            lblPagos.MouseLeave += lblMiembros_MouseLeave;
            // 
            // pnlBody
            // 
            pnlBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBody.AutoScroll = true;
            pnlBody.BackColor = Color.FromArgb(55, 55, 55);
            pnlBody.Location = new Point(267, 12);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1145, 961);
            pnlBody.TabIndex = 2;
            // 
            // textosBindingSource
            // 
            textosBindingSource.DataSource = typeof(Entities.Resources.Textos);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(1000, 900);
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1424, 985);
            Controls.Add(pnlBody);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(700, 900);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)textosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Panel pnlMenu;
        private Panel pnlBody;
        private Label lblMiembros;
        private Label lblBitacora;
        private Label label7;
        private Label lblPagos;
        private Label lblPlanes;
        private Label lblMembresias;
        private BindingSource textosBindingSource;
        private Label lblCheckIn;
        private PictureBox picUser;
        private Label lblUsuario;
        private Label lblRol;
        private Controles.LineShape lineShape1;
    }
}
