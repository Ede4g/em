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
        public static DataTable LIBRO_DE_VENTAS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append(@"SELECT 
            a.OrderID, a.CustomerID, d.ContactName,
            a.EmployeeID, CONCAT(e.FirstName, ' ', e.LastName) as 'Empleado',
            a.OrderDate,
            b.ProductID, c.ProductName,
            b.Quantity, b.UnitPrice
            FROM
            orders a, orderdetails b,
            products c, customers d, employees e
            WHERE
            a.OrderID = b.OrderID
            AND b.ProductID = c.ProductID
            AND a.CustomerID = d.CustomerID
            AND a.EmployeeID = e.EmployeeID; ");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable PERMISOS_DE_UN_USUARIO(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDOpcion,(Select Opcion from Opciones r where r.IDOpcion=p.IDOpcion) as 'Opcion' FROM sifbd.permisos p where IDRol="+pIDRol+";");
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
            Consulta.Append("IFNULL((SELECT IDPermiso FROM permisos p WHERE p.IDRol = "+ pIDRol + " AND p.IDOpcion = a.IDOpcion), 0) as 'IDPermiso', ");
            Consulta.Append("(SELECT COUNT(IDPermiso) FROM permisos p WHERE p.IDRol = " + pIDRol + " AND p.IDOpcion = a.IDOpcion) AS 'Asignado', ");
            Consulta.Append("a.Clasificacion ");
            Consulta.Append("FROM ");
            Consulta.Append("opciones a ORDER BY Clasificacion, Opcion; ");
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
        public static DataTable VALIDAR_USUARIO(String pUsuario, String pCredencial)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT a.IDUsuario,a.Usuario, a.Credencial, a.IDEmpleado,CONCAT(b.Nombres,' ',b.Apellidos) as 'Empleado' ,a.IDRol,c.Rol FROM usuarios a, empleados b, roles c WHERE a.IDEmpleado=b.IDEmpleado AND a.IDRol=c.IDRol AND a.Usuario='"+pUsuario+"' AND a.Credencial=SHA1('"+pCredencial+"');");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
    }
}
