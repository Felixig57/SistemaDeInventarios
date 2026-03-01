using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class VF_Almacen : Entradas
    {
        private List<TextBox> Lista = new List<TextBox>();
        public VF_Almacen(List<TextBox> Lista)
        {
            this.Lista = Lista;
        }
        public void ValidarCampos()
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                Lista[0].Focus();
            }
            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Telefono no puede estar vacio");
                Lista[1].Focus();

            }
            else if (Lista[2].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                Lista[2].Focus();
            }
            else if (Lista[3].Text == string.Empty)
            {
                MessageBox.Show("El campo Ubicacion no puede estar vacio");
                Lista[3].Focus();
            }
            else if (Lista[4].Text == string.Empty)
            {
                MessageBox.Show("El campo Responsable no puede estar vacio");
                Lista[4].Focus();
            }
            else
            {
                MessageBox.Show("Almacen Agregado Correctamente");
            }
        }

    }
}
