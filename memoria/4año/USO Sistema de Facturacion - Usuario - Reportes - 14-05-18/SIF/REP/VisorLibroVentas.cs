using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF.REP
{
    public partial class VisorLibroVentas : Form
    {
        private void CargarReporte()
        {
            REP.LibroDeVenta oReporte = new LibroDeVenta();
            oReporte.SetDataSource(CacheController.Cache.LIBRO_DE_VENTAS());
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
