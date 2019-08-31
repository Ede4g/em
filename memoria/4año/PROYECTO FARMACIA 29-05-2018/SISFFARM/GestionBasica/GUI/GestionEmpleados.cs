using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

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
            get{return _IDEmpleado;}
        }
        public string Empleado
        {
            get{return _Empleado;}
        }
        public bool Seleccionado
        {
            get{return _Seleccionado;}
        }

        private void CargarDatos()
        {
            _EMPLEADOS.DataSource = CacheController.Cache.TODOS_LOS_EMPLEADOS();
            FiltrarLocalmente();
        }
        public static Bitmap aImagen(byte[] img)
        {
            MemoryStream cadena = new MemoryStream();
            byte[] buffer = img;
            Bitmap bitmap;
            cadena = new MemoryStream(buffer);
            bitmap = new Bitmap(cadena);
            cadena.Close();
            return bitmap;
        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txtFiltro.TextLength > 0)
                {
                    if (rbNombre.Checked == true)
                    {
                        _EMPLEADOS.Filter = "Nombres LIKE '%" + txtFiltro.Text + "%'";
                    }
                    else if(rbApellidos.Checked == true)
                    {
                        _EMPLEADOS.Filter = "Apellidos LIKE '%" + txtFiltro.Text + "%'";
                    }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionEmpleado frm = new EdicionEmpleado();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionEmpleado frm = new EdicionEmpleado();
                    Bitmap nbitmap;
                    frm.txbIDEmpleado.Text = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    frm.txbNombres.Text = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString();
                    frm.txbApellidos.Text = dtgRegistros.CurrentRow.Cells["Apellidos"].Value.ToString();
                    frm.txbDireccion.Text = dtgRegistros.CurrentRow.Cells["Direccion"].Value.ToString();
                    frm.txbTelefono.Text = dtgRegistros.CurrentRow.Cells["Telefono"].Value.ToString();
                    frm.dtpFechaNacimiento.Text = dtgRegistros.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                    frm.cbbGenero.Text = dtgRegistros.CurrentRow.Cells["Genero"].Value.ToString();
                    frm.txbDUI.Text = dtgRegistros.CurrentRow.Cells["DUI"].Value.ToString();
                    frm.txbEmail.Text = dtgRegistros.CurrentRow.Cells["Email"].Value.ToString();
                    nbitmap = aImagen((byte[])dtgRegistros.CurrentRow.Cells["Foto"].Value);
                    frm.pbFotoEmpleado.Image = new Bitmap(nbitmap);
                    frm.ShowDialog();
                    CargarDatos();
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un Error a la hora de EDITAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Ocurrio un Error a la hora de ELIMINAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
            _IDEmpleado = dtgRegistros.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            _Empleado = dtgRegistros.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgRegistros.CurrentRow.Cells["Apellidos"].Value.ToString();
            _Seleccionado = true;
            Close();
        }
    }
}
