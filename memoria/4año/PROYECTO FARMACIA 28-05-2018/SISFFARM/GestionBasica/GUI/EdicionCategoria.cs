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
    public partial class EdicionCategoria : Form
    {
        public EdicionCategoria()
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
                if (txbNombre.Text != "" && txbDescripcion.Text != "")
                {
                    CLS.Categoria oCategoria = new CLS.Categoria();
                    oCategoria.IDCategoria = txbIDCategoria.Text;
                    oCategoria.Nombre = txbNombre.Text;
                    oCategoria.Descripcion = txbDescripcion.Text;
                    if (txbIDCategoria.TextLength > 0)
                    {
                        //ACTUALIZAR
                        if (oCategoria.Actualizar())
                        {
                            CLS.MyMessageBox.ShowMessage("Actualizado");
                            Close();
                        }
                        else
                        {
                            CLS.MyMessageBox.ShowMessage("Falló la Actualización");
                        }
                    }
                    else
                    {
                        //INSERTAR
                        if (oCategoria.Insertar())
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

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
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
                txbNombre.Focus();
                e.Handled = true;
            }
        }
    }
}
