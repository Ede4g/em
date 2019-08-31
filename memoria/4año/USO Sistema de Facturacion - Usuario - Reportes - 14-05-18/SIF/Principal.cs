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
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _SESION.Usuario;
            this.WindowState = FormWindowState.Maximized;
        }

        private void rolesDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionRoles frm = new GestionBasica.GUI.GestionRoles();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionEmpleados frm = new GestionBasica.GUI.GestionEmpleados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionUsuarios frm = new GestionBasica.GUI.GestionUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SIF.REP.Reporte frm = new REP.Reporte();
            frm.MdiParent = this;
            frm.Show();
        }

        private void libroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIF.REP.VisorLibroVentas frm = new REP.VisorLibroVentas();
            frm.Show();
        }
    }
}
