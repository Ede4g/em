using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI
{
    public partial class GestionProductos : Form
    {
        BindingSource _PRODUCTOS = new BindingSource();

        String _IDProducto;
        String _Producto;
        String _Precio;
        Boolean _Seleccionado = false;

        public string IDProducto1
        {
            get{return _IDProducto;}
        }

        public bool Seleccionado
        {
            get{return _Seleccionado;}
        }

        public string Producto
        {
            get{return _Producto;}
        }

        public string Precio
        {
            get{return _Precio;}
        }

        private void CargarDatos()
        {
            _PRODUCTOS.DataSource = CacheController.Cache.TODOS_LOS_PRODUCTOS();
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    if (rbNombre.Checked == true)
                    {
                        _PRODUCTOS.Filter = "Nombre LIKE '%" + txtFiltro.Text + "%'";
                    }
                    else if(rbCategoria.Checked == true)
                    {
                        _PRODUCTOS.Filter = "Categoria LIKE '%" + txtFiltro.Text + "%'";
                    }
                }
                else
                {
                    _PRODUCTOS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _PRODUCTOS;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionProducto frm = new EdicionProducto();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLS.MyMessageBox.ShowMessage("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionProducto frm = new EdicionProducto();
                    frm.txbIDProducto.Text = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    frm.txbNombre.Text = dtgRegistros.CurrentRow.Cells[1].Value.ToString();
                    frm.txtAlias.Text = dtgRegistros.CurrentRow.Cells[2].Value.ToString();
                    frm.txbCodigo.Text = dtgRegistros.CurrentRow.Cells[3].Value.ToString();
                    frm.cbbCategoria.SelectedValue = dtgRegistros.CurrentRow.Cells[4].Value;
                    frm.nupPrecio.Text = dtgRegistros.CurrentRow.Cells[6].Value.ToString();
                    frm.nupCosto.Text = dtgRegistros.CurrentRow.Cells[7].Value.ToString();
                    frm.txbDescripcion.Text = dtgRegistros.CurrentRow.Cells[8].Value.ToString();
                    frm.ShowDialog();
                    CargarDatos();
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Ocurrió un Error a la hora de EDITAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (CLS.MyMessageBox.ShowMessage("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Producto oProducto = new CLS.Producto();
                    oProducto.IDProducto = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    if (oProducto.Eliminar())
                    {
                        CLS.MyMessageBox.ShowMessage("Eliminado");
                        CargarDatos();
                    }
                    else
                    {
                        CLS.MyMessageBox.ShowMessage("Falló la eliminación");
                    }
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Ocurrió un Error a la hora de ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
            _IDProducto = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
            _Producto = dtgRegistros.CurrentRow.Cells[1].Value.ToString();
            _Precio = dtgRegistros.CurrentRow.Cells[6].Value.ToString();
            _Seleccionado = true;
            Close();
        }
    }
}
