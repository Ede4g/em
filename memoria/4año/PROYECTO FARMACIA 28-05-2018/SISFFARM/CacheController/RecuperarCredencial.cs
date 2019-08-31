using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias para poder enviar correos electronicos
using System.Net;
using System.Net.Mail;
using System.Data;

namespace CacheController
{
    public class RecuperarCredencial
    {
        static String _Empleado;
        static String _Email;
        static String _Credencial;
        static String Mensaje;

        public string Empleado
        {
            get
            {
                return _Empleado;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
        }

        public string Credencial
        {
            get
            {
                return _Credencial;
            }
        }


        public static String RecuperarContraseña(String pDUI)
        {
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODOS_LOS_EMPLEADOS();
            if (Resultado.Rows[0]["Usuario"].ToString() == pDUI)
            {
                _Email = Resultado.Rows[0]["Email"].ToString();
                _Empleado = Resultado.Rows[0]["Empleado"].ToString();
                _Credencial = Resultado.Rows[0]["Credencial"].ToString();
                //AQUI ENVIAMOS EL CORREO ANTES DE MOSTRARLE EL MENSAJE AL USUARIO
                EnviarEmail();
                //MOSTRAMOS EL MENSAJE AL USUARIO
                Mensaje = "Estimado " + _Empleado + " , Se ha enviado su contraseña al correo: " + _Email + ": verifique su bandeja de entrada";
            }
            else
            {
                Mensaje = "No existen datos...";
            }
            return Mensaje;
        }

        static public void EnviarEmail()
        {
            //CORREO
            //ARMAR CORREO QUE SE VA ENVIAR
            MailMessage Correo = new MailMessage();
            //AGREGAMOS CORREO DE ORIGEN
            Correo.From = new MailAddress("edu.quele10@gmail.com");
            //ESPECIFICAMOS EL DESTINO DEL CORREO
            Correo.To.Add(_Email);
            //AGREGAMOS EL ASUNTO DEL CORREO
            Correo.Subject = ("RECUPERAR CONTRASEÑA SYSTEM");
            //AGREGARMOS EL CUERPO DEL CORREO AQUI VA EL MENSAJE CON LA CONTRASEÑA
            Correo.Body = ("HOLA, " + _Empleado + " Usted solicito recuperar contraseña\n su contraseña es: " + _Credencial);
            //ESPECIFICAMOS LA PRIORIDAD DEL CORREO DONDE EXISTEN PRIORIDAD BAJA NORMAL Y ALTA ESTO ES OPCIONAL
            Correo.Priority = MailPriority.Normal;
            //SMTP (PROTOCOLO PARA TRANSFERENCIA SIMPLE DE CORREO) SE CONFIGURA EL PROTOCOLO SMTP PARA EL HOST
            //AQUI SE ESPECIFICA EL NOMBRE DEL DOMINIO DEL SERVICIO SMTP
            //PARA ESTE CASO OCUPAMOS UN CORREO DE EMAIL ENTONCES UTILIZAMOS CUALQUIERA DE LOS SIGUIENTES SERVICIOS DE HOST
            // smtp-replay.gmail.com    smtp.gmail.com       aspmx.l.google.com
            //COMO LA MAYORIA TIENE CORREOS PERSONALES UTILIZAMOS EL smtp.gmail.com
            //COMO EL smtp.gmail.com utiliza EL CIFRADO TLS(SERVIVIO EN LA CAPA DE TRANSPORTE) ENTONCES SE OCUPA EL PUERTO 587

            //SE CREA EL OBJETO DE SMTPCLIENT
            SmtpClient ServerMail = new SmtpClient();
            //SE AGREGAN LAS CREDENCIALES DE SMTPCLIENT aqui en el objeto networkcredencial se manda como parametros el correo y la contraseña esto para que la aplicacion tenga acceso y pueda enviar correos
            ServerMail.Credentials = new NetworkCredential("mail", "pass");
            //ASIGNAMOS EL HOST
            ServerMail.Host = "smtp.gmail.com";
            //ASIGNAMOS EL PUERTO SMTP
            ServerMail.Port = 587;
            //ESPECIFICAMOS QUE EL CIFRADO TLS ES VERDADERO
            ServerMail.EnableSsl = true;
            //DENTRO DE UN CAPTURADOR DE ERRORE LLAMAMOS EL METODO SEND DE SMTPCLIENT
            try
            {
                //AQUI MANDAMOS COMO PARAMETRO EL CORREO QUE ARMAMOS
                ServerMail.Send(Correo);
            }
            catch (Exception ex)
            {

            }
            //ES IMPORTANTE LIMPIAR EL CORREO PARA NO OCACIONAR ERRORES SI SE QUIERE REUTILIZAR ESTA CLASE
            Correo.Dispose();
        }

    }
}
