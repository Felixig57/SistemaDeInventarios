using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios.Navegacion
{
    //referencia para mantener el formulario y no abrirlo 2 veces
    //private frmProductos formProductos = null;
    public static class GestorNavegacion
    {
        // Método para navegación lineal: Oculta el menú, abre la ventana, y al cerrar regresa al menú
        public static void AbrirYOCultarMenu<objVentana>(Form menuPrincipal) where objVentana : Form, new()
        {
            // 1. Ocultamos el menú que nos pasaron
            menuPrincipal.Hide();

            // 2. Creamos la nueva pantalla (ej. frmProductos)
            objVentana nuevaVentana = new objVentana();

            // 3. ShowDialog hace la magia: pausa la ejecución del código aquí hasta que la ventana se cierre
            nuevaVentana.ShowDialog();

            // 4. Cuando el usuario cierra la nueva ventana (con la 'X' o un botón Regresar), mostramos el menú de nuevo
            menuPrincipal.Show();
        }

    }
}
