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
    public partial class EdicionRol : Form
    {
        public EdicionRol()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbRol.Text != "")
                {
                    CLS.Rol oRol = new CLS.Rol();
                    oRol.IDRol = txbIDRol.Text;
                    oRol.NombreRol = txbRol.Text;
                    if (txbIDRol.TextLength > 0)
                    {
                        //ACTUALIZAR
                        if (oRol.Actualizar())
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
                        if (oRol.Insertar())
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

        private void txbRol_KeyPress(object sender, KeyPressEventArgs e)
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
                txbRol.Focus();
                e.Handled = true;
                { }
            }
        }
    }
}
