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
    public partial class LibroVentaGeneral : Form
    {
        private void CargarReporte()
        {
            REP.LibroVentaGeneral oReporte = new REP.LibroVentaGeneral();
            oReporte.SetDataSource(CacheController.Cache.REPORTE_LIBRO_VENTAGENERAL());
            crvVisor.ReportSource = oReporte;
        }

        public LibroVentaGeneral()
        {
            InitializeComponent();
        }

        private void LibroVentaGeneral_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
