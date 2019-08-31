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
        /*private void CargarDatos()
        {
            _ROLES.DataSource = CacheController.Cache.TODOS_LOS_ROLES();
            FiltrarLocalmente();
        }*/
        private void FiltrarLocalmente()
        {
            try
            {
                if(txtFiltro.TextLength>0)
                {
                    _ROLES.Filter="Rol LIKE '%"+txtFiltro.Text+"%'";
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
            //CargarDatos();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionRol frm = new EdicionRol();
            frm.ShowDialog();
            //CargarDatos();
        }
    }
}
