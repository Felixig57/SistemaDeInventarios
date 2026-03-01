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
            // Ocultamos el menu 
            menuPrincipal.Hide();

            // Creamos la nueva pantalla con un objeto nueva ventana
            objVentana nuevaVentana = new objVentana();

            //pausa la ejecución del código aquí hasta que la ventana se cierre
            nuevaVentana.ShowDialog();

            //mostrar el menu al momento del cierre de un formulario
            menuPrincipal.Show();
        }

    }
}
