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
        /*public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDRol, Rol FROM roles  ORDER BY Rol ASC;");C:\Users\PC-27\Desktop\USO Sistema de Facturacion - Usuario - Reporte\CacheController\Cache.cs
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }*/
        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDEmpleado, Nombres, Apellidos,FechaNacimiento,Genero FROM empleados  ORDER BY Apellidos ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable LIBRO_DE_VENTAS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append(@"SELECT
            a.OrderID, a.CustomerID, d.ContactName,
            a.EmployeeID, CONCAT(e.FirstName, ' ', e.LastName) as 'Empleado', a.OrderDate,
            b.ProductID, c.ProductName,
            b.Quantity, b.UnitPrice
            FROM
            orders a, orderdetails b,
            products c, customers d,
            employees e
            WHERE
            a.OrderID = b.OrderID
            AND
            b.ProductID = c.ProductID
            AND
            a.CustOmerID = d.CustOmerID
            AND
            a.EmployeeID = e.EmployeeID; ");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }

        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDUsuario, Usuario, Credencial, IDEmpleado, IDRol FROM usuarios  ORDER BY Usuario ASC;");
            DataController.Operacion oOperacion = new DataController.Operacion();
            Resultado = oOperacion.Consultar(Consulta.ToString());
            return Resultado;
        }
        public static DataTable REPORTE_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Consulta = new StringBuilder();
            Consulta.Append("SELECT IDEmpleado, Nombres, Apellidos,FechaNacimiento,Genero FROM empleados ORDER BY Apellidos, Nombres;");
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
