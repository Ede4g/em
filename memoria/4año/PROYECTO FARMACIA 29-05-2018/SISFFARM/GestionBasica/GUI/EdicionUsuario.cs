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
                MessageBox.Show("Ocurrio un Error al cargar los Roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al seleccionar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    {
                        //ACTUALIZAR
                        if (cbCambiar.Checked == true)
                        {
                            if (oUsuario.ActualizarCN())
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
                else
                {
                    MessageBox.Show("Tiene que llenar los campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un Error a la hora de GUARDAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor solo puede escribir Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsuario.Focus();
                e.Handled = true;
                { }
            }
        }
    }
}
