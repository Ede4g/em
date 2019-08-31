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
    public partial class Reporte : Form
    {

        private void CargarReporte()
        {
            REP.Empleados oReporte = new REP.Empleados();
            oReporte.SetDataSource(CacheController.Cache.REPORTE_EMPLEADOS());
            crystalReportViewer1.ReportSource = oReporte;
        }
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
