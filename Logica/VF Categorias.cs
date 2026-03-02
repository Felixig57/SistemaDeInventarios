using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class VF_Categorias : Entradas
    {
        private List<TextBox> Lista = new List<TextBox>(); //Creamos el objeto Lista de tipo List para contener elementos tipo textbox
        private List<Label> listaLabel = new List<Label>();//Creamos el objeto listaLabel de tipo  List para contener elementos tipo Label
        public VF_Categorias(List<TextBox> Lista, List<Label> listaLabel) //En el contructor asignamos los parametros a las variables
        {
            this.Lista = Lista;
            this.listaLabel = listaLabel;
        }
        public bool ValidarCampos() //este es un metodo booleano que validará que el texto de los textboxs no estén vacíos
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede quedar vacío");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
                return false;
            }

            if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("Nombre vacío");
                listaLabel[1].ForeColor = Color.Red;
                Lista[1].Focus();
                return false;
            }

            if (Lista[2].Text == string.Empty)
            {
                MessageBox.Show("Descripción vacía");
                listaLabel[2].ForeColor = Color.Red;
                Lista[2].Focus();
                return false;
            }

            return true; // Todo correcto
        }
    } 
}

