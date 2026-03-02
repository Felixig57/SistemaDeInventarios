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
   public class VF_Proveedores : Entradas //esta clase hereda de la clase Entradas para poder usar sus validaciones
        {
            private List<TextBox> Lista = new List<TextBox>(); //se crean los objetos que necesitaremos
        private List<Label> listaLabel = new List<Label>();
            public VF_Proveedores(List<TextBox> Lista, List<Label> listaLabel) //en el contructor asignamos los argumentos que pedimos y los asignamos a las variables locales
            {
                this.Lista = Lista;
            this.listaLabel = listaLabel;
            }
        public bool ValidarCampos() //programamos esta funcion booleana que valida si los campos están vacíos
        {
            // 0 = ID
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
                return false;
            }
            // 1 = Nombre
            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                listaLabel[1].ForeColor = Color.Red;
                Lista[1].Focus();
                return false;
            }
            // 2 = Telefono
            else if (Lista[2].Text == string.Empty)
            {
                MessageBox.Show("El campo Telefono no puede estar vacio");
                listaLabel[2].ForeColor = Color.Red;
                Lista[2].Focus();
                return false;
            }
            // 3 = Correo
            else if (Lista[3].Text == string.Empty)
            {
                MessageBox.Show("El campo Correo no puede estar vacio");
                listaLabel[3].ForeColor = Color.Red;
                Lista[3].Focus();
                return false;
            }
            // 4 = Direccion
            else if (Lista[4].Text == string.Empty)
            {
                MessageBox.Show("El campo Direccion no puede estar vacio");
                listaLabel[4].ForeColor = Color.Red;
                Lista[4].Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

    }
    }

