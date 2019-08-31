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
    public partial class GestionClientes : Form
    {
        BindingSource _CLIENTES = new BindingSource();

        String _IDCliente;
        String _Cliente;
        Boolean _Seleccionado = false;

        public string IDCliente1
        {
            get {return _IDCliente;}
        }

        public bool Seleccionado
        {
            get{return _Seleccionado;}
        }

        public string Cliente
        {
            get{return _Cliente;}
        }

        private void CargarDatos()
        {
            _CLIENTES.DataSource = CacheController.Cache.TODOS_LOS_CLIENTES();
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
                        _CLIENTES.Filter = "Nombres LIKE '%" + txtFiltro.Text + "%'";
                    }
                    else if(rbApellidos.Checked == true)
                    {
                        _CLIENTES.Filter = "Apellidos LIKE '%" + txtFiltro.Text + "%'";
                    }
                }
                else
                {
                    _CLIENTES.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _CLIENTES;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionCliente frm = new EdicionCliente();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLS.MyMessageBox.ShowMessage("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionCliente frm = new EdicionCliente();
                    frm.txbIDCliente.Text = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    frm.txbNombres.Text = dtgRegistros.CurrentRow.Cells[1].Value.ToString();
                    frm.txbApellidos.Text = dtgRegistros.CurrentRow.Cells[2].Value.ToString();
                    frm.txbDirección.Text = dtgRegistros.CurrentRow.Cells[3].Value.ToString();
                    frm.txbTelefono.Text = dtgRegistros.CurrentRow.Cells[4].Value.ToString();
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
                    CLS.Cliente oCliente = new CLS.Cliente();
                    oCliente.IDCliente = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    if (oCliente.Eliminar())
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

        private void GestionClientes_Load(object sender, EventArgs e)
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
            _IDCliente = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
            _Cliente = dtgRegistros.CurrentRow.Cells[1].Value.ToString();
            _Seleccionado = true;
            Close();
        }
    }
}
