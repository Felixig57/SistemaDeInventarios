using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Categorias

{
    [Table("Categorias")]  // <- faltaba esto
    public class Categorias
    {
        [PrimaryKey, Column("IdCategoria")]
        public int IdCategoria { get; set; }

        [Column("NombreCategoria")]
        public string NombreCategoria { get; set; }

        [Column("DescripcionCategoria")]
        public string DescripcionCategoria { get; set; }
    }
}
