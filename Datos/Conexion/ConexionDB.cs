using Datos.Entidades;
using Datos.Entidades.Almacenes;
using Datos.Entidades.Proveedores;
using LinqToDB.Data;
using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{
    public class ConexionBD: DataConnection//se hereda la funcion desde linqdb
    {
        //constructor para inicializar el objecto de la clase DataConnectionon
        public ConexionBD():base("ConexionSQL")
        {

        }
     //crear una interfaz para recuperar la informacion de los datos funciona como un puente
         public ITable<Almacenes> almacenes { get; set;  }
        public ITable<Proveedores> proveedores { get; set; }
         
         //aqui van los demas metodos get y set para los demas formularios
    }
}
