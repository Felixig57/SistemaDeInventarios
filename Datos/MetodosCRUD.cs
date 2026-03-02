using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{

    public class MetodosCRUD : ConexiónBD
    {
        #region CRUD PARA ALMACEN

        public void InsertarAlmacen(int id,string nombre, string responsable, string telefono, string ubicacion)
        {  // este es el metodo para insertar un nuevo registro en la tabla Almacenes, recibe como parámetros el nombre del almacén, el responsable, el teléfono y la ubicación.
            try // el try catch se usa para poder manejar cualquier excepcion que pueda ocurrir
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de insercion a la base de datos
                    "INSERT INTO Almacenes (IdAlmacen, NombreAlmacen, ResponsableAlmacen, TelefonoAlmacen, UbicacionAlmacen) " +
                    "VALUES (@id,@nombre, @responsable, @telefono, @ubicacion)", conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre); //Aqui asignamos los valores a los parámetros de la consulta SQL 
                cmd.Parameters.AddWithValue("@responsable", responsable); //Aqui asignamos los valores a los parámetros de la consulta SQL 
                cmd.Parameters.AddWithValue("@telefono", telefono); //Aqui asignamos los valores a los parámetros de la consulta SQL 
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion); //Aqui asignamos los valores a los parámetros de la consulta SQL 

                cmd.ExecuteNonQuery(); //Ejecuta la consulta SQL.
                MessageBox.Show("Almacén insertado correctamente."); //Muestra un mensaje indicando que el almacén se ha insertado correctamente.
            }
            catch (Exception ex) //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void ActualizarAlmacen(int id, string nombre, string responsable, string telefono, string ubicacion) // este es el metodo para actualizar un registro existente en la tabla Almacenes, recibe como parámetros el id del almacén a actualizar, el nuevo nombre, el nuevo responsable, el nuevo teléfono y la nueva ubicación.
        {
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de actualización a la base de datos
                    "UPDATE Almacenes SET NombreAlmacen=@nombre, ResponsableAlmacen=@responsable, " +
                    "TelefonoAlmacen=@telefono, UbicacionAlmacen=@ubicacion WHERE IdAlmacen=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos los valores a los parámetros de la consulta SQL
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@responsable", responsable);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

                cmd.ExecuteNonQuery(); //Ejecuta la consulta SQL.
                MessageBox.Show("Almacén actualizado correctamente."); //Muestra un mensaje indicando que el almacén se ha actualizado correctamente.
            }
            catch (Exception ex) //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void EliminarAlmacen(int id) // este es el metodo para eliminar un registro existente en la tabla Almacenes, recibe como parámetro el id del almacén a eliminar.
        {
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Almacenes WHERE IdAlmacen=@id", conexion); // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de eliminación a la base de datos

                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos el valor del id del almacén a eliminar al parámetro de la consulta SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("Almacén eliminado correctamente."); //Muestra un mensaje indicando que el almacén se ha eliminado correctamente.
            }
            catch (Exception ex) //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }
        //metodo para cargar desde la bd, con un select * from, 
        public DataTable MostrarAlmacenes()
        {
            DataTable tabla = new DataTable();// objeto que extrae datos de la tabla

            try
            {
                AbrirConexion();//se abre conexion desde nuestro metodo que esta en ConexionBD
                SqlCommand cmd = new SqlCommand("SELECT * FROM Almacenes", conexion);//la query que se ejecuta desde la bd
                SqlDataAdapter datos = new SqlDataAdapter(cmd);//variable que obtiene los datos
                datos.Fill(tabla);//llenar la tabal
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return tabla;//retornamos la tabla llena
        }

        #endregion

        #region CRUD PARA PROVEEDORES
        public void InsertarProveedor(string nombre, string correo, string telefono, string direccion)
        {// este es el metodo para insertar un nuevo registro en la tabla Proveedores, recibe como parámetros el nombre del proveedor, el correo electrónico, el teléfono y la dirección.

            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de insercion a la base de datos
                    "INSERT INTO Proveedores (NombreProveedor, CorreoProveedor, TelefonoProveedor, DireccionProveedor) " +
                    "VALUES (@nombre, @correo, @telefono, @direccion)", conexion);

                cmd.Parameters.AddWithValue("@nombre", nombre); //Aqui asignamos los valores a los parámetros de la consulta SQL
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);

                cmd.ExecuteNonQuery(); //Ejecuta la consulta SQL.
                MessageBox.Show("Proveedor insertado correctamente."); //Muestra un mensaje indicando que el proveedor se ha insertado correctamente.
            }
            catch (Exception ex) //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void ActualizarProveedor(int id, string nombre, string correo, string telefono, string direccion)
        { // este es el metodo para actualizar un registro existente en la tabla Proveedores, recibe como parámetros el id del proveedor a actualizar, el nuevo nombre, el nuevo correo electrónico, el nuevo teléfono y la nueva dirección.
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de actualización a la base de datos
                    "UPDATE Proveedores SET NombreProveedor=@nombre, CorreoProveedor=@correo, " +
                    "TelefonoProveedor=@telefono, DireccionProveedor=@direccion WHERE IdProveedor=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos el valor del id del proveedor a actualizar al parámetro de la consulta SQL
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);

                cmd.ExecuteNonQuery(); //Ejecuta la consulta SQL.
                MessageBox.Show("Proveedor actualizado correctamente."); //Muestra un mensaje indicando que el proveedor se ha actualizado correctamente.
            }
            catch (Exception ex)//Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void EliminarProveedor(int id) // este es el metodo para eliminar un registro existente en la tabla Proveedores, recibe como parámetro el id del proveedor a eliminar.
        {
            try
            {
                AbrirConexion();//abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de eliminación a la base de datos
                    "DELETE FROM Proveedores WHERE IdProveedor=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos el valor del id del proveedor a eliminar al parámetro de la consulta SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente."); //Muestra un mensaje indicando que el proveedor se ha eliminado correctamente.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        #endregion

        #region CRUD PARA PRODUCTOS
        public void InsertarProducto(string nombre, string descripcion, string categoria, string proveedor, int cantidad)
        { // este es el metodo para insertar un nuevo registro en la tabla Productos, recibe como parámetros el nombre del producto, la descripción, la categoría, el proveedor y la cantidad.
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de insercion a la base de datos
                    "INSERT INTO Productos (NombreProducto, DescripcionProducto, Categoria, Proveedor, Cantidad) " +
                    "VALUES (@nombre, @descripcion, @categoria, @proveedor, @cantidad)", conexion);

                cmd.Parameters.AddWithValue("@nombre", nombre); //Aqui asignamos los valores a los parámetros de la consulta SQL
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.ExecuteNonQuery(); //Ejecuta la consulta SQL.
                MessageBox.Show("Producto insertado correctamente.");
            }
            catch (Exception ex) // Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();//Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void ActualizarProducto(int id, string nombre, string descripcion, string categoria, string proveedor, int cantidad)
        { // este es el metodo para actualizar un registro existente en la tabla Productos, recibe como parámetros el id del producto a actualizar, el nuevo nombre, la nueva descripción, la nueva categoría, el nuevo proveedor y la nueva cantidad.
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de actualización a la base de datos
                    "UPDATE Productos SET NombreProducto=@nombre, DescripcionProducto=@descripcion, " +
                    "Categoria=@categoria, Proveedor=@proveedor, Cantidad=@cantidad WHERE IdProducto=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos los valores a los parámetros de la consulta SQL
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.ExecuteNonQuery(); // Ejecuta la consulta SQL.
                MessageBox.Show("Producto actualizado correctamente."); //Muestra un mensaje indicando que el producto se ha actualizado correctamente.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void EliminarProducto(int id) // este es el metodo para eliminar un registro existente en la tabla Productos, recibe como parámetro el id del producto a eliminar.
        {
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de eliminación a la base de datos
                    "DELETE FROM Productos WHERE IdProducto=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos el valor del id del producto a eliminar al parámetro de la consulta SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente."); //Muestra un mensaje indicando que el producto se ha eliminado correctamente.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }
        #endregion

        #region CRUD PARA CATEGORIAS
        public void InsertarCategoria(string nombre, string descripcion)
        { // este es el metodo para insertar un nuevo registro en la tabla Categorias, recibe como parámetros el nombre de la categoría y la descripción.
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de insercion a la base de datos
                    "INSERT INTO Categorias (NombreCategoria, DescripcionCategoria) " +
                    "VALUES (@nombre, @descripcion)", conexion);

                cmd.Parameters.AddWithValue("@nombre", nombre); //Aqui asignamos los valores a los parámetros de la consulta SQL
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.ExecuteNonQuery(); //Ejecuta la consulta SQL.
                MessageBox.Show("Categoría insertada correctamente.");//Muestra un mensaje indicando que la categoría se ha insertado correctamente.
            }
            catch (Exception ex) //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void ActualizarCategoria(int id, string nombre, string descripcion) // este es el metodo para actualizar un registro existente en la tabla Categorias, recibe como parámetros el id de la categoría a actualizar, el nuevo nombre y la nueva descripción.
        {
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de actualización a la base de datos
                    "UPDATE Categorias SET NombreCategoria=@nombre, " +
                    "DescripcionCategoria=@descripcion WHERE IdCategoria=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos los valores a los parámetros de la consulta SQL
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.ExecuteNonQuery(); //Ejecuta la consulta SQL.
                MessageBox.Show("Categoría actualizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }

        public void EliminarCategoria(int id) // este es el metodo para eliminar un registro existente en la tabla Categorias, recibe como parámetro el id de la categoría a eliminar.
        {
            try
            {
                AbrirConexion(); //abre la conexion
                SqlCommand cmd = new SqlCommand( // se crea un objeto llamado cmd de tipo SqlCommand y se le asigna la consulta SQL de eliminación a la base de datos
                    "DELETE FROM Categorias WHERE IdCategoria=@id", conexion);
                cmd.Parameters.AddWithValue("@id", id); //Aqui asignamos el valor del id de la categoría a eliminar al parámetro de la consulta SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoría eliminada correctamente."); //Muestra un mensaje indicando que la categoría se ha eliminado correctamente.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si ocurre una excepción, se captura y se muestra un mensaje de error con la información de la excepción.
            }
            finally
            {
                CerrarConexion(); //Finalmente, se cierra la conexión a la base de datos.
            }
        }
        #endregion
    }
}