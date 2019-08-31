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
            cbbTipoDeVenta.SelectedIndex = 1;
        }

        String _IDFactura;

        public string IDFactura
        {
            get{return _IDFactura;}

            set{_IDFactura = value;}
        }

        BindingSource _DETALLES_DE_PRODUCTOS = new BindingSource();
        private void CargarDatos()
        {
            _DETALLES_DE_PRODUCTOS.DataSource = CacheController.Cache.TODOS_LOS_DETALLES(_IDFactura);
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionClientes frm = new GUI.GestionClientes();
                //frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra2.Visible = false;
                frm.lblbarra3.Visible = false;
                frm.lblbarra4.Visible = true;
                frm.ShowDialog();
                if (frm.Seleccionado)
                {
                    txbIDCliente.Text = frm.IDCliente1;
                    txbCliente.Text = frm.Cliente;
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Error al seleccionar el cliente","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionEmpleados frm = new GUI.GestionEmpleados();
                //frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra2.Visible = false;
                frm.lblbarra3.Visible = false;
                frm.lblbarra4.Visible = true;
                frm.ShowDialog();
                if (frm.Seleccionado)
                {
                    txbIDEmpleado.Text = frm.IDEmpleado1;
                    txbEmpleado.Text = frm.Empleado;
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Error al seleccionar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionProductos frm = new GUI.GestionProductos();
                //frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra2.Visible = false;
                frm.lblbarra3.Visible = false;
                frm.lblbarra4.Visible = true;
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
                CLS.MyMessageBox.ShowMessage("Error al seleccionar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            double TotalGravado = 0;
            double TotalExento = 0;
            double TotalNoSujeto = 0;

            if(txbIDProducto.TextLength > 0 && nudCantidad.Value !=0)
            {
                dgvDetalles.Rows.Add(Convert.ToInt32(nudCantidad.Value), txbProducto.Text, Convert.ToDouble(txbPrecio.Text), Convert.ToDouble(txbExcento.Text), Convert.ToDouble(txbNoSujeto.Text), Convert.ToDouble(txbGravado.Text), txbIDProducto.Text);
                nudCantidad.Text = "0.00";
                txbProducto.Text = "";
                txbIDProducto.Text = "";
                txbPrecio.Text = "0.00";
                txbExcento.Text = "0.00";
                txbNoSujeto.Text = "0.00";
                txbGravado.Text = "0.00";
            }
            else
            {
                CLS.MyMessageBox.ShowMessage("seleccione un producto");
            }

            if(dgvDetalles.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetalles.Rows)
                {
                    TotalGravado += Convert.ToDouble(row.Cells[5].Value.ToString());
                    TotalExento += Convert.ToDouble(row.Cells[3].Value.ToString());
                    TotalNoSujeto += Convert.ToDouble(row.Cells[4].Value.ToString());
                }
                txbTotalGravado.Text = TotalGravado.ToString();
                txbTotalExento.Text = TotalExento.ToString();
                txbTotalNoSujeto.Text = TotalNoSujeto.ToString();

                txbTotalAPagar.Text = Convert.ToString(TotalExento + TotalGravado);
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txbGravado_TextChanged(object sender, EventArgs e)
        {
            if(txbGravado.Text != "")
            {
                //txbGravado.Text =Convert.ToString(Convert.ToDouble(txbGravado.Text)+Convert.ToDouble(txbGravado.Text));
                //txbMontoDeIVA.Text =Convert.ToString(Convert.ToDouble(txbGravado.Text) * 0.13);
            }
        }

        private void Calculo()
        {
            int IndexSelect = cbbTipoDeVenta.FindString(cbbTipoDeVenta.Text);
            Double IVA = 0.00;
            IVA = Convert.ToDouble(txbPrecio.Text) * 0.13;
            Double PSinIva = Convert.ToDouble(txbPrecio.Text) - IVA;

            switch (IndexSelect)
            {
                case 0:
                    txbNoSujeto.Text = "0.00";
                    txbGravado.Text = "0.00";
                    txbExcento.Text = Convert.ToString(Convert.ToDouble(nudCantidad.Value) * PSinIva);
                    break;
                case 1:
                    txbNoSujeto.Text = "0.00";
                    txbExcento.Text = "0.00";
                    txbGravado.Text = Convert.ToString(Convert.ToDouble(nudCantidad.Value) * Convert.ToDouble(txbPrecio.Text));
                    break;
                case 2:
                    txbExcento.Text = "0.00";
                    txbGravado.Text = "0.00";
                    txbNoSujeto.Text = Convert.ToString(Convert.ToDouble(nudCantidad.Value) * PSinIva);
                    break;
            }
            
        }
        private void txbPrecio_TextChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void cbbTipoDeVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void cbbTipoDeVenta_SelectedValueChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void btnGuardarFact_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txbIDCliente.Text != "" && txbIDEmpleado.Text != "" && txbNumFact.Text != "" && dtpFecha.Text != "")
            //    {
                    CLS.FacturaDeVenta oFacturaDeVenta = new CLS.FacturaDeVenta();
                    oFacturaDeVenta.IDFacturaDeVenta = txbIDFactura.Text;
                    oFacturaDeVenta.Fecha = dtpFecha.Value.ToString("yyyy/MM/dd");
                    oFacturaDeVenta.FormaDePago = cbbFormaDePago.Text;
                    oFacturaDeVenta.IDCliente = txbIDCliente.Text;
                    oFacturaDeVenta.IDEmpleado = txbIDEmpleado.Text;
                    oFacturaDeVenta.NumeroDeFactura = txbNumFact.Text;
                    oFacturaDeVenta.TotalAPagar = txbTotalAPagar.Text;
            oFacturaDeVenta.Insertar();

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                String IDFactura = CacheController.Cache.CONSULTAR_ID_FACTURA().Rows[0]["IdFactura"].ToString();
                CLS.DetalleFactura oDetalleFactura = new CLS.DetalleFactura();
                oDetalleFactura.Cantidad = row.Cells[0].Value.ToString();
                oDetalleFactura.Precio = row.Cells[2].Value.ToString();
                oDetalleFactura.NombreProducto = row.Cells[1].Value.ToString();
                oDetalleFactura.IDProducto = row.Cells[6].Value.ToString();
                oDetalleFactura.IDFacturaDeVenta = IDFactura;
                oDetalleFactura.Exento = row.Cells[3].Value.ToString();
                oDetalleFactura.Gravado = row.Cells[5].Value.ToString();
                oDetalleFactura.NoSujeto = row.Cells[4].Value.ToString();
                oDetalleFactura.Insertar();
            }
            //if (txbIDFactura.TextLength > 0)
            //{
            //    //ACTUALIZAR
            //    if (oFacturaDeVenta.Actualizar())
            //    {
            //        CLS.MyMessageBox.ShowMessage("Actualizado");
            //        Close();
            //            }
            //            else
            //            {
            //                CLS.MyMessageBox.ShowMessage("Falló la Actualización");
            //            }
            //        }
            //        else
            //        {
            //            //INSERTAR
            //            if (oFacturaDeVenta.Insertar())
            //            {
            //                MessageBox.Show("Insertado");
            //                Close();
            //            }
            //            else
            //            {
            //                CLS.MyMessageBox.ShowMessage("Falló la Inserción");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        CLS.MyMessageBox.ShowMessage("Tiene que llenar los campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch
            //{
            //    CLS.MyMessageBox.ShowMessage("Ocurrio un Error a la hora de GUARDAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalles.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvDetalles.Rows)
                    {
                        CLS.DetalleFactura oDetalleFactura = new CLS.DetalleFactura();
                        oDetalleFactura.Cantidad = row.Cells[0].Value.ToString();
                        oDetalleFactura.Precio = row.Cells[2].Value.ToString();
                        oDetalleFactura.NombreProducto = row.Cells[1].Value.ToString();
                        oDetalleFactura.IDProducto = row.Cells[6].Value.ToString();
                        //oDetalleFactura.IDFacturaDeVenta = txbNumFact.Text;
                        oDetalleFactura.Exento = row.Cells[3].Value.ToString();
                        oDetalleFactura.Gravado = row.Cells[5].Value.ToString();
                        oDetalleFactura.NoSujeto = row.Cells[4].Value.ToString();
                        oDetalleFactura.Insertar();
                    }
                }
                else
                {
                    CLS.MyMessageBox.ShowMessage("Tiene que llenar los campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Ocurrio un Error a la hora de GUARDAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarDeLista_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
        }

        private void EdicionFacturaDeVenta_Load(object sender, EventArgs e)
        {
            if (txbIDFactura.TextLength > 0)
            {
                CargarDatos();
            }
        }
    }
}
