using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class FotoEmpleado
    {
        String _IDFotoEmpleado;
        String _IDEmpleado;
        byte[] _Foto;
        String _Fecha;

        public string IDFotoEmpleado
        {
            get
            {
                return _IDFotoEmpleado;
            }

            set
            {
                _IDFotoEmpleado = value;
            }
        }

        public string IDEmpleado
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

        public byte[] Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO fotosempleados(IDEmpleado, Foto, Fecha) values( " ;
            Sentencia += " last_insert_id(),   @Imagen, '" + _Fecha + "'";
            Sentencia += ");";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia, _Foto) > 0)
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
            Sentencia += "UPDATE fotosempleados SET ";
            Sentencia += "IDEmpleado='" + _IDEmpleado + "',";
            Sentencia += "Foto=@Imagen ,";
            Sentencia += "Fecha='" + _Fecha + "' ";
            Sentencia += "WHERE IDFotoEmpleado=" + _IDFotoEmpleado + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia, _Foto) > 0)
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
            Sentencia += "DELETE FROM fotosempleados ";
            Sentencia += "WHERE IDFotoEmpleado=" + _IDFotoEmpleado + ";";
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
