using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class DetalleFactura
    {
        String _IDDetallesFactura;
        String _Cantidad;
        String _Precio;
        String _NombreProducto;
        String _IDProducto;
        String _IDFacturaDeVenta;
        String _Exento;
        String _Gravado;
        String _NoSujeto;

        public string IDDetallesFactura
        {
            get
            {
                return _IDDetallesFactura;
            }

            set
            {
                _IDDetallesFactura = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        public string Precio
        {
            get
            {
                return _Precio;
            }

            set
            {
                _Precio = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return _NombreProducto;
            }

            set
            {
                _NombreProducto = value;
            }
        }

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

        public string IDFacturaDeVenta
        {
            get
            {
                return _IDFacturaDeVenta;
            }

            set
            {
                _IDFacturaDeVenta = value;
            }
        }

        public string Exento
        {
            get
            {
                return _Exento;
            }

            set
            {
                _Exento = value;
            }
        }

        public string Gravado
        {
            get
            {
                return _Gravado;
            }

            set
            {
                _Gravado = value;
            }
        }

        public string NoSujeto
        {
            get
            {
                return _NoSujeto;
            }

            set
            {
                _NoSujeto = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO detallesfacturas(Cantidad, Precio, NombreProducto, IDProducto, IDFacturaDeVenta, Exento, Gravado, NoSujeto) values(";
            Sentencia += "'" + Cantidad + "','" + Precio + "','" + NombreProducto + "','" + IDProducto + "','" + IDFacturaDeVenta + "','" + Exento + "','" + Gravado + "','" + NoSujeto + "'";
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
            Sentencia += "UPDATE detallesfaturas SET ";
            Sentencia += "Cantidad='" + Cantidad + "',";
            Sentencia += "Precio='" + Precio + "',";
            Sentencia += "NombreProducto='" + NombreProducto + "',";
            Sentencia += "IDProducto='" + IDProducto + "'";
            Sentencia += "IDFacturaDeVenta='" + IDFacturaDeVenta + "',";
            Sentencia += "Exento='" + Exento + "'";
            Sentencia += "Gravado='" + Gravado + "'";
            Sentencia += "NoSujeto='" + NoSujeto + "'";
            Sentencia += "WHERE IDDetallesFactura=" + IDDetallesFactura + ";";
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
            Sentencia += "DELETE FROM detallesfacturas ";
            Sentencia += "WHERE IDDetallesFatura=" + IDDetallesFactura + ";";
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
