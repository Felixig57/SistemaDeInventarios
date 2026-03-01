using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class VF_Categorias : Entradas
    {
        private List<TextBox> Lista = new List<TextBox>();
        public VF_Categorias(List<TextBox> Lista)
        {
            this.Lista = Lista;
        }
        public void ValidarCampos()
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede quedar vacio");
                Lista[0].Focus();
            }
            else
            {
                MessageBox.Show("Categoria Agregada Correctamente");
            }
        }
    } 
}

