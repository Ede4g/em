using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace SISFFARM
{
    public partial class MenuPrincipal : Form
    {
        SessionController.Sesion _SESION = SessionController.Sesion.Instance;
        SessionController.CountRegistros _CountReg = new SessionController.CountRegistros();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.GestionUsuarios());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.GestionEmpleados());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.GestionRoles());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.Permisos());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.GestionOpciones());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.GestionClientes());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.GestionCategorias());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionBasica.GUI.GestionProductos());
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = true;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _SESION.Usuario;
            lblEmpleado.Text = _SESION.Empleado;
            this.WindowState = FormWindowState.Maximized;
        }
        //ABRIR FORMULARIO DENTRO DE UN PANEL
        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.pnlContePadre.Controls.Count > 0)
                this.pnlContePadre.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.pnlContePadre.Controls.Add(fh);
            this.pnlContePadre.Tag = fh;
            //this.pnlContePadre.Dock = DockStyle.Fill;
            fh.Location = new Point((pnlContePadre.Width - fh.Width) / 2, (pnlContePadre.Height - fh.Height) / 2);
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora1.Text = DateTime.Now.ToLongTimeString();
            lblFecha1.Text = DateTime.Now.ToLongDateString();
            lblHora2.Text = DateTime.Now.ToLongTimeString();
            lblFecha2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void HoraFecha2Visible()
        {
            lblHora2.Visible = true;
            lblFecha2.Visible = true;
        }

        private void HoraFecha1Invisible()
        {
            lblHora1.Visible = false;
            lblFecha1.Visible = false;
        }
        private void HoraFecha2Invisible()
        {
            lblHora2.Visible = false;
            lblFecha2.Visible = false;
        }

        private void HoraFecha1Visible()
        {
            lblHora1.Visible = true;
            lblFecha1.Visible = true;
        }

        private void CargarCantReg()
        {
            _CountReg.CargarCantRoles();
            _CountReg.CargarCantEmpleados();
            _CountReg.CargarCantUsuarios();
            _CountReg.CargarCantProductos();
            _CountReg.CargarCantClientes();
            _CountReg.CargarCantOpciones();
            _CountReg.CargarCantCategorias();
            _CountReg.CargarCantPermisos();
        }

        private void MostrarCantReg()
        {
            lblCantRoles.Text = _CountReg.CantRoles;
            lblCantEmpleados.Text = _CountReg.CantEmpleados;
            lblCantUsuaros.Text = _CountReg.CantUsuarios;
            lblCantProductos.Text = _CountReg.CantProductos;
            lblCantClientes.Text = _CountReg.CantClientes;
            lblCantOpciones.Text = _CountReg.CantOpciones;
            lblCantCategorias.Text = _CountReg.CantCategorias;
            lblCantPermisos.Text = _CountReg.CantPermisos;
        }

        private void pnlContePadre_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnlContePadre.Controls.Count == 0)
            {
                pnlContePadre.Visible = false;
                pnlMenuAdmin.Visible = true;
                HoraFecha2Invisible();
                HoraFecha1Visible();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (this.pnlContePadre.Controls.Count > 0)
                this.pnlContePadre.Controls.RemoveAt(0);
            pnlHome.Visible = true;
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = false;
            pnlReportes.Visible = false;
            HoraFecha2Invisible();
            HoraFecha1Visible();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            CargarCantReg();
            MostrarCantReg();
            pnlMenuAdmin.Visible = true;
            pnlContePadre.Visible = false;
            pnlHome.Visible = false;
            pnlReportes.Visible = false;
            HoraFecha2Invisible();
            HoraFecha1Visible();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlReportes.Visible = true;
            pnlMenuAdmin.Visible = false;
            pnlContePadre.Visible = false;
            pnlHome.Visible = false;
            HoraFecha2Invisible();
            HoraFecha1Visible();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            pnlContePadre.Visible = true;
            pnlMenuAdmin.Visible = false;
            pnlHome.Visible = false;
            pnlReportes.Visible = false;
            HoraFecha2Visible();
            HoraFecha1Invisible();
        }
    }
}
