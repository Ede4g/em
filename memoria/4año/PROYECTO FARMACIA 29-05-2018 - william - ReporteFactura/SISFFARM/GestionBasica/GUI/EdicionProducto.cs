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
    public partial class EdicionProducto : Form
    {   
        public EdicionProducto()
        {
            InitializeComponent();
        }

        private void CargarCategoria()
        {
            try
            {
                DataTable Categorias = new DataTable();
                Categorias = CacheController.Cache.TODAS_LAS_CATEGORIAS();
                cbbCategoria.DataSource = Categorias;
                cbbCategoria.DisplayMember = "Nombre";
                cbbCategoria.ValueMember = "IDCategoria";
            }
            catch
            {
                MessageBox.Show("Ocurrio un Error al cargar las categorias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //para validar que los campos no esten vacios
                if (txbNombre.Text != "" && txtAlias.Text != "" && txbCodigo.Text != "" && txbDescripcion.Text != "" && nupCosto.Text != "" && nupPrecio.Text != "" && cbbCategoria.Text != "")
                {
                    CLS.Producto oProducto = new CLS.Producto();
                    oProducto.IDProducto = txbIDProducto.Text;
                    oProducto.Nombre = txbNombre.Text;
                    oProducto.Alias = txtAlias.Text;
                    oProducto.Codigo = txbCodigo.Text;
                    oProducto.Descripcion = txbDescripcion.Text;
                    oProducto.IDCategoria = cbbCategoria.SelectedValue.ToString();
                    oProducto.PrecioDeVenta = nupPrecio.Value.ToString();
                    oProducto.Costo = nupCosto.Value.ToString();
                    if (txbIDProducto.TextLength > 0)
                    {
                        //ACTUALIZAR
                        if (oProducto.Actualizar())
                        {
                            MessageBox.Show("Actualizado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Falló la Actualización");
                        }
                    }
                    else
                    {
                        //INSERTAR
                        if (oProducto.Insertar())
                        {
                            MessageBox.Show("Insertado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Falló la Inserción");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que llenar los campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un Error a la hora de GUARDAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EdicionProducto_Load(object sender, EventArgs e)
        {
            CargarCategoria();
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Por favor solo puede escribir Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNombre.Focus();
                e.Handled = true;
                { }
            }
        }

        private void txtAlias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Por favor solo puede escribir Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAlias.Focus();
                e.Handled = true;
                { }
            }
        }

        private void nupCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Por favor solo puede escribir Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nupCosto.Focus();
                e.Handled = true;
                { }
            }
        }

        private void nupPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Por favor solo puede escribir Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nupPrecio.Focus();
                e.Handled = true;
                { }
            }
        }
    }
}
