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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS.Rol oRol = new CLS.Rol();
            oRol.IDRol = txtIDRol.Text;
            oRol.NombreRol = txtRol.Text;
            if(txtIDRol.TextLength>0)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
