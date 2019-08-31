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
    public partial class EdicionCliente : Form
    {
        public EdicionCliente()
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
                if (txbNombres.Text != "" && txbApellidos.Text != "" && txbDirección.Text != "" && txbTelefono.Text != "")
                {
                    CLS.Cliente oCliente = new CLS.Cliente();
                    oCliente.IDCliente = txbIDCliente.Text;
                    oCliente.Nombres = txbNombres.Text;
                    oCliente.Apellidos = txbApellidos.Text;
                    oCliente.Direccion = txbDirección.Text;
                    oCliente.Telefono = txbTelefono.Text;
                    if (txbIDCliente.TextLength > 0)
                    {
                        //ACTUALIZAR
                        if (oCliente.Actualizar())
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
                        if (oCliente.Insertar())
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

        private void txbNombres_KeyPress(object sender, KeyPressEventArgs e)
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
                txbNombres.Focus();
                e.Handled = true;
                { }
            }
        }

        private void txbApellidos_KeyPress(object sender, KeyPressEventArgs e)
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
                txbApellidos.Focus();
                e.Handled = true;
                { }
            }
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
                MessageBox.Show("Por favor solo puede escribir Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTelefono.Focus();
                e.Handled = true;
                { }
            }
        }

    }
}
