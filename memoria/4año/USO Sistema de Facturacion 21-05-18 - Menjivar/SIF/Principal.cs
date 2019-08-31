using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF
{
    public partial class Principal : Form
    {
        SessionController.Sesion _SESION = SessionController.Sesion.Instance;
        public Principal()
        {
            _SESION.Usuario = "JORGE";
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _SESION.Usuario;
            this.WindowState = FormWindowState.Maximized;
        }

        private void rolesDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_SESION.ComprobarPermiso(4))
            {
                GestionBasica.GUI.GestionRoles frm = new GestionBasica.GUI.GestionRoles();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.Permisos frm = new GestionBasica.GUI.Permisos();
            frm.ShowDialog();
        }

        private void libroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.VisorLibroVentas frm = new GUI.VisorLibroVentas();
            frm.Show();
        }
    }
}
