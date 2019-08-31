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
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionClientes frm = new GUI.GestionClientes();
                frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra4.Visible = false;
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

        List<CLS.DetalleFactura> _ListaDetalle = new List<CLS.DetalleFactura>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value.ToString() == "" && txbPrecio.Text =="" && txbIDProducto.Text =="" && txbIDFactura.Text =="" && txbDescripcion.Text =="")
            {
                MessageBox.Show("Complete los campos correspondiente");
            }
            else
            {
                /*CLS.DetalleFactura _Detalle = new CLS.DetalleFactura();
                _Detalle.Cantidad = nudCantidad.Value.ToString();
                _Detalle.NombreProducto = txbProducto.Text;
                _Detalle.Precio = txbPrecio.Text;
                _Detalle.IDProducto = txbIDProducto.Text;

                _ListaDetalle.Add(_Detalle);

                //dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = _ListaDetalle;
                dgvDetalles.CurrentRow.Cells[0].Value = _ListaDetalle[0];*/

                dgvDetalles.Rows.Add(nudCantidad.Value.ToString(), txbProducto.Text,txbPrecio.Text,txbExcento.Text,txbNoSujeto.Text,txbGravado.Text,txbIDProducto.Text);
                nudCantidad.Text = "0.00";
                txbProducto.Text = "0.00";
                txbIDProducto.Text = "0.00";
                txbPrecio.Text = "0.00";
                txbExcento.Text = "0.00";
                txbNoSujeto.Text = "0.00";
                txbGravado.Text = "0.00";
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0)
            {
                if (txbPrecio.Text !="0.00" && cbbTipoDeVenta.SelectedIndex == 1)
                {
                    txbGravado.Text = "0.00";
                    txbExcento.Text = "0.00";
                    txbGravado.Text = Convert.ToString(Convert.ToDouble(nudCantidad.Value) * Convert.ToDouble(txbPrecio.Text));
                }
                else if (txbPrecio.Text != "0.00" && cbbTipoDeVenta.SelectedIndex == 0)
                {
                    txbGravado.Text = "0.00";
                    txbNoSujeto.Text = "0.00";
                    txbGravado.Text = Convert.ToString(Convert.ToDouble(nudCantidad.Value) * Convert.ToDouble(txbPrecio.Text));
                }
                else
                {
                    txbGravado.Text = "0.00";
                    txbExcento.Text = "0.00";
                    txbGravado.Text = Convert.ToString(Convert.ToDouble(nudCantidad.Value) * Convert.ToDouble(txbPrecio.Text));
                }
            }
            else
            {
                txbExcento.Text = "0.00";
                txbGravado.Text = "0.00";
                txbNoSujeto.Text = "0.00";
            }
        }

        private void txbGravado_TextChanged(object sender, EventArgs e)
        {
            if(txbGravado.Text != "")
            {
                //txbGravado.Text =Convert.ToString(Convert.ToDouble(txbGravado.Text)+Convert.ToDouble(txbGravado.Text));
                txbMontoDeIVA.Text =Convert.ToString(Convert.ToDouble(txbGravado.Text) * 0.13);
            }
        }
    }
}
