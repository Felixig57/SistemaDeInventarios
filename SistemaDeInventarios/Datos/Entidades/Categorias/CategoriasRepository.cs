using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Categorias
{
    public class CategoriasRepository
    {
        //Metodo para hacer select
        public List<Categorias> Enlistar()
        {
            //Metodo para poner en uso la BD
            using (ConexionBD conexion = new ConexionBD())
            { 
                return conexion.GetTable<Categorias>().ToList();
            }
        }
    }
}
