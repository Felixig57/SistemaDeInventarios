using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Categorias

{
    public class Categorias
    {
        //Propiedades AutoImplementadas con sus metodos de acceso (get y set)
        [PrimaryKey]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; } 

    }
}
