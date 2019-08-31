using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Opcion
    {
        String _IDOpcion;
        String _Opcion;
        String _Clasificacion;

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

        public string Opciones
        {
            get
            {
                return _Opcion;
            }

            set
            {
                _Opcion = value;
            }
        }

        public string Clasificacion
        {
            get
            {
                return _Clasificacion;
            }

            set
            {
                _Clasificacion = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO opciones(Opcion,Clasificacion) values(";
            Sentencia += "'" + _Opcion + "','" + _Clasificacion + "'";
            Sentencia += ");";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch { }
            return ok;
        }
        public Boolean Actualizar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE opciones SET ";
            Sentencia += "Opcion='" + _Opcion + "',";
            Sentencia += "Clasificacion='" + _Clasificacion + "'";
            Sentencia += "WHERE IDOPcion=" + _IDOpcion + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch { }
            return ok;
        }
        public Boolean Eliminar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "DELETE FROM opciones ";
            Sentencia += "WHERE IDOPcion=" + _IDOpcion + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Eliminar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch { }
            return ok;
        }
    }
}
