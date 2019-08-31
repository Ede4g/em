using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        String _IDRol;
        DataTable _PERMISOS = new DataTable();
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
            set
            {
                _Usuario=value;
            }
        }

        public string IDRol
        {
            get
            {
                return _IDRol;
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
                _IDRol= Resultado.Rows[0]["IDRol"].ToString();
                ObtenerPermisos();
            }
            return Validado;
        }
        private void ObtenerPermisos()
        {
            _PERMISOS = CacheController.Cache.PERMISOS_DE_UN_USUARIO(_IDRol);
        }
        public Boolean ComprobarPermiso(Int32 pIDOpcion)
        {
            Boolean comprobado = false;
            foreach(DataRow fila in _PERMISOS.Rows)
            {
                if(fila["IDOpcion"].ToString().Equals(pIDOpcion.ToString()))
                {
                    comprobado = true;
                    break;
                }
            }
            if(!comprobado)
            {
                MessageBox.Show("Usted no cuenta con el permiso para ver esta opcion");
            }

            return comprobado;
        }
    }
}
