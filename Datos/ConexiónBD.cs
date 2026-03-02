using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class ConexiónBD
    {

        protected SqlConnection conexion; //Aqui se crea una variable de tipo SqlConnection protegida usada para establecer la conexión con la base de datos

        public ConexiónBD() //este es el constructor que al ejecutarce inicializa la variable conexion con la cadena de conexión a la base de datos, especificando el servidor, la base de datos y las credenciales necesarias.
        {
            conexion = new SqlConnection("Server=AARONCOMPU\\AARONNDEVGG2;Database=SistemaInventarios;Integrated Security=True;");
        }

        public void AbrirConexion() //Este método se encarga de abrir la conexión a la base de datos.
        {
            if (conexion.State == System.Data.ConnectionState.Closed) //Verifica si la conexión está cerrada antes de intentar abrirla.
                conexion.Open();
            MessageBox.Show("Conexión abierta exitosamente."); //Muestra un mensaje indicando que la conexión se ha abierto exitosamente.
        }

        public void CerrarConexion() //Este método se encarga de cerrar la conexión a la base de datos.
        {
            if (conexion.State == System.Data.ConnectionState.Open) //Verifica si la conexión está abierta antes de intentar cerrarla.
                conexion.Close();//Cierra la conexión
            MessageBox.Show("Conexión cerrada exitosamente.");//Muestra un mensaje indicando que la conexión se ha cerrado exitosamente.
        }
    }
}
