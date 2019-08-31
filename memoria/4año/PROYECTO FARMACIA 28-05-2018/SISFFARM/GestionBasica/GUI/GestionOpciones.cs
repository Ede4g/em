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
    public partial class GestionOpciones : Form
    {
        BindingSource _OPCIONES = new BindingSource();

        private void CargarDatos()
        {
            _OPCIONES.DataSource = CacheController.Cache.TODAS_LAS_OPCIONES();
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    if (rbClasificacion.Checked == true)
                    {
                        _OPCIONES.Filter = "Clasificacion LIKE '%" + txtFiltro.Text + "%'";
                    }
                    else if(rbOpcion.Checked == true)
                    {
                        _OPCIONES.Filter = "Opcion LIKE '%" + txtFiltro.Text + "%'";
                    }
                }
                else
                {
                    _OPCIONES.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _OPCIONES;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionOpciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionOpcion frm = new EdicionOpcion();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionOpcion frm = new EdicionOpcion();
                    frm.txbIDOpcion.Text = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    frm.txbOpciones.Text = dtgRegistros.CurrentRow.Cells[1].Value.ToString();
                    frm.txbClasificacion.Text = dtgRegistros.CurrentRow.Cells[2].Value.ToString();
                    frm.ShowDialog();
                    CargarDatos();
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un Error a la hora de EDITAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Opcion oOpcion = new CLS.Opcion();
                    oOpcion.IDOpcion = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    if (oOpcion.Eliminar())
                    {
                        MessageBox.Show("Eliminado");
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Falló la eliminación");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un Error a la hora de ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GestionOpciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
