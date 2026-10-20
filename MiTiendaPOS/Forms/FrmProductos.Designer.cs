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
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
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
            grpDatos.Location = new Point(20, 23);
            grpDatos.Margin = new Padding(4, 5, 4, 5);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 5, 4, 5);
            grpDatos.Size = new Size(479, 875);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del producto";
            // 
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModo.Location = new Point(21, 50);
            lblModo.Margin = new Padding(4, 0, 4, 0);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(148, 25);
            lblModo.TabIndex = 0;
            lblModo.Text = "Producto nuevo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(21, 130);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 125);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(315, 31);
            txtNombre.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(21, 213);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(99, 25);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(136, 208);
            cboCategoria.Margin = new Padding(4, 5, 4, 5);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(315, 33);
            cboCategoria.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(21, 297);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 25);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudPrecio.Location = new Point(136, 292);
            nudPrecio.Margin = new Padding(4, 5, 4, 5);
            nudPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(171, 31);
            nudPrecio.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(21, 380);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(65, 25);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(136, 375);
            nudStock.Margin = new Padding(4, 5, 4, 5);
            nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(171, 31);
            nudStock.TabIndex = 8;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(136, 458);
            chkActivo.Margin = new Padding(4, 5, 4, 5);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(88, 29);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(21, 775);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(136, 63);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(171, 775);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 63);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(317, 775);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 63);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(521, 37);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(75, 25);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(599, 30);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(263, 31);
            txtBuscar.TabIndex = 2;
            txtBuscar.TextChanged += Filtros_Changed;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltro.Location = new Point(886, 37);
            lblFiltro.Margin = new Padding(4, 0, 4, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(99, 25);
            lblFiltro.TabIndex = 3;
            lblFiltro.Text = "Categoría:";
            // 
            // cboFiltroCategoria
            // 
            cboFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroCategoria.FormattingEnabled = true;
            cboFiltroCategoria.Location = new Point(984, 30);
            cboFiltroCategoria.Margin = new Padding(4, 5, 4, 5);
            cboFiltroCategoria.Name = "cboFiltroCategoria";
            cboFiltroCategoria.Size = new Size(284, 33);
            cboFiltroCategoria.TabIndex = 4;
            cboFiltroCategoria.SelectedIndexChanged += Filtros_Changed;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(521, 97);
            dgvProductos.Margin = new Padding(4, 5, 4, 5);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(749, 802);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 935);
            Controls.Add(dgvProductos);
            Controls.Add(cboFiltroCategoria);
            Controls.Add(lblFiltro);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Label lblFiltro;
        private ComboBox cboFiltroCategoria;
        private DataGridView dgvProductos;
    }
}