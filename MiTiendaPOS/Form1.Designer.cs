namespace MiTiendaPOS
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            mnuPrincipal = new MenuStrip();
            mnuSalir = new ToolStripMenuItem();
            mnuCatálogos = new ToolStripMenuItem();
            mnuCategorias = new ToolStripMenuItem();
            mnuProductos = new ToolStripMenuItem();
            mnuClientes = new ToolStripMenuItem();
            mnuOperaciones = new ToolStripMenuItem();
            mnuVentas = new ToolStripMenuItem();
            stsEstado = new StatusStrip();
            panel1 = new Panel();
            btnVentas = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnCategorias = new Button();
            label3 = new Label();
            label2 = new Label();
            picLogo = new PictureBox();
            lblEstado = new ToolStripStatusLabel();
            lblFecha = new ToolStripStatusLabel();
            mnuPrincipal.SuspendLayout();
            stsEstado.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.ImageScalingSize = new Size(24, 24);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuSalir, mnuCatálogos, mnuOperaciones });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(1178, 33);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(61, 29);
            mnuSalir.Text = "&Salir";
            // 
            // mnuCatálogos
            // 
            mnuCatálogos.DropDownItems.AddRange(new ToolStripItem[] { mnuCategorias, mnuProductos, mnuClientes });
            mnuCatálogos.Name = "mnuCatálogos";
            mnuCatálogos.Size = new Size(108, 29);
            mnuCatálogos.Text = "Catálogos";
            // 
            // mnuCategorias
            // 
            mnuCategorias.Name = "mnuCategorias";
            mnuCategorias.Size = new Size(198, 34);
            mnuCategorias.Text = "Categorias";
            // 
            // mnuProductos
            // 
            mnuProductos.Name = "mnuProductos";
            mnuProductos.Size = new Size(198, 34);
            mnuProductos.Text = "Productos";
            // 
            // mnuClientes
            // 
            mnuClientes.Name = "mnuClientes";
            mnuClientes.Size = new Size(198, 34);
            mnuClientes.Text = "Clientes";
            // 
            // mnuOperaciones
            // 
            mnuOperaciones.DropDownItems.AddRange(new ToolStripItem[] { mnuVentas });
            mnuOperaciones.Name = "mnuOperaciones";
            mnuOperaciones.Size = new Size(127, 29);
            mnuOperaciones.Text = "Operaciones";
            // 
            // mnuVentas
            // 
            mnuVentas.Name = "mnuVentas";
            mnuVentas.Size = new Size(166, 34);
            mnuVentas.Text = "Ventas";
            // 
            // stsEstado
            // 
            stsEstado.ImageScalingSize = new Size(24, 24);
            stsEstado.Items.AddRange(new ToolStripItem[] { lblEstado, lblFecha });
            stsEstado.Location = new Point(0, 632);
            stsEstado.Name = "stsEstado";
            stsEstado.Size = new Size(1178, 32);
            stsEstado.TabIndex = 1;
            stsEstado.Text = "statusStrip1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnCategorias);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 590);
            panel1.TabIndex = 2;
            panel1.Paint += this.panel1_Paint;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.MidnightBlue;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 389);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(240, 84);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.MidnightBlue;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 299);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(240, 84);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.MidnightBlue;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 209);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(240, 84);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.MidnightBlue;
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(0, 119);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(240, 84);
            btnCategorias.TabIndex = 3;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 66);
            label3.Name = "label3";
            label3.Size = new Size(240, 50);
            label3.TabIndex = 2;
            label3.Text = "Menú Principal";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 16);
            label2.Name = "label2";
            label2.Size = new Size(240, 50);
            label2.TabIndex = 1;
            label2.Text = "MiTiendaPOS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(258, 37);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(908, 590);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            picLogo.Click += this.picLogo_Click;
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(1096, 25);
            lblEstado.Spring = true;
            lblEstado.Text = "Listo!";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(67, 25);
            lblFecha.Text = "(Fecha)";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 664);
            Controls.Add(picLogo);
            Controls.Add(panel1);
            Controls.Add(stsEstado);
            Controls.Add(mnuPrincipal);
            MainMenuStrip = mnuPrincipal;
            MinimumSize = new Size(1000, 650);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi Tienda POS - Sistema de Punto de Venta";
            Load += FrmPrincipal_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            stsEstado.ResumeLayout(false);
            stsEstado.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private StatusStrip stsEstado;
        private Panel panel1;
        private PictureBox picLogo;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem mnuCatálogos;
        private ToolStripMenuItem mnuCategorias;
        private ToolStripMenuItem mnuProductos;
        private ToolStripMenuItem mnuClientes;
        private ToolStripMenuItem mnuOperaciones;
        private ToolStripMenuItem mnuVentas;
        private Label label3;
        private Label label2;
        private Button btnCategorias;
        private Button btnVentas;
        private Button btnClientes;
        private Button btnProductos;
        private ToolStripStatusLabel lblEstado;
        private ToolStripStatusLabel lblFecha;
    }
}
