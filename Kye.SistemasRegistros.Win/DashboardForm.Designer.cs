namespace Kye.SistemasRegistros.Win
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            pnlBuscarMiembro = new Panel();
            pcBuscarMiembro = new PictureBox();
            lblBuscarMiembro = new Label();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NombreCompleto = new DataGridViewTextBoxColumn();
            FechaHoraIngreso = new DataGridViewTextBoxColumn();
            pnlBuscarMiembro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBuscarMiembro).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlBuscarMiembro
            // 
            pnlBuscarMiembro.BackColor = Color.FromArgb(26, 60, 125);
            pnlBuscarMiembro.Controls.Add(pcBuscarMiembro);
            pnlBuscarMiembro.Controls.Add(lblBuscarMiembro);
            pnlBuscarMiembro.Cursor = Cursors.Hand;
            pnlBuscarMiembro.Location = new Point(376, 12);
            pnlBuscarMiembro.Name = "pnlBuscarMiembro";
            pnlBuscarMiembro.Size = new Size(358, 169);
            pnlBuscarMiembro.TabIndex = 0;
            pnlBuscarMiembro.Click += BuscarMiembro_Click;
            // 
            // pcBuscarMiembro
            // 
            pcBuscarMiembro.Image = (Image)resources.GetObject("pcBuscarMiembro.Image");
            pcBuscarMiembro.Location = new Point(153, 46);
            pcBuscarMiembro.Name = "pcBuscarMiembro";
            pcBuscarMiembro.Size = new Size(63, 58);
            pcBuscarMiembro.SizeMode = PictureBoxSizeMode.CenterImage;
            pcBuscarMiembro.TabIndex = 1;
            pcBuscarMiembro.TabStop = false;
            pcBuscarMiembro.Click += BuscarMiembro_Click;
            // 
            // lblBuscarMiembro
            // 
            lblBuscarMiembro.AutoSize = true;
            lblBuscarMiembro.Font = new Font("Segoe UI", 14.25F);
            lblBuscarMiembro.ForeColor = Color.Snow;
            lblBuscarMiembro.Location = new Point(120, 124);
            lblBuscarMiembro.Name = "lblBuscarMiembro";
            lblBuscarMiembro.Size = new Size(129, 25);
            lblBuscarMiembro.TabIndex = 0;
            lblBuscarMiembro.Text = "Buscar cliente";
            lblBuscarMiembro.Click += BuscarMiembro_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 81, 40);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(358, 169);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(19, 124);
            label2.Name = "label2";
            label2.Size = new Size(320, 25);
            label2.TabIndex = 1;
            label2.Text = "Numero de personas ingresaron hoy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(157, 39);
            label1.Name = "label1";
            label1.Size = new Size(80, 65);
            label1.TabIndex = 1;
            label1.Text = "36";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreCompleto, FechaHoraIngreso });
            dataGridView1.Location = new Point(740, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(380, 898);
            dataGridView1.TabIndex = 1;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.HeaderText = "Cliente";
            NombreCompleto.Name = "NombreCompleto";
            // 
            // FechaHoraIngreso
            // 
            FechaHoraIngreso.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaHoraIngreso.HeaderText = "Fecha Ingreso";
            FechaHoraIngreso.Name = "FechaHoraIngreso";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1129, 922);
            Controls.Add(dataGridView1);
            Controls.Add(pnlBuscarMiembro);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            pnlBuscarMiembro.ResumeLayout(false);
            pnlBuscarMiembro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBuscarMiembro).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBuscarMiembro;
        private PictureBox pcBuscarMiembro;
        private Label lblBuscarMiembro;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn FechaHoraIngreso;
    }
}