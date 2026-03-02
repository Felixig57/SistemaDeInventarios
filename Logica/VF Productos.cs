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
   public class VF_Productos : Entradas
    {
        private List<TextBox> ListaBotonesText;
        private List<ComboBox> ListaCombos;
        private List<NumericUpDown> ListaNumeros;
        private List<Label> ListaLabels;
        public VF_Productos(List<TextBox> listaText, List<ComboBox> listaCombo, List<NumericUpDown> listaNum, List<Label> listaLabel)
        {
            this.ListaBotonesText = listaText;
            this.ListaCombos = listaCombo;
            this.ListaNumeros = listaNum;
            this.ListaLabels = listaLabel;
        }
        //Agregar las otras validacion a expecion de la descripcion del producto
        public bool Validacion()
        {
            // 1. Validar Id Producto (TextBox 0)
            if (ListaBotonesText[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID del producto no puede quedar vacio");
                ListaLabels[0].ForeColor = Color.Red;
                ListaBotonesText[0].Focus();
                return false;
            }
            // 2. Validar Nombre (TextBox 1)
            else if (ListaBotonesText[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre del producto no puede quedar vacio");
                ListaLabels[1].ForeColor = Color.Red;
                ListaBotonesText[1].Focus();
                return false;
            }
            // -- Nos saltamos ListaBotonesText[2] (Descripción) porque es opcional --
            // 3. Validar Categoria (ComboBox 0)
            else if (ListaCombos[0].SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Categoría");
                ListaLabels[3].ForeColor = Color.Red;
                ListaCombos[0].Focus();
                return false;
            }
            // 4. Validar Proveedor (ComboBox 1)
            else if (ListaCombos[1].SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Proveedor");
                ListaLabels[4].ForeColor = Color.Red;
                ListaCombos[1].Focus();
                return false;
            }
            // 5. Validar Cantidad (NumericUpDown 0)
            else if (ListaNumeros[0].Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero");
                ListaLabels[5].ForeColor = Color.Red;
                ListaNumeros[0].Focus();
                return false;
            }
            // 6. Si todo está correcto
            else
            {
                return true;
            }
        }
    }
}
