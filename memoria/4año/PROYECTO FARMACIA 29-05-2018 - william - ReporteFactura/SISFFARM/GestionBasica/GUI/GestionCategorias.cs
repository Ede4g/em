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
    public partial class GestionCategorias : Form
    {
        BindingSource _CATEGORIAS = new BindingSource();

        private void CargarDatos()
        {
            _CATEGORIAS.DataSource = CacheController.Cache.TODAS_LAS_CATEGORIAS();
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _CATEGORIAS.Filter = "Nombre LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _CATEGORIAS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _CATEGORIAS;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionCategorias()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionCategoria frm = new EdicionCategoria();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionCategoria frm = new EdicionCategoria();
                    frm.txbIDCategoria.Text = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    frm.txbNombre.Text = dtgRegistros.CurrentRow.Cells[1].Value.ToString();
                    frm.txbDescripcion.Text = dtgRegistros.CurrentRow.Cells[2].Value.ToString();
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
                    CLS.Categoria oCategoria = new CLS.Categoria();
                    oCategoria.IDCategoria = dtgRegistros.CurrentRow.Cells[0].Value.ToString();
                    if (oCategoria.Eliminar())
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

        private void GestionCategorias_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
