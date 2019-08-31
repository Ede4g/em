using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;



namespace SessionController
{
    public sealed class Sesion
    {
        private static volatile Sesion instance;
        private static object syncRoot = new Object();
        private Sesion() { }
        public static Sesion Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Sesion();
                    }
                }
                return instance;
            }
        }

        //PERSONALIZACION

        //ATRIBUTOS
        String _IDUsuario;
        String _Usuario;
        String _Empleado;
        String _Rol;

        //PROPIEDADES
        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }
        }
        public string Usuario
        {
            get
            {
                return _Usuario;
            }
        }
        public string Empleado
        {
            get
            {
                return _Empleado;
            }
        }
        public string Rol
        {
            get
            {
                return _Rol;
            }
        }

        //METODOS
        public Boolean ValidarSesion(String pUsuario, String pCredencial)
        {
            Boolean Validado = false;
            DataTable Resultado = new DataTable();
            Resultado=CacheController.Cache.VALIDAR_USUARIO(pUsuario, pCredencial);
            if(Resultado.Rows.Count==1)
            {
                Validado = true;
                _Usuario = Resultado.Rows[0]["Usuario"].ToString();
                _IDUsuario = Resultado.Rows[0]["IDUsuario"].ToString();
                _Empleado = Resultado.Rows[0]["Empleado"].ToString();
                _Rol = Resultado.Rows[0]["Rol"].ToString();
            }
            return Validado;
        }

        public string RecuPass(string pDUI)
        {
            string Mensaje;
            Mensaje = CacheController.RecuperarCredencial.RecuperarContraseña(pDUI);
            return Mensaje;
        }
    }
}
