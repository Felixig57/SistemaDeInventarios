using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    // Manda a llamar a Entradas y validar que los campos no se queden vacios
    public class VAlmacenes : Entradas
    {
        private List<TextBox> lista;
        public VAlmacenes(List<TextBox> lista) { 
        this.lista = lista;
                }
        public void ValidarForms()
        {
            if (lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID del Almacen no puede estar vacio");
                lista[0].Focus();
            }
            else if (lista[1].Text == string.Empty)
                {
                    MessageBox.Show("El campo Telefono del Almacen no puede estar vacio");
                lista[1].Focus();
                }
                else if (lista[2].Text == string.Empty)
                {
                    MessageBox.Show("El campo Nombre del Almacen no puede estar vacio");
                lista[2].Focus();
            }
                else if (lista[3].Text == string.Empty)
                {
                    MessageBox.Show("El campo Ubicacion del Almacen no puede estar vacio");
                lista[3].Focus();
                }
                else if (lista[4].Text == string.Empty)
                {
                    MessageBox.Show("El campo Responsable del Almacen no puede estar vacio");
                lista[4].Focus();
                
            }
            }
        }
}
