using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Producto
    {
        String _IDProducto;
        String _Nombre;
        String _Alias;
        String _Codigo;
        String _Descripcion;
        String _IDCategoria;
        String _PrecioDeVenta;
        String _Costo;

        public string IDProducto
        {
            get
            {
                return _IDProducto;
            }

            set
            {
                _IDProducto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Alias
        {
            get
            {
                return _Alias;
            }

            set
            {
                _Alias = value;
            }
        }

        public string Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public string IDCategoria
        {
            get
            {
                return _IDCategoria;
            }

            set
            {
                _IDCategoria = value;
            }
        }

        public string PrecioDeVenta
        {
            get
            {
                return _PrecioDeVenta;
            }

            set
            {
                _PrecioDeVenta = value;
            }
        }

        public string Costo
        {
            get
            {
                return _Costo;
            }

            set
            {
                _Costo = value;
            }
        }
        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO productos(Nombre,Alias,Codigo,Descripcion,IDCategoria,PrecioDeVenta,Costo) values(";
            Sentencia += "'" + _Nombre + "','" + _Alias + "','" + _Codigo + "','" + _Descripcion +"','" + _IDCategoria + "','"  + _PrecioDeVenta.ToString().Replace(",", ".") + "','" + _Costo.ToString().Replace(",", ".") + "'";
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
            Sentencia += "UPDATE productos SET ";
            Sentencia += "Nombre='" + _Nombre + "',Alias='" + _Alias + "',Codigo='" + _Codigo + "',Descripcion='" + _Descripcion + "',IDCategoria='" + _IDCategoria + "',PrecioDeVenta='" + _PrecioDeVenta.ToString().Replace(",",".") + "',Costo='" + _Costo.ToString().Replace(",", ".") + "' ";
            Sentencia += "WHERE IDProducto=" + _IDProducto + ";";
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
            Sentencia += "DELETE FROM productos ";
            Sentencia += "WHERE IDProducto=" + _IDProducto + ";";
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
