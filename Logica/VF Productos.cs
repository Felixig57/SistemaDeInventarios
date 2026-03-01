using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
   public class VF_Productos : Entradas
    {
        private List<TextBox> Lista;
        public VF_Productos(List<TextBox> Lista)
        {
            this.Lista = Lista;
        }
        //Agregar las otras validacion a expecion de la descripcion del producto
        public void Validacion()
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID del producto no puede quedar vacio");
                Lista[0].Focus();
            }
            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre del producto no puede quedar vacio");
                Lista[1].Focus();
            }
            else
            {
                MessageBox.Show("Producto registrado con exito");
            }
            }
    }
}
