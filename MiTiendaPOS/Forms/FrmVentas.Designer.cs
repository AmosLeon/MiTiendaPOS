namespace MiTiendaPOS.Forms
{
    partial class FrmVentas
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
            grpEncabezado = new GroupBox();
            lblVenta = new Label();
            cboUsuario = new ComboBox();
            cboCliente = new ComboBox();
            lblUsuario = new Label();
            lblCliente = new Label();
            grpHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            grpDetalle = new GroupBox();
            dgvDetalle = new DataGridView();
            btnQuitar = new Button();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            lblCantidad = new Label();
            lblTotal = new Label();
            lblProducto = new Label();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpEncabezado.SuspendLayout();
            grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 12);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(638, 135);
            grpEncabezado.TabIndex = 0;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = "Encabezado de la venta ";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(6, 99);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(122, 25);
            lblVenta.TabIndex = 2;
            lblVenta.Text = "Venta nueva";
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(411, 42);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(221, 33);
            cboUsuario.TabIndex = 2;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(92, 42);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(221, 33);
            cboCliente.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(319, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(6, 45);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(80, 25);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(dgvVentas);
            grpHistorial.Location = new Point(666, 12);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(441, 580);
            grpHistorial.TabIndex = 1;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(6, 30);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(429, 496);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Location = new Point(12, 153);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(638, 361);
            grpDetalle.TabIndex = 2;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de productos ";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(6, 76);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(626, 217);
            dgvDetalle.TabIndex = 5;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(6, 321);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(139, 34);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "Quitar línea";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(493, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(370, 38);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 31);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(112, 37);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(182, 33);
            cboProducto.TabIndex = 0;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(300, 40);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(64, 25);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cant.:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(385, 326);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(124, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total: $0.00 ";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(6, 40);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(100, 25);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto:";
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(18, 547);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(180, 45);
            btnNueva.TabIndex = 3;
            btnNueva.Text = "Nueva venta";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(223, 547);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 45);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(433, 547);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar venta ";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 604);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNueva);
            Controls.Add(grpDetalle);
            Controls.Add(grpHistorial);
            Controls.Add(grpEncabezado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Ventas";
            Load += FrmVentas_Load;
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEncabezado;
        private ComboBox cboCliente;
        private Label lblUsuario;
        private Label lblCliente;
        private GroupBox grpHistorial;
        private ComboBox cboUsuario;
        private Label lblVenta;
        private GroupBox grpDetalle;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private ComboBox cboProducto;
        private Label lblCantidad;
        private Label lblProducto;
        private DataGridView dgvVentas;
        private DataGridView dgvDetalle;
        private Button btnQuitar;
        private Label lblTotal;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}