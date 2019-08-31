using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheController
{
    public class Cache
    {
        public static DataTable REPORTE_LIBRO_VENTAGENERAL()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append(@"SELECT a.NumeroDeFactura, a.Fecha, CONCAT(b.Nombres,' ', b.Apellidos) AS 'Empleado',
            a.FormaDePago, CONCAT(c.Nombres, ' ', c.Apellidos) AS 'Cliente', c.Direccion FROM facturasdeventas a, 
            empleados b, clientes c WHERE a.IDEmpleado = b.IDEmpleado AND a.IDCliente = c.IDCliente;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable PERMISOS_ASIGNADOS(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT ");
            Consulta.Append("a.IDOpcion, ");
            Consulta.Append("a.Opcion, ");
            Consulta.Append("IFNULL((SELECT IDPermiso FROM permisos p WHERE p.IDRol = " + pIDRol + " AND p.IDOpcion = a.IDOpcion), 0) as 'IDPermiso', ");
            Consulta.Append("(SELECT COUNT(IDPermiso) FROM permisos p WHERE p.IDRol = " + pIDRol + " AND p.IDOpcion = a.IDOpcion) AS 'Asignado', ");
            Consulta.Append("a.Clasificacion ");
            Consulta.Append("FROM ");
            Consulta.Append("opciones a ORDER BY Clasificacion, Opcion; ");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable PERMISOS_DE_UN_USUARIO(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDOpcion,(Select Opcion from Opciones r where r.IDOpcion=p.IDOpcion) as 'Opcion' FROM permisos p where IDRol=" + pIDRol + ";");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable CONSULTAR_ID_FACTURA()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("select max(IDFacturaDeVenta) as 'IdFactura' from facturasdeventas;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDRol, Rol FROM roles  ORDER BY Rol ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDEmpleado, a.Nombres, a.Apellidos, a.Direccion, a.Telefono, a.FechaNacimiento, a.Email, a.Genero, a.DUI, b.IDFotoEmpleado, b.Foto FROM empleados a, fotosempleados b WHERE a.IDEmpleado = b.IDEmpleado  ORDER BY a.Apellidos ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDUsuario, a.Usuario, a.Credencial, a.IDEmpleado, a.IDRol, b.Nombres, b.Apellidos, c.Rol  FROM usuarios a, empleados b, roles c WHERE a.IDEmpleado = b.IDEmpleado AND a.IDRol = c.IDRol ORDER BY Usuario ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODOS_LOS_USUARIOS_PARA_REC_PASS(String pDUI)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT CONCAT( b.Nombres,' ' ,b.Apellidos) AS Empleado, a.Credencial, b.DUI, b.Email  FROM usuarios a, empleados b WHERE a.IDEmpleado = b.IDEmpleado and b.DUI=" +pDUI+";");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable VALIDAR_USUARIO(String pUsuario, String pCredencial)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDUsuario,a.Usuario, a.Credencial,a.Estado, a.IDEmpleado,CONCAT(b.Nombres,' ',b.Apellidos) as 'Empleado' , a.IDRol, c.Rol FROM usuarios a, empleados b, roles c WHERE a.IDEmpleado=b.IDEmpleado AND a.IDRol=c.IDRol AND a.Usuario='"+pUsuario+"' AND a.Credencial=SHA1('"+pCredencial+"');");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODOS_LOS_PRODUCTOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDProducto, a.Nombre, a.Alias, a.Codigo, a.Imagen, a.Descripcion,a.PrecioDeVenta, a.Costo, a.IDCategoria,b.Nombre as Categoria FROM productos a, categorias b WHERE a.IDCategoria=b.IDCategoria;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODOS_LOS_CLIENTES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDCliente, Nombres, Apellidos, Direccion, Telefono FROM clientes  ORDER BY Nombres ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODAS_LAS_OPCIONES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDOpcion, Opcion, Clasificacion FROM opciones  ORDER BY Opcion ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODAS_LAS_CATEGORIAS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDCategoria, Nombre, Descripcion FROM categorias  ORDER BY Nombre ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODAS_LAS_FOTOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDFotoEmpleado, IDEmpleado, Foto, Fecha FROM fotosempleados;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODAS_LAS_FACTURAS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append(@"SELECT a.IDFacturaDeVenta, a.NumeroDeFactura, a.Fecha, a.FormaDePago, a.IDCliente,concat(c.Nombres, ' ',c.Apellidos) as Cliente, a.IDEmpleado,concat(d.Nombres, ' ', d.Apellidos) as Empleado, a.TotalAPagar, 
                b.IDDetallesFactura, b.Cantidad, b.Precio, b.NombreProducto, b.IDProducto, b.IDFacturaDeVenta,
                b.Exento, b.Gravado, b.NoSujeto
                FROM facturasdeventas a, detallesfacturas b, clientes c, empleados d
                WHERE a.IDFacturaDeVenta = b.IDFacturaDeVenta and a.IDCliente = c.IDCliente and a.IDEmpleado = d.IDEmpleado;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODOS_LOS_DETALLES(String pIDFactura)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("select  a.IDDetallesFactura,a.Cantidad,a.Precio,a.NombreProducto,a.Exento,a.Gravado,a.NoSujeto,a.IDProducto ");
            Consulta.Append("from detalleventa a,  facturasdeventas b, clientes c ");
            Consulta.Append("where b.IDCliente = c.IDCliente ");
            Consulta.Append("adn a.IDFacturaDeVenta = '" + pIDFactura + "' order by a.NombreProducto; ");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
    }
}
