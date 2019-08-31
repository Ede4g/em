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
        String _Direccion;
        String _Telefono;
        String _FechaNacimiento;
        String _Genero;
        String _DUI;
        String _Email;
        byte[] _Foto;

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
        public string FechaNacimiento
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
        public string Genero
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
        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }
        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }
        public string DUI
        {
            get
            {
                return _DUI;
            }

            set
            {
                _DUI = value;
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
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

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO empleados(Nombres,Apellidos,Direccion,telefono,FechaNacimiento,Genero,DUI,Email,Foto) values(";
            Sentencia += "'" + _Nombres + "','" + _Apellidos + "','" + _Direccion + "','" + _Telefono + "','" + _FechaNacimiento + "','" + _Genero + "','" + _DUI + "','" + _Email + "',@Imagen";
            Sentencia += ");";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia,_Foto) > 0)
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
            Sentencia += "Nombres='" + _Nombres + "',";
            Sentencia += "Apellidos='" + _Apellidos + "',";
            Sentencia += "Direccion='" + _Direccion + "',";
            Sentencia += "Telefono='" + _Telefono + "',";
            Sentencia += "FechaNacimiento='" + _FechaNacimiento + "',";
            Sentencia += "Genero='" + _Genero + "',";
            Sentencia += "DUI='" + _DUI + "',";
            Sentencia += "Email='" + _Email + "',";
            Sentencia += "Foto=@Imagen ";
            Sentencia += "WHERE IDEmpleado=" + _IDEmpleado + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia,_Foto) > 0)
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
