using MiTiendaPOS.Models;
using MiTiendaPOS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTiendaPOS.Forms
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaService _servicio = new();
        private int _idseleccionado = 0; // Para registrar nuevo
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LimpiarCategorias();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = _servicio.Listar(txtBuscar.Text)
            .Select(c => new { c.Id, c.Nombre })
            .ToList();
        }
        private void LimpiarCategorias()
        {
            _idseleccionado = 0;
            txtNombre.Clear();
            btnEliminar.Enabled = false;
            dgvCategorias.ClearSelection();
            txtNombre.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvCategorias.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells["Id"].Value);
            Categoria? categoria = _servicio.ObtenerPorId(id);
            if (categoria == null) return;

            _idseleccionado = categoria.Id;
            txtNombre.Text = categoria.Nombre;
            btnEliminar.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCategorias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try

            {
                var categoria = new Categoria
                {
                    Id = _idseleccionado,
                    Nombre = txtNombre.Text
                };
                if (_idseleccionado == 0)
                    _servicio.Crear(categoria);
                else
                    _servicio.Actualizar(categoria);
                MessageBox.Show("Categoría guardada con exito.", "MiTiendaPOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {                 MessageBox.Show(ex.Message, "No se pudo guardar la categoría", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }    
    }
}