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
    public partial class GestionFacturasDeVentas : Form
    {
        BindingSource _FACTURASDEVENTAS = new BindingSource();

        private void CargarDatos()
        {
            _FACTURASDEVENTAS.DataSource = CacheController.Cache.TODAS_LAS_FACTURAS();
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    if (rbFecha.Checked == true)
                    {
                        _FACTURASDEVENTAS.Filter = "FechaDeVenta LIKE '%" + txtFiltro.Text + "%'";
                    }
                    else if(rbCliente.Checked == true)
                    {
                        _FACTURASDEVENTAS.Filter = "Cliente LIKE '%" + txtFiltro.Text + "%'";
                    }
                }
                else
                {
                    _FACTURASDEVENTAS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _FACTURASDEVENTAS;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionFacturasDeVentas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionFacturaDeVenta frm = new EdicionFacturaDeVenta();
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

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

    }
}
