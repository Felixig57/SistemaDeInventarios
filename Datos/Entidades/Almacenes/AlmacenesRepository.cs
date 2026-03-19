using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Almacenes
{
    public class AlmacenesRepository
    {
        //este metodo es el que hace el select 
        public List<Almacenes> Listar()//
        {
            //metodo que pone un uso la bd
            using (ConexionBD conexion = new ConexionBD())
            {
                return conexion.GetTable<Almacenes>().ToList();//este metodo de Linq simula el Select * From que es la query que nos sirve para mostrar los datos en el dgv
            }
        }
    }
}
