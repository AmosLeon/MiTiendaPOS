namespace MiTiendaPOS.Forms
{
    partial class FrmCategorias
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
            lblFiltro = new Label();
            txtBuscar = new TextBox();
            dgvCategorias = new DataGridView();
            grpDatos = new GroupBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(49, 47);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(67, 25);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(130, 44);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(350, 31);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(49, 114);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 62;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(431, 340);
            dgvCategorias.TabIndex = 2;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Location = new Point(515, 114);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(300, 113);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la  Categoria";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(288, 31);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(515, 244);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(300, 34);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(515, 297);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(300, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(515, 349);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(300, 34);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 505);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            Controls.Add(dgvCategorias);
            Controls.Add(txtBuscar);
            Controls.Add(lblFiltro);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Categorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFiltro;
        private TextBox txtBuscar;
        private DataGridView dgvCategorias;
        private GroupBox grpDatos;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}