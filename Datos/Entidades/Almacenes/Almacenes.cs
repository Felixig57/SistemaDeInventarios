using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades.Almacenes
{
    public class Almacenes
    {
   
        //propiedades automimplementadas con sus metodos de acceso
        public int IdAlmacen { get; set; }
        public string NombreAlmacen { get; set; }
        public string ResponsableAlmacen { get; set; }
        public string TelefonoAlmacen { get; set; }
        public string UbicacionAlmacen { get; set; }

    }
}
