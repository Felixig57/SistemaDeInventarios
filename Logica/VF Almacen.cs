using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Bibloteca.Validar_Forms
{
    public class VF_Almacen : Entradas
    {
        private List<TextBox> Lista = new List<TextBox>();
        private List<Label> listaLabel = new List<Label>();
        public VF_Almacen(List<TextBox> Lista, List<Label> listaLabel)
        {
            this.Lista = Lista;
            this.listaLabel = listaLabel;
        }

        public void ValidarCampos()
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
            }
            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                listaLabel[1].ForeColor = Color.Red;
                Lista[1].Focus();
            }
            else if (Lista[2].Text == string.Empty)
            {
                MessageBox.Show("El campo Responsable no puede estar vacio");
                listaLabel[2].ForeColor = Color.Red;
                Lista[2].Focus();
            }
            else if (Lista[3].Text == string.Empty)
            {
                MessageBox.Show("El campo Telefono no puede estar vacio");
                listaLabel[3].ForeColor = Color.Red;
                Lista[3].Focus();
            }
            else if (Lista[4].Text == string.Empty)
            {
                MessageBox.Show("El campo Ubicacion no puede estar vacio");
                listaLabel[4].ForeColor = Color.Red;
                Lista[4].Focus();
            }
            else
            {
                MessageBox.Show("Almacen Agregado Correctamente");

                // Aquí puedes mandar llamar a tu método para guardar en la base de datos
            }


        }

    }
}