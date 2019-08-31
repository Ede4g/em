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
    public partial class EdicionUsuario : Form
    {
        public EdicionUsuario()
        {
            InitializeComponent();
            //CargarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Usuario oUsuario = new CLS.Usuario();
            oUsuario.IDUsuario = txbIDUsuario.Text;
            oUsuario.NombreUsuario = txbUsuario.Text;
            oUsuario.Credencial = txbCredencial.Text;
            oUsuario.IDEmpleado = txbIDEmpleado.Text;
            oUsuario.IDRol = cbbRol.SelectedValue.ToString();

            if (txbIDUsuario.TextLength > 0)
            {
                //ACTUALIZAR
                if (oUsuario.Actualizar())
                {
                    MessageBox.Show("Actualizado");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falló la Actualización");
                }
            }
            else
            {
                //INSERTAR
                if (oUsuario.Insertar())
                {
                    MessageBox.Show("Insertado");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falló la Inserción");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       /* private void CargarRoles()
        {
            DataTable Roles = new DataTable();
            Roles = CacheController.Cache.TODOS_LOS_ROLES();
            cbbRol.DataSource = Roles;
            cbbRol.DisplayMember = "Rol";
            cbbRol.ValueMember = "IDRol";
        }*/

        private void btnGestionEmpleado_Click_1(object sender, EventArgs e)
        {
            GUI.GestionEmpleados frm = new GUI.GestionEmpleados();
            frm.ShowDialog();

            if (frm.Seleccionado == true)
            {
                txbIDEmpleado.Text = frm.IDEmpleado1;
                txbEmpleados.Text = frm.Empleado;
            }
        }
    }
}
