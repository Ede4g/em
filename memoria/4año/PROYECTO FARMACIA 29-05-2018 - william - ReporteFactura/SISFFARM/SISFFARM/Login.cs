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
    public partial class Login : Form
    {
        Boolean _Autorizado = false;
        SessionController.Sesion _SESION = SessionController.Sesion.Instance;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Login()
        {
            InitializeComponent();
        }

        public bool Autorizado
        {
            get
            {
                return _Autorizado;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            IniciarSession();
        }

        private void IniciarSession()
        {
            if (_SESION.ValidarSesion(txbUsuario.Text, txbPassword.Text))
            {
                _Autorizado = true;
                Close();
            }
            else
            {
                lblMensaje.Text = "DATOS ERRONEOS";
            }
        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if(txbUsuario.Text == "USUARIO")
            {
                txbUsuario.Text = "";
                txbUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            TXUsuario();
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "CREDENCIAL")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.LightGray;
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            TXCredencial();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TXUsuario()
        {
            if (txbUsuario.Text == "")
            {
                txbUsuario.Text = "USUARIO";
                txbUsuario.ForeColor = Color.DimGray;
            }
        }
        private void TXCredencial()
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "CREDENCIAL";
                txbPassword.ForeColor = Color.DimGray;
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.Width = 20;
            btnCerrar.Height = 20;
            btnCerrar.Location = new Point(759,4);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.Width = 15;
            btnCerrar.Height = 15;
        }

        private void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            btnMinimizar.Width = 20;
            btnMinimizar.Height = 20;
            btnMinimizar.Location = new Point(736,4);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.Width = 15;
            btnMinimizar.Height = 15;
        }

        private void btnEntrar_Enter(object sender, EventArgs e)
        {
            IniciarSession();
        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecCredencial frm = new frmRecCredencial();
            frm.ShowDialog();
        }
    }
}
