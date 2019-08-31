using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    public class DetalleFactura
    {
        String _IDDetallesFactura;
        String _Cantidad;
        String _PrecioDeVenta;
        String _NombreProducto;
        String _IDProducto;
        String _IDFacturaDeVenta;
        String _Descripcion;

        public DetalleFactura() { }

        public DetalleFactura(string pIDDetallesFactura, string pCantidad, string pPrecioDeVenta, string pNombreProducto, string pIDProducto, string pIDFacturaDeVenta, string pDescripcion)
        {
            _IDDetallesFactura = pIDDetallesFactura;
            _Cantidad = pCantidad;
            _PrecioDeVenta = pPrecioDeVenta;
            _NombreProducto = pNombreProducto;
            _IDProducto = pIDProducto;
            _IDFacturaDeVenta = pIDFacturaDeVenta;
            _Descripcion = pDescripcion;
        }

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

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO detallesfacturas(Cantidad, PrecioDeVenta, NombreProducto, IDProducto, IDFacturaDeVenta, Descripcion) values(";
            Sentencia += "'" + Cantidad + "','" + PrecioDeVenta + "','" + NombreProducto + "','" + IDProducto + "','" + IDFacturaDeVenta + "','" + Descripcion + "'";
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
            Sentencia += "PrecioDeVenta='" + PrecioDeVenta + "',";
            Sentencia += "NombreProducto='" + NombreProducto + "',";
            Sentencia += "IDProducto='" + IDProducto + "'";
            Sentencia += "IDFacturaDeVenta='" + IDFacturaDeVenta + "',";
            Sentencia += "Descripcion='" + Descripcion + "'";
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
