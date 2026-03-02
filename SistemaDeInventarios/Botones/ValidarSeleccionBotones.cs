using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios.Botones
{
    public static class ValidarSeleccionBotones
    {
            public static bool ValidarSeleccion(string id) //funcion booleana que valida que el lugar de id no esté vacío
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Debe seleccionar un registro.");
                    return false;
                }
                return true;
            }
        
    }
}
