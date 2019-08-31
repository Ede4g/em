using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF.GUI
{
    public partial class VisorLibroVentas : Form
    {
        SessionController.Sesion _SESION = SessionController.Sesion.Instance;
        private void CargarReporte()
        {
            REP.LibroVenta oReporte = new REP.LibroVenta();
            
            oReporte.SetDataSource(CacheController.Cache.LIBRO_DE_VENTAS());

            oReporte.SetParameterValue("pUsuario", _SESION.Usuario);
            crvVisor.ReportSource = oReporte;
        }
        public VisorLibroVentas()
        {
            InitializeComponent();
        }

        private void VisorLibroVentas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
