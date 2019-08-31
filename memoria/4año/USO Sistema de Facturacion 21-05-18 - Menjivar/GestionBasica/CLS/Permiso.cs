using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Permiso
    {
        String _IDPermiso;
        String _IDRol;
        String _IDOpcion;

        public string IDPermiso
        {
            get
            {
                return _IDPermiso;
            }

            set
            {
                _IDPermiso = value;
            }
        }
        public string IDRol
        {
            get
            {
                return _IDRol;
            }

            set
            {
                _IDRol = value;
            }
        }
        public string IDOpcion
        {
            get
            {
                return _IDOpcion;
            }

            set
            {
                _IDOpcion = value;
            }
        }

        public Boolean Conceder()
        {
            Boolean Concedido = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO permisos(IDRol, IDOpcion) values(";
            Sentencia += "'" + _IDRol + "',";
            Sentencia += "'" + _IDOpcion + "'";
            Sentencia += ");";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia) > 0)
                {
                    Concedido = true;
                }
            }
            catch { }
            return Concedido;
        }
        public Boolean Revocar()
        {
            Boolean Revocado = false;
            String Sentencia = String.Empty;
            Sentencia += "DELETE FROM permisos WHERE IDPermiso="+_IDPermiso+";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Eliminar(Sentencia) > 0)
                {
                    Revocado = true;
                }
            }
            catch { }
            return Revocado;
        }

    }
}
