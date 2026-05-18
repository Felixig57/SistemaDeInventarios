using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Proveedores
{
    public class Proveedores
    {
        [PrimaryKey]
        public int IdProveedor { get; set; }
        public string NombreProveedor {  get; set; }
        public string TelefonoProveedor {  get; set; }
        public string CorreoProveedor { get; set; }
        public string DireccionProveedor { get; set; }
    }
}
