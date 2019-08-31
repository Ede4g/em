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
    public partial class EdicionFacturaDeVenta : Form
    {
        public EdicionFacturaDeVenta()
        {
            InitializeComponent();
            ConfigurarDataTable();
        }

        DataTable _LISTA_PRODUCTOS = new DataTable();

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionClientes frm = new GUI.GestionClientes();
                frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra2.Visible = false;
                frm.lblbarra3.Visible = false;
                frm.lblbarra4.Visible = false;
                frm.ShowDialog();
                if (frm.Seleccionado)
                {
                    txbIDCliente.Text = frm.IDCliente1;
                    txbCliente.Text = frm.Cliente;
                }
            }
            catch
            {
                MessageBox.Show("Error al seleccionar el cliente","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionEmpleados frm = new GUI.GestionEmpleados();
                frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra2.Visible = false;
                frm.lblbarra3.Visible = false;
                frm.lblbarra4.Visible = false;
                frm.ShowDialog();
                if (frm.Seleccionado)
                {
                    txbIDEmpleado.Text = frm.IDEmpleado1;
                    txbEmpleado.Text = frm.Empleado;
                }
            }
            catch
            {
                MessageBox.Show("Error al seleccionar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionProductos frm = new GUI.GestionProductos();
                frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra2.Visible = false;
                frm.lblbarra3.Visible = false;
                frm.lblbarra4.Visible = false;
                frm.ShowDialog();
                if (frm.Seleccionado)
                {
                    txbIDProducto.Text = frm.IDProducto1;
                    txbProducto.Text = frm.Producto;
                    txbPrecio.Text = frm.Precio;
                }
            }
            catch
            {
                MessageBox.Show("Error al seleccionar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public List<CLS.DetalleFactura> MostrarItemsFactura()
        {
            List<CLS.DetalleFactura> _ListaItems = new List<CLS.DetalleFactura>();
            _ListaItems.Add(new CLS.DetalleFactura( txbIDDetalle.Text, nudCantidad.Value.ToString(), txbPrecio.Text, txbProducto.Text,txbIDProducto.Text,txbIDFactura.Text, txbDescripcion.Text));
            return _ListaItems;
        }

        private void ConfigurarDataTable()
        {
            _LISTA_PRODUCTOS.Columns.Add("IDProducto");
            _LISTA_PRODUCTOS.Columns.Add("NombreProducto");
            _LISTA_PRODUCTOS.Columns.Add("Cantidad");
            _LISTA_PRODUCTOS.Columns.Add("PrecioDeVenta");
            _LISTA_PRODUCTOS.Columns.Add("Descripcion");
            dtgDetalles.AutoGenerateColumns = false;
            dtgDetalles.DataSource = _LISTA_PRODUCTOS;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //dtgDetalles.Rows.Add(MostrarItemsFactura());
            if (btnAgregar.Text.Equals("Agregar"))
            {
                DataRow NuevaFila = _LISTA_PRODUCTOS.NewRow();
                NuevaFila["Cantidad"] = nudCantidad.Text;
                NuevaFila["NombreProducto"] = txbProducto.Text;
                NuevaFila["Precio"] = txbPrecio.Text;
                NuevaFila["Descripcion"] = txbDescripcion.Text;
                NuevaFila["IDProducto"] = txbIDProducto.Text;
                _LISTA_PRODUCTOS.Rows.Add(NuevaFila);
                txbIDProducto.Text = "";
                txbProducto.Text = "";
                nudCantidad.Text = "0";
                txbPrecio.Text = "0";
                txbDescripcion.Text = "";
            }
            else
            {
                dtgDetalles.CurrentRow.Cells["Cantidad"].Value = nudCantidad.Value.ToString();
                dtgDetalles.CurrentRow.Cells["NombreProducto"].Value = txbProducto.Text;
                dtgDetalles.CurrentRow.Cells["Precio"].Value = txbPrecio.Text;
                dtgDetalles.CurrentRow.Cells["Descripcion"].Value = txbDescripcion.Text;
                dtgDetalles.CurrentRow.Cells["IDProducto"].Value = txbIDProducto.Text;
            }
        }
    }
}
