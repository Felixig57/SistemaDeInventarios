using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Proveedores
{
    [Table("Proveedores")]
    public class Proveedores
    {
        [PrimaryKey, Column("IdProveedor")]
        public int IdProveedor { get; set; }

        [Column("NombreProveedor")]
        public string NombreProveedor { get; set; }

        [Column("TelefonoProveedor")]
        public string TelefonoProveedor { get; set; }

        [Column("CorreoProveedor")]
        public string CorreoProveedor { get; set; }

        [Column("DireccionProveedor")]
        public string DireccionProveedor { get; set; }
    }
}
