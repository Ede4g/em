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
    public partial class Permisos : Form
    {
        BindingSource _PERMISOS = new BindingSource();
        private void CargarPermisos()
        {
            try
            {
                _PERMISOS.DataSource = CacheController.Cache.PERMISOS_ASIGNADOS(cbbRoles.SelectedValue.ToString());
                dtgPermisos.AutoGenerateColumns = false;
                dtgPermisos.DataSource = _PERMISOS;
            }catch{}
        }
        private void CargarRoles()
        {
            try
            {
                DataTable Roles = new DataTable();
                Roles = CacheController.Cache.TODOS_LOS_ROLES();
                cbbRoles.DataSource = Roles;
                cbbRoles.DisplayMember = "Rol";
                cbbRoles.ValueMember = "IDRol";
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            try
            {
                dtgPermisos.AutoGenerateColumns = false;
                dtgPermisos.DataSource = _PERMISOS;
                lblNumeroRegistros.Text = dtgPermisos.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public Permisos()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void cbbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void dtgPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CLS.MyMessageBox.ShowMessage("ESTA SEGURO QUE DESEA EDITAR EL PERMISO?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (e.ColumnIndex == 0)
                    {
                        if (dtgPermisos.CurrentRow.Cells["Asignado"].Value.ToString().Equals("1"))
                        {
                            //REVOCAR
                            CLS.Permiso oPermiso = new CLS.Permiso();
                            oPermiso.IDPermiso = dtgPermisos.CurrentRow.Cells["IDPermiso"].Value.ToString();
                            if (oPermiso.Revocar())
                            {
                                CargarPermisos();
                            }
                        }
                        else
                        {
                            //CONCEDER
                            CLS.Permiso oPermiso = new CLS.Permiso();
                            oPermiso.IDOpcion = dtgPermisos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                            oPermiso.IDRol = cbbRoles.SelectedValue.ToString();
                            if (oPermiso.Conceder())
                            {
                                CargarPermisos();
                            }
                        }
                    }
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Ocurrió un Error a la hora de modificar el permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
