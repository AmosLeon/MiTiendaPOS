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
            cboUsuario = new ComboBox();
            cboCliente = new ComboBox();
            lblUsuario = new Label();
            lblCliente = new Label();
            grpHistorial = new GroupBox();
            lblVenta = new Label();
            grpDetalle = new GroupBox();
            cboProducto = new ComboBox();
            lblProducto = new Label();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnQuitar = new Button();
            dgvDetalle = new DataGridView();
            dgvVentas = new DataGridView();
            label1 = new Label();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpEncabezado.SuspendLayout();
            grpHistorial.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
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
            grpHistorial.Size = new Size(320, 580);
            grpHistorial.TabIndex = 1;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de Ventas";
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
            // grpDetalle
            // 
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(label1);
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Location = new Point(12, 153);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(638, 361);
            grpDetalle.TabIndex = 2;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de productos ";
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
            // btnAgregar
            // 
            btnAgregar.Location = new Point(493, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(6, 321);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(139, 34);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "Quitar línea";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(6, 76);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(626, 217);
            dgvDetalle.TabIndex = 5;
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(6, 30);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(308, 472);
            dgvVentas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 326);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 2;
            label1.Text = "Total: $0.00 ";
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(18, 547);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(180, 45);
            btnNueva.TabIndex = 3;
            btnNueva.Text = "Nueva venta";
            btnNueva.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(223, 547);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 45);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(433, 547);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar venta ";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 604);
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
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpHistorial.ResumeLayout(false);
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
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
        private Label label1;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}