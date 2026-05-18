using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Productos
{
    public class Productos
    {
        //Aqui van las propiedades autoimplementadas de la clase 
        [PrimaryKey]
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
        public int Cantidad { get; set; }
        public byte[] Imagen { get; set; }
    }
}
