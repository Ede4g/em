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
    public partial class GestionUsuarios : Form
    {
        BindingSource _USUARIOS = new BindingSource();
        private void CargarDatos()
        {
            _USUARIOS.DataSource = CacheController.Cache.TODOS_LOS_USUARIOS();
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _USUARIOS.Filter = "Usuario LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _USUARIOS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _USUARIOS;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionUsuario frm = new EdicionUsuario();
            frm.ShowDialog();
            CargarDatos();
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionUsuario frm = new EdicionUsuario();
                frm.txbIDUsuario.Text = dtgRegistros.CurrentRow.Cells["IDUsuario"].Value.ToString();
                frm.txbUsuario.Text = dtgRegistros.CurrentRow.Cells["Usuario"].Value.ToString();
                frm.txbCredencial.Text = dtgRegistros.CurrentRow.Cells["Credencial"].Value.ToString();
                frm.txbIDEmpleado.Text = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                frm.cbbRol.SelectedItem = dtgRegistros.CurrentRow.Cells["IDRol"].Value.ToString();
                frm.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Usuario oUsuario = new CLS.Usuario();
                oUsuario.IDUsuario = dtgRegistros.CurrentRow.Cells["IDUsuario"].Value.ToString();
                if (oUsuario.Eliminar())
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

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
