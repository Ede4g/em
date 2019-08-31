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
    public partial class GestionEmpleados : Form
    {
        BindingSource _EMPLEADOS = new BindingSource();

        String _IDEmpleado;
        String _Empleado;
        Boolean _Seleccionado = false;

        public string IDEmpleado1
        {
            get
            {
                return _IDEmpleado;
            }

            set
            {
                _IDEmpleado = value;
            }
        }

        public string Empleado
        {
            get
            {
                return _Empleado;
            }

            set
            {
                _Empleado = value;
            }
        }

        public bool Seleccionado
        {
            get
            {
                return _Seleccionado;
            }

            set
            {
                _Seleccionado = value;
            }
        }

        private void CargarDatos()
        {
            _EMPLEADOS.DataSource = CacheController.Cache.TODOS_LOS_EMPLEADOS();
            FiltrarLocalmente();
        }
        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    _EMPLEADOS.Filter = "Apellidos LIKE '%" + txtFiltro.Text + "%'";
                    //_EMPLEADOS.Filter = "Nombres LIKE '%" + txtFiltro.Text + "%'";
                }
                else
                {
                    _EMPLEADOS.RemoveFilter();
                }
                dtgRegistros.AutoGenerateColumns = false;
                dtgRegistros.DataSource = _EMPLEADOS;
                lblNumeroRegistros.Text = dtgRegistros.Rows.Count + " Registros Encontrados";
            }
            catch
            { }
        }
        public GestionEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionEmpleado frm = new EdicionEmpleado();
            frm.ShowDialog();
            CargarDatos();
        }

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EdicionEmpleado frm = new EdicionEmpleado();
                frm.txbIDEmpleado.Text = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                frm.txbNombres.Text = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString();
                frm.txbApellidos.Text = dtgRegistros.CurrentRow.Cells["Apellidos"].Value.ToString();
                frm.dtpFechaNacimiento.Text = dtgRegistros.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                frm.cbbGenero.Text = dtgRegistros.CurrentRow.Cells["Genero"].Value.ToString();
                frm.ShowDialog();
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Empleado oEmpleado = new CLS.Empleado();
                oEmpleado.IDEmpleado = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                if (oEmpleado.Eliminar())
                {
                    MessageBox.Show("Eliminado");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Falló la eliminación");
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            IDEmpleado1 = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            Empleado = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString();
            Seleccionado = true;
            Close();
        }
    }
}
