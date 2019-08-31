using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Empleado
    {
        //ATRIBUTOS
        String _IDEmpleado;
        String _Nombres;
        String _Apellidos;
        String _FechaNacimiento;
        String _Genero;

        //PROPIEDADES
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

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public String FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }

            set
            {
                _FechaNacimiento = value;
            }
        }

        public String Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO empleados(Nombres,Apellidos,FechaNacimiento,Genero) values(";
            Sentencia += "'" + _Nombres + "','" + _Apellidos + "','" + _FechaNacimiento + "','" + _Genero +"'";
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
            Sentencia += "UPDATE empleados SET ";
            Sentencia += "Nombres='" + _Nombres + "',"+ "Apellidos='" + _Apellidos + "'," + "FechaNacimiento='" + _FechaNacimiento + "'," + "Genero='" + _Genero +"' ";
            Sentencia += "WHERE IDEmpleado=" + _IDEmpleado + ";";
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
            Sentencia += "DELETE FROM empleados ";
            Sentencia += "WHERE IDEmpleado=" + _IDEmpleado + ";";
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
