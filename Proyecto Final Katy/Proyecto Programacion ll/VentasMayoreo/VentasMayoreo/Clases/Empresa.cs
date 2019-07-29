using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace VentasMayoreo.Clases
{
    class Empresa
    {
        public static List<Cliente> getClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select * from cargarClientes");
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while (reader.Read())
                {
                    int clave = Convert.ToInt16(reader.GetValue(0).ToString());
                    string nombre = reader.GetValue(1).ToString();
                    string paterno = reader.GetValue(2).ToString();
                    string materno = reader.GetString(3);
                    char sexo = reader.GetString(4)[0];
                    string direccion = reader.GetString(5);
                    string fecha = reader.GetDateTime(6).ToShortDateString();
                    string telefono = reader.GetValue(7).ToString();
                    double monto = Convert.ToDouble(reader.GetValue(8).ToString());
                    double saldo = Convert.ToDouble(reader.GetValue(9).ToString());               
                    Cliente cliente = new Cliente(clave, nombre, paterno, materno, sexo, fecha,direccion,telefono,monto,saldo);
                    clientes.Add(cliente);
                }
                Sql.Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return clientes;
        }
        public static List<Cliente> getClienteConAbono()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select * from clientesConAbono");
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while (reader.Read())
                {
                    int clave = Convert.ToInt16(reader.GetValue(0).ToString());
                    string nombre = reader.GetValue(1).ToString();
                    string paterno = reader.GetValue(2).ToString();
                    string materno = reader.GetString(3);
                    char sexo = reader.GetString(4)[0];
                    string direccion = reader.GetString(5);
                    string fecha = reader.GetDateTime(6).ToShortDateString();
                    string telefono = reader.GetValue(7).ToString();
                    double monto = Convert.ToDouble(reader.GetValue(8).ToString());
                    double saldo = Convert.ToDouble(reader.GetValue(9).ToString());
                    Cliente cliente = new Cliente(clave, nombre, paterno, materno, sexo, fecha, direccion, telefono, monto, saldo);
                    clientes.Add(cliente);
                }
                Sql.Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return clientes;
        }
        public static List<Cliente> getClientesConVenta()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                Sql.Connection.Open();
                Sql.setCommand("select * from clientesConVenta");
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while (reader.Read())
                {
                    int clave = Convert.ToInt16(reader.GetValue(0).ToString());
                    string nombre = reader.GetValue(1).ToString();
                    string paterno = reader.GetValue(2).ToString();
                    string materno = reader.GetString(3);
                    char sexo = reader.GetString(4)[0];
                    string direccion = reader.GetString(5);
                    string fecha = reader.GetDateTime(6).ToShortDateString();
                    string telefono = reader.GetValue(7).ToString();
                    double monto = Convert.ToDouble(reader.GetValue(8).ToString());
                    double saldo = Convert.ToDouble(reader.GetValue(9).ToString());
                    Cliente cliente = new Cliente(clave, nombre, paterno, materno, sexo, fecha, direccion, telefono, monto, saldo);
                    clientes.Add(cliente);
                }
                Sql.Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return clientes;
        }
        public static int numeroClientes()
        {
            int numero = 0;
            try
            {
                string comando = "select coalesce(sum(claveCliente),0) from Clientes";
                Sql.Connection.Open();
                Sql.setCommand(comando);
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while(reader.Read())
                {
                    numero = Convert.ToInt16(reader.GetValue(0).ToString());
                }
                Sql.Connection.Close();
            }
            catch(SqlException ex)
            {
                Sql.Connection.Close();
                MessageBox.Show(ex.Message);
            }
            return numero;
        }
        public static List<Empleado> getEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            Sql.setCommand("select * from Empleados");
            try
            {
                Sql.Connection.Open();
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while(reader.Read())
                {
                    int clave = Convert.ToInt16(reader.GetValue(0).ToString());
                    int claveSucursal = Convert.ToInt16(reader.GetValue(1).ToString());
                    string nombre = reader.GetString(2);
                    string paterno = reader.GetString(3);
                    string materno = reader.GetString(4);
                    char sexo = reader.GetString(5)[0];
                    string direccion = reader.GetString(6);
                    string telefono = reader.GetValue(7).ToString();
                    Empleado empleado = new Empleado(clave, claveSucursal, nombre, paterno, materno, sexo, direccion, telefono);
                    empleados.Add(empleado);
                }
                Sql.Connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return empleados;
        }
       
        public static List<Sucursal> getSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            try
            {
                Sql.setCommand("select * from Sucursales");
                Sql.Connection.Open();
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while(reader.Read())
                {
                    int clave = Convert.ToInt16(reader.GetValue(0).ToString());
                    string nombre = reader.GetString(1);
                    string direccion = reader.GetString(2);
                    string telefono =  reader.GetValue(3).ToString();
                    Sucursal sucursal = new Sucursal(clave, nombre, direccion, telefono);
                    sucursales.Add(sucursal);
                }
                Sql.Connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return sucursales;
        }
        public static List<Articulo> getArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();

            string consulta = "select claveArticulo,descripcion,precio,claveCategoria from Articulos";
            Sql.setCommand(consulta);

            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            string clave, descripcion, precio, categoria;

                            clave = lector.GetValue(0).ToString();
                            descripcion = lector.GetValue(1).ToString();
                            precio = lector.GetValue(2).ToString();
                            categoria = lector.GetValue(3).ToString();

                            Articulo articulo = new Articulo(Convert.ToInt32(clave), descripcion, Convert.ToDouble(precio), Convert.ToInt32(categoria));

                            articulos.Add(articulo);
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }


            return articulos;
        }
        public static ArticuloAlmacenado getArticulo(int claveSucursal,int clavearticulo)
        {
            ArticuloAlmacenado articulo = null;
            try
            {
                Sql.Connection.Open();
                string consulta = string.Format("select art.claveArticulo,art.descripcion,art.precio,art.claveCategoria,existencia from Almacen a join Articulos art on art.claveArticulo=a.claveArticulo where claveSucursal='{0}' and art.claveArticulo ='{1}'", claveSucursal,clavearticulo);
                Sql.setCommand(consulta);
                SqlDataReader lector = Sql.Command.ExecuteReader();
                while(lector.Read())
                {
                    int clave = Convert.ToInt32(lector.GetValue(0).ToString());
                    string descripcion = lector.GetValue(1).ToString();
                    double precio = Convert.ToDouble(lector.GetValue(2).ToString());
                    int categoria = Convert.ToInt32(lector.GetValue(3).ToString());
                    int existencia = Convert.ToInt32(lector.GetValue(4).ToString());

                   articulo = new ArticuloAlmacenado(clave, descripcion, precio, categoria, existencia);
                }
                Sql.Connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return articulo;
        }
        public static List<ArticuloAlmacenado> getArticulosSucursal(string claveSucursal)
        {
            List<ArticuloAlmacenado> articulos = new List<ArticuloAlmacenado>();
            string consulta = string.Format("select art.claveArticulo,art.descripcion,art.precio,art.claveCategoria,existencia from Almacen a join Articulos art on art.claveArticulo=a.claveArticulo where claveSucursal={0}", claveSucursal);
            Sql.setCommand(consulta);

            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            int clave = Convert.ToInt32(lector.GetValue(0).ToString());
                            string descripcion = lector.GetValue(1).ToString();
                            double precio = Convert.ToDouble(lector.GetValue(2).ToString());
                            int categoria = Convert.ToInt32(lector.GetValue(3).ToString());
                            int existencia = Convert.ToInt32(lector.GetValue(4).ToString());

                            ArticuloAlmacenado articulo = new ArticuloAlmacenado(clave, descripcion, precio, categoria, existencia);

                            articulos.Add(articulo);
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }


            return articulos;
        }

        public static List<Categoria> getCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            string consulta = "select claveCategoria,nombre from Categorias";
            Sql.setCommand(consulta);

            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            string clave, nombre;

                            clave = lector.GetValue(0).ToString();
                            nombre = lector.GetValue(1).ToString();

                            Categoria categoria = new Categoria(Convert.ToInt32(clave), nombre);

                            categorias.Add(categoria);
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }

            return categorias;
        }
        public static List<DetalleDeVenta> getDetalleVenta(int claveVenta)
        {
            List<DetalleDeVenta> detalles = new List<DetalleDeVenta>();
            try
            {
                string comando = string.Format("select a.claveArticulo,a.descripcion,d.cantidad,d.precio,d.importe from DetalleVenta d join Articulos a on a.claveArticulo = d.claveArticulo where d.claveVenta ='{0}'", claveVenta);
                Sql.Connection.Open();
                Sql.setCommand(comando);
                SqlDataReader reader = Sql.Command.ExecuteReader();
                while(reader.Read())
                {
                    int clave = Convert.ToInt16(reader.GetValue(0).ToString());
                    string descripcion = reader.GetString(1);
                    int cantidad = Convert.ToInt32(reader.GetValue(2).ToString());
                    double precio = Convert.ToDouble(reader.GetValue(3).ToString());
                    double importe = Convert.ToDouble(reader.GetValue(4).ToString());
                    DetalleDeVenta detalle = new DetalleDeVenta(clave, descripcion, cantidad, precio, importe);
                    detalles.Add(detalle);
                }
                Sql.Connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Sql.Connection.Close();
            }
            return detalles;
        }
        public static string getClaveCategoria(string nombre)
        {
            string clave = null;
            string consulta =
                string.Format("select claveCategoria from Categorias where nombre='{0}'", nombre);
            Sql.setCommand(consulta);

            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            clave = lector.GetValue(0).ToString();
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }


            return clave;
        }
        public static string getNombreCategoria(int clave)
        {
            string nombre = null;
            List<Categoria> categorias = getCategorias();
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Clave == clave)
                    nombre = categoria.Nombre;
            }

            return nombre;
        }

        public static List<Almacen> getAlmacenGeneral()
        {
            List<Almacen> almacenes = new List<Almacen>();

            string consulta = "select s.nombre,art.descripcion,existencia from Almacen a join Articulos art on a.claveArticulo=art.claveArticulo join Sucursales s on s.claveSucursal=a.claveSucursal order by (a.claveSucursal)";
            Sql.setCommand(consulta);

            if (Sql.AbrirConexion())
            {
                try
                {
                    SqlDataReader lector = Sql.Command.ExecuteReader();

                    if (lector.HasRows)
                        while (lector.Read())
                        {
                            string sucursal, articulo, existencia;

                            sucursal = lector.GetValue(0).ToString();
                            articulo = lector.GetValue(1).ToString();
                            existencia = lector.GetValue(2).ToString();

                            Almacen almacen = new Almacen(sucursal, articulo, existencia);

                            almacenes.Add(almacen);
                        }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                        MessageBox.Show(error.Message);
                }
                Sql.Connection.Close();
            }

            return almacenes;
        }
    }
}
