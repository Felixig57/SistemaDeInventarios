using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class ConexiónBD
    {

        protected SqlConnection conexion;

        public ConexiónBD()
        {
            conexion = new SqlConnection("Server=AARONCOMPU\\AARONNDEVGG2;Database=SistemaInventarios;Integrated Security=True;");
        }

        public void AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            MessageBox.Show("Conexión abierta exitosamente.");
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            MessageBox.Show("Conexión cerrada exitosamente.");
        }
    }
}
