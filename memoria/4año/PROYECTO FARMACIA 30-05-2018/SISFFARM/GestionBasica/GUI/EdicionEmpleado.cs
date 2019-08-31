using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.IO;

using AForge.Video.DirectShow;
using AForge.Video;

namespace GestionBasica.GUI
{
    public partial class EdicionEmpleado : Form
    {
        //CODIGO PARA VER WEBCAM
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivo.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivo.Text = cbxDispositivo.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }
        public EdicionEmpleado()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbFotoEmpleado.Image = Imagen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pbFotoEmpleado.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();

                if (txbNombres.Text != "" && txbApellidos.Text != "" && txbDireccion.Text  != "" && txbTelefono.Text != "" && cbbGenero.Text != "" &&dtpFechaNacimiento.Text != "")
                {
                    CLS.Empleado oEmpleado = new CLS.Empleado();
                    CLS.FotoEmpleado oFotoEmpleado = new CLS.FotoEmpleado();
                    oEmpleado.IDEmpleado = txbIDEmpleado.Text;
                    oEmpleado.Nombres = txbNombres.Text;
                    oEmpleado.Apellidos = txbApellidos.Text;
                    oEmpleado.Direccion = txbDireccion.Text;
                    oEmpleado.Telefono = txbTelefono.Text;
                    oEmpleado.FechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy/MM/dd");
                    oEmpleado.Genero = cbbGenero.SelectedItem.ToString();
                    oEmpleado.DUI = txbDUI.Text;
                    oEmpleado.Email = txbEmail.Text;

                    oFotoEmpleado.IDFotoEmpleado = txbIDFoto.Text;
                    oFotoEmpleado.IDEmpleado = txbIDEmpleado.Text;
                    oEmpleado.Foto = aByte;
                    oFotoEmpleado.Fecha = dtpFechaNacimiento.Value.ToString("yyyy/MM/dd");
                    if (txbIDEmpleado.TextLength > 0 && txbIDFoto.TextLength > 0)
                    {
                        //ACTUALIZAR
                        if (oEmpleado.Actualizar() && oFotoEmpleado.Actualizar())
                        {
                            CLS.MyMessageBox.ShowMessage("Actualizado");
                            Close();
                        }
                        else
                        {
                            CLS.MyMessageBox.ShowMessage("Falló la Actualización");
                        }
                    }
                    else
                    {
                        //INSERTAR
                        if (oEmpleado.Insertar())
                        {

                            CLS.MyMessageBox.ShowMessage("Insertado");
                            Close();
                        }
                        else
                        {
                            CLS.MyMessageBox.ShowMessage("Falló la Inserción");
                        }
                    }
                }
                else
                {
                    CLS.MyMessageBox.ShowMessage("Tiene que llenar los campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                CLS.MyMessageBox.ShowMessage("Ocurrió un Error a la hora de GUARDAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbNombres_KeyPress(object sender, KeyPressEventArgs e)
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
                CLS.MyMessageBox.ShowMessage("Por favor solo puede escribir Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNombres.Focus();
                e.Handled = true;
                { }
            }
        }

        private void txbApellidos_KeyPress(object sender, KeyPressEventArgs e)
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
                CLS.MyMessageBox.ShowMessage("Por favor solo puede escribir Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbApellidos.Focus();
                e.Handled = true;
                { }
            }
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                CLS.MyMessageBox.ShowMessage("Por favor solo puede escribir Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTelefono.Focus();
                e.Handled = true;
                { }
            }
        }

        private void pbFotoEmpleado_DoubleClick(object sender, EventArgs e)
        {
            ofd.Filter = "Archivo de Imagen |*.jpg| Archivo PNG|*.png|Todos los Archivos|*.*";
            DialogResult resultado = ofd.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                pbFotoEmpleado.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txbDUI_KeyPress(object sender, KeyPressEventArgs e)
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
                CLS.MyMessageBox.ShowMessage("Por favor solo puede escribir Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDUI.Focus();
                e.Handled = true;
                { }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")

            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivo.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivo…";
                    btnIniciar.Text = "Capturar";
                    cbxDispositivo.Enabled = false;
                }
                else
                {
                    Estado.Text = "No Hay Camaras Conectadas";
                   // pbFotoEmpleado.Image = WebCam_Proyecto.Properties.Resources.ImgDefecto;
                }
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = "Dispositivo Detenido…";
                    btnIniciar.Text = "Iniciar";
                    cbxDispositivo.Enabled = true;
                }
            }
        }
    }
}
