using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SessionController;

namespace SISFFARM
{
    public partial class frmRecCredencial : Form
    {
        Sesion _SESSION = Sesion.Instance;
        public frmRecCredencial()
        {
            InitializeComponent();
        }
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            txbMensaje.Text = _SESSION.RecuPass(txbDUI.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
