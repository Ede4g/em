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
    public partial class EdicionEmpleado : Form
    {
        public EdicionEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Empleado oEmpleado = new CLS.Empleado();
            oEmpleado.IDEmpleado = txbIDEmpleado.Text;
            oEmpleado.Nombres = txbNombres.Text;
            oEmpleado.Apellidos = txbApellidos.Text;
            oEmpleado.FechaNacimiento = dtpFechaNacimiento.Value.ToString();
            oEmpleado.Genero = cbbGenero.SelectedItem.ToString();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
