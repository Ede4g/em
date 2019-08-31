using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace SessionController
{
    public class CountRegistros
    {
        String _CantRoles;
        String _CantEmpleados;
        String _CantUsuarios;
        String _CantProductos;
        String _CantClientes;
        String _CantOpciones;
        String _CantCategorias;
        String _CantPermisos;

        public string CantRoles
        {
            get
            {
                return _CantRoles;
            }
        }
        public string CantEmpleados
        {
            get
            {
                return _CantEmpleados;
            }
        }
        public string CantUsuarios
        {
            get
            {
                return _CantUsuarios;
            }
        }
        public string CantProductos
        {
            get
            {
                return _CantProductos;
            }
        }
        public string CantClientes
        {
            get
            {
                return _CantClientes;
            }
        }

        public string CantOpciones
        {
            get
            {
                return _CantOpciones;
            }
        }

        public string CantCategorias
        {
            get
            {
                return _CantCategorias;
            }
        }

        public string CantPermisos
        {
            get
            {
                return _CantPermisos;
            }
        }

        public Boolean CargarCantRoles()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODOS_LOS_ROLES();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantRoles = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }

        public Boolean CargarCantEmpleados()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODOS_LOS_EMPLEADOS();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantEmpleados = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }

        public Boolean CargarCantUsuarios()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODOS_LOS_USUARIOS();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantUsuarios = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }

        public Boolean CargarCantProductos()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODOS_LOS_PRODUCTOS();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantProductos = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }

        public Boolean CargarCantClientes()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODOS_LOS_CLIENTES();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantClientes = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }

        public Boolean CargarCantOpciones()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODAS_LAS_OPCIONES();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantOpciones = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }

        public Boolean CargarCantCategorias()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODAS_LAS_CATEGORIAS();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantCategorias = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }

        public Boolean CargarCantPermisos()
        {
            Boolean Cant = false;
            DataTable Resultado = new DataTable();
            Resultado = CacheController.Cache.TODAS_LAS_CATEGORIAS();
            if (Resultado.Rows.Count > 0)
            {
                Cant = true;
                _CantPermisos = Resultado.Rows.Count.ToString();
            }
            return Cant;
        }
    }
}
