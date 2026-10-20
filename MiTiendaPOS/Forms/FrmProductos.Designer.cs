namespace MiTiendaPOS.Forms
{
    partial class FrmProductos
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
            grpDatos = new GroupBox();
            btnReactivar = new Button();
            lblModo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            cboCategoria = new ComboBox();
            lblPrecio = new Label();
            nudPrecio = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            chkActivo = new CheckBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            lblFiltro = new Label();
            cboFiltroCategoria = new ComboBox();
            dgvProductos = new DataGridView();
            lblResumen = new Label();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnReactivar);
            grpDatos.Controls.Add(lblModo);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblCategoria);
            grpDatos.Controls.Add(cboCategoria);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(nudPrecio);
            grpDatos.Controls.Add(lblStock);
            grpDatos.Controls.Add(nudStock);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(btnNuevo);
            grpDatos.Controls.Add(btnGuardar);
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Location = new Point(14, 14);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(335, 525);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del producto";
            // 
            // btnReactivar
            // 
            btnReactivar.Location = new Point(15, 418);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(302, 35);
            btnReactivar.TabIndex = 13;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Visible = false;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModo.Location = new Point(15, 30);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(95, 15);
            lblModo.TabIndex = 0;
            lblModo.Text = "Producto nuevo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(15, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 75);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(15, 128);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(63, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(95, 125);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(222, 23);
            cboCategoria.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(15, 178);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(45, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudPrecio.Location = new Point(95, 175);
            nudPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(15, 228);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(95, 225);
            nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(120, 23);
            nudStock.TabIndex = 8;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(95, 275);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(15, 465);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(95, 38);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(118, 465);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 38);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(222, 465);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 38);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(365, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(48, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(419, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(185, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += Filtros_Changed;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltro.Location = new Point(620, 22);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(63, 15);
            lblFiltro.TabIndex = 3;
            lblFiltro.Text = "Categoría:";
            // 
            // cboFiltroCategoria
            // 
            cboFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroCategoria.FormattingEnabled = true;
            cboFiltroCategoria.Location = new Point(689, 18);
            cboFiltroCategoria.Name = "cboFiltroCategoria";
            cboFiltroCategoria.Size = new Size(200, 23);
            cboFiltroCategoria.TabIndex = 4;
            cboFiltroCategoria.SelectedIndexChanged += Filtros_Changed;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(365, 58);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(524, 445);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellFormatting += dgvProductos_CellFormatting;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResumen.Location = new Point(365, 515);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(130, 15);
            lblResumen.TabIndex = 6;
            lblResumen.Text = "Resumen del inventario";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 561);
            Controls.Add(lblResumen);
            Controls.Add(dgvProductos);
            Controls.Add(cboFiltroCategoria);
            Controls.Add(lblFiltro);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mantenimiento de Productos";
            Load += FrmProductos_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatos;
        private Label lblModo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblPrecio;
        private NumericUpDown nudPrecio;
        private Label lblStock;
        private NumericUpDown nudStock;
        private CheckBox chkActivo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnReactivar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Label lblFiltro;
        private ComboBox cboFiltroCategoria;
        private DataGridView dgvProductos;
        private Label lblResumen;
    }
}