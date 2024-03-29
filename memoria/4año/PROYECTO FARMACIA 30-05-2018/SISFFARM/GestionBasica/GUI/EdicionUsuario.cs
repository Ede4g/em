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
            CargarRoles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarRoles()
        {
            try
            {
                DataTable Roles = new DataTable();
                Roles = CacheController.Cache.TODOS_LOS_ROLES();
                cbbRol.DataSource = Roles;
                cbbRol.DisplayMember = "Rol";
                cbbRol.ValueMember = "IDRol";
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Ocurrio un Error al cargar los Roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.GestionEmpleados frm = new GUI.GestionEmpleados();
                frm.btnAgregar.Visible = false;
                frm.btnEditar.Visible = false;
                frm.btnEliminar.Visible = false;
                frm.btnSeleccionar.Visible = true;
                frm.lblbarra2.Visible = false;
                frm.lblbarra3.Visible = false;
                frm.lblbarra4.Visible = false;
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

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            GUI.CambiarCredencial frm = new GUI.CambiarCredencial();
            frm.ShowDialog();

            if (frm.Cambiar)
            {
                cbCambiar.Checked = true;
                txbCredencial.Text = frm.Credencial;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbUsuario.Text != "" && txbCredencial.Text != "" && cbbRol.Text != "")
                {
                    CLS.Usuario oUsuario = new CLS.Usuario();
                    oUsuario.IDUsuario = txbIDUsuario.Text;
                    oUsuario.NombreUsuario = txbUsuario.Text;
                    oUsuario.Credencial = txbCredencial.Text;
                    oUsuario.IDEmpleado = txbIDEmpleado.Text;
                    oUsuario.IDRol = cbbRol.SelectedValue.ToString();

                    if (txbIDUsuario.TextLength > 0)
            ` �     {
          �    a        //ACTUALIZAR
                        id (cbCAmbiar.hecked =? true)
 0        !             {
                   $        i& (oUsuario.ActualizarCN())     � $                    {J                   `        (   CMS.MyMessaceBox.ShoMessagd("Actualizado"!;
!             "        `        Close*);
                    (       }
            !   !  (  0"   (Else
      (    (                {
                      !         CLS.MyMessag�Box.ShgwEessage("Falló �a Actualizaci��n");
  "       `            (    }
       `                }
                $      (eLse
          0        (    {
         !         (        i& (oUsuario.ctual�zar()!*8  !             (      �   {
  $        "                    CLS.MyMgssageBnx.ShowMessage(#Actualizado");
0             !           �     Close();
             (              }J                       p0   else
              �             {
              "    "    �       CLS.MyMessageBox.ShowMessage("Falló la Actualización");
                            }
                        }
                    }
                    else
                    {
                        //INSERTAR
                        if (oUsuario.Insertar())
                        {
                            CLS.MyMessageBox.ShowMessage("Insertado");
                            Close();
                        }
                        else
                        {
                            CLS.MyMessageBox.ShowMessage("Falló la Inserción");
                        }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                CLS.MyMessageBox.ShowMessage("Por favor solo puede escribir Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsuario.Focus();
                e.Handled = true;
                { }
            }
        }
    }
}
