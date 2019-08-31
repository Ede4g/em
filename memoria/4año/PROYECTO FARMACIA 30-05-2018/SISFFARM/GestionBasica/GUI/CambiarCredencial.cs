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
    public partial class CambiarCredencial : Form
    {
        String _Credencial;
        Boolean _Cambiar = false;
        public CambiarCredencial()
        {
            InitializeComponent();
        }

        public string Credencial
        {
            get{return _Credencial;}
        }

        public bool Cambiar
        {
            get{return _Cambiar;}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbCredencialN.Text != "" && txbConfirCredencial.Text != "")
                {
                    if (txbCredencialN.Text == txbConfirCredencial.Text)
                    {
                        _Credencial = txbConfirCredencial.Text;
                        _Cambiar = true;
                        Close();
                    }
                    else
                    {
                        CLS.MyMessageBox.ShowMessage("Las Credenciales NO son iguales", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbCredencialN.Clear();
                        txbConfirCredencial.Clear();
                    }
                }
                else
                {
                    CLS.MyMessageBox.ShowMessage("Las cajas de texto no pueden estar vacias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Ocurrio un Error a la hora de GUARDAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
