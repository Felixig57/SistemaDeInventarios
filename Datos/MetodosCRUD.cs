using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{

    public class MetodosCRUD : ConexiónBD
    {
        #region CRUD PARA ALMACEN

        public void InsertarAlmacen(string nombre, string responsable, string telefono, string ubicacion)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Almacenes (NombreAlmacen, ResponsableAlmacen, TelefonoAlmacen, UbicacionAlmacen) " +
                    "VALUES (@nombre, @responsable, @telefono, @ubicacion)", conexion);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@responsable", responsable);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Almacén insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ActualizarAlmacen(int id, string nombre, string responsable, string telefono, string ubicacion)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Almacenes SET NombreAlmacen=@nombre, ResponsableAlmacen=@responsable, " +
                    "TelefonoAlmacen=@telefono, UbicacionAlmacen=@ubicacion WHERE IdAlmacen=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@responsable", responsable);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Almacén actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarAlmacen(int id)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Almacenes WHERE IdAlmacen=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Almacén eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        #endregion

        #region CRUD PARA PROVEEDORES
        public void InsertarProveedor(string nombre, string correo, string telefono, string direccion)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Proveedores (NombreProveedor, CorreoProveedor, TelefonoProveedor, DireccionProveedor) " +
                    "VALUES (@nombre, @correo, @telefono, @direccion)", conexion);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ActualizarProveedor(int id, string nombre, string correo, string telefono, string direccion)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Proveedores SET NombreProveedor=@nombre, CorreoProveedor=@correo, " +
                    "TelefonoProveedor=@telefono, DireccionProveedor=@direccion WHERE IdProveedor=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarProveedor(int id)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Proveedores WHERE IdProveedor=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        #endregion

        #region CRUD PARA PRODUCTOS
        public void InsertarProducto(string nombre, string descripcion, string categoria, string proveedor, int cantidad)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Productos (NombreProducto, DescripcionProducto, Categoria, Proveedor, Cantidad) " +
                    "VALUES (@nombre, @descripcion, @categoria, @proveedor, @cantidad)", conexion);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ActualizarProducto(int id, string nombre, string descripcion, string categoria, string proveedor, int cantidad)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Productos SET NombreProducto=@nombre, DescripcionProducto=@descripcion, " +
                    "Categoria=@categoria, Proveedor=@proveedor, Cantidad=@cantidad WHERE IdProducto=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Productos WHERE IdProducto=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
        #endregion

        #region CRUD PARA CATEGORIAS
        public void InsertarCategoria(string nombre, string descripcion)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Categorias (NombreCategoria, DescripcionCategoria) " +
                    "VALUES (@nombre, @descripcion)", conexion);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoría insertada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ActualizarCategoria(int id, string nombre, string descripcion)
        {
            try
            {
                AbrirConexion();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Categorias SET NombreCategoria=@nombre, " +
                    "DescripcionCategoria=@descripcion WHERE IdCategoria=@id", conexion);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoría actualizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        #endregion
        }
    }
}