using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.IO;

namespace GestionBasica.GUI
{
    public partial class EdicionEmpleado : Form
    {
        public EdicionEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pbFotoEmpleado.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();

                if (txbNombres.Text != "" && txbApellidos.Text != "" && txbDireccion.Text  != "" && txbTelefono.Text != "" && cbbGenero.Text != "" &&dtpFechaNacimiento.Text != "")
                {
                    CLS.Empleado oEmpleado = new CLS.Empleado();
                    oEmpleado.IDEmpleado = txbIDEmpleado.Text;
                    oEmpleado.Nombres = txbNombres.Text;
                    oEmpleado.Apellidos = txbApellidos.Text;
                    oEmpleado.Direccion = txbDireccion.Text;
                    oEmpleado.Telefono = txbTelefono.Text;
                    oEmpleado.FechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy/MM/dd");
                    oEmpleado.Genero = cbbGenero.SelectedItem.ToString();
                    oEmpleado.DUI = txbDUI.Text;
                    oEmpleado.Email = txbEmail.Text;
                    oEmpleado.Foto = aByte;
                    if (txbIDEmpleado.TextLength > 0)
                    {
                        //ACTUALIZAR
                        if (oEmpleado.Actualizar())
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
                        if (oEmpleado.Insertar())
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

        private void pbFotoEmpleado_DoubleClick(object sender, EventArgs e)
        {
            ofd.Filter = "Archivo de Imagen |*.jpg| Archivo PNG|*.png|Todos los Archivos|*.*";
            DialogResult resultado = ofd.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pbFotoEmpleado.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txbDUI_KeyPress(object sender, KeyPressEventArgs e)
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
                txbDUI.Focus();
                e.Handled = true;
                { }
            }
        }
    }
}
