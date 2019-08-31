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
    public partial class GestionRoles : Form
    {
        BindingSource _ROLES = new BindingSource();
        private void CargarDatos()
        {
            _ROLES.DataSource = CacheController.Cache.TODOS_LOS_ROLES();
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _ROLES.Filter = "Rol LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _ROLES.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _ROLES;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionRoles()
        {
            InitializeComponent();
        }
        private void GestionRoles_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionRol frm = new EdicionRol();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionRol frm = new EdicionRol();
                frm.txtIDRol.Text = dtgRegistros.CurrentRow.Cells["IDRol"].Value.ToString();
                frm.txtRol.Text = dtgRegistros.CurrentRow.Cells["Rol"].Value.ToString();
                frm.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Rol oRol = new CLS.Rol();
                oRol.IDRol = dtgRegistros.CurrentRow.Cells["IDRol"].Value.ToString();
                if (oRol.Eliminar())
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
    }
}
