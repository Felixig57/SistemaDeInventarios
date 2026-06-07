using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Productos
{

    [Table("Productos")]
    public class Productos
    {
        [PrimaryKey, Column("IdProducto")]
        public int IdProducto { get; set; }

        [Column("NombreProducto")]
        public string NombreProducto { get; set; }

        [Column("DescripcionProducto")]
        public string DescripcionProducto { get; set; }

        [Column("IdCategoria")]
        public int IdCategoria { get; set; }

        [Column("IdProveedor")]
        public int IdProveedor { get; set; }

        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Column("Imagen")]
        public byte[] Imagen { get; set; }
    }
}
