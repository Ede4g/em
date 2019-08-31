using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class FacturaDeVenta
    {
        String _IDFacturaDeVenta;
        String _Fecha;
        String _FormaDePago;
        String _IDCliente;
        String _IDEmpleado;
        String _NumeroDeFactura;
        String _TotalAPagar;

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


        public string NumeroDeFactura
        {
            get
            {
                return _NumeroDeFactura;
            }

            set
            {
                _NumeroDeFactura = value;
            }
        }

        public string FormaDePago
        {
            get
            {
                return _FormaDePago;
            }

            set
            {
                _FormaDePago = value;
            }
        }

        public string IDCliente
        {
            get
            {
                return _IDCliente;
            }

            set
            {
                _IDCliente = value;
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

        public string TotalAPagar
        {
            get
            {
                return _TotalAPagar;
            }

            set
            {
                _TotalAPagar = value;
            }
        }

        public Boolean Insertar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO facturasdeventas(NumeroDeFactura, Fecha, FormaDePago, TotalAPagar, IDEmpleado, IDCliente) values(";
            Sentencia += "'" + _NumeroDeFactura + "','" + _Fecha + "','" + _FormaDePago + "','" + _TotalAPagar.ToString().Replace(",",".") + "','" + _IDEmpleado + "','" + _IDCliente + "'";
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
            Sentencia += "UPDATE facturasdeventas SET ";
            Sentencia += "NumeroDeFactura='" + _NumeroDeFactura + "',";
            Sentencia += "Fecha='" + _Fecha + "',";
            Sentencia += "FormaDePago='" + _FormaDePago + "',";
            Sentencia += "TotalAPagar='" + _TotalAPagar + "',";
            Sentencia += "IDEmpleado='" + _IDEmpleado + "',";
            Sentencia += "IDCliente='" + _IDCliente + "' ";
            Sentencia += "WHERE IDFacturaDeVenta=" + _IDFacturaDeVenta + ";";
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
            Sentencia += "DELETE FROM facturasdeventas ";
            Sentencia += "WHERE IDFacturaDeVenta=" + IDFacturaDeVenta + ";";
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
