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
        private List<TextBox> Lista = new List<TextBox>();
        private List<Label> listaLabel = new List<Label>();
        public VF_Categorias(List<TextBox> Lista, List<Label> listaLabel)
        {
            this.Lista = Lista;
            this.listaLabel = listaLabel;
        }
        public void ValidarCampos()
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede quedar vacio");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
            }
            else
            {
                if (Lista[1].Text == string.Empty)
                {
                    MessageBox.Show("Descripcion vacia");
                    listaLabel[1].ForeColor = Color.Red;
                    Lista[1].Focus();
                }
            }
        }
    } 
}

