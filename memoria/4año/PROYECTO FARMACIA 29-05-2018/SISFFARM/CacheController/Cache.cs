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
            Consulta.Append("SELECT IDEmpleado, Nombres, Apellidos, Direccion, Telefono, FechaNacimiento, Email, Genero,DUI,Foto FROM empleados  ORDER BY Apellidos ASC;");
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

        public static DataTable TODOS_LAS_FACTURAS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append(@"SELECT a.IDFacturaDeVenta, a.NumeroDeFactura a.Fecha, a.FormaDePago, a.IDCliente, c.Nombres, a.IDEmpleado, d.Nombres,
                b.Excento, b.Gravado, b.NoSujeto, a.TotalAPagar, 
                b.IDDetalleFactura, b.Cantidad, b.Precio, b.NombreProducto, b.IDProducto, b.IDFacturaDeVenta,
                FROM facturasdeventas a, detallesfacturas b, clientes c, empleados d
                WHERE a.IDFacturaDeVenta = b.IDFacturaDeVenta and a.IDCliente = c.IDCliente and a.IDEmpleado = d.IDEmpleado;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
    }
}
