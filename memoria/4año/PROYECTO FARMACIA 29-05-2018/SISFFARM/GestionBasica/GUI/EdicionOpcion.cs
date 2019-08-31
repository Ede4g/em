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
    public partial class EdicionOpcion : Form
    {
        public EdicionOpcion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbOpciones.Text != "" && txbClasificacion.Text != "")
                {
                    CLS.Opcion oOpcion = new CLS.Opcion();
                    oOpcion.IDOpcion = txbIDOpcion.Text;
                    oOpcion.Opciones = txbOpciones.Text;
                    oOpcion.Clasificacion = txbClasificacion.Text;
                    if (txbIDOpcion.TextLength > 0)
                    {
                        //ACTUALIZAR
                        if (oOpcion.Actualizar())
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
                        if (oOpcion.Insertar())
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

        private void txbOpciones_KeyPress(object sender, KeyPressEventArgs e)
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
                txbOpciones.Focus();
                e.Handled = true;
                { }
            }
        }

        private void txbClasificacion_KeyPress(object sender, KeyPressEventArgs e)
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
                txbClasificacion.Focus();
                e.Handled = true;
                { }
            }
        }
    }
}
