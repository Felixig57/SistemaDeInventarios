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
        public void Validacion()
        {
            // 1. Validar Id Producto (TextBox 0)
            if (ListaBotonesText[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID del producto no puede quedar vacio");
                ListaLabels[0].ForeColor = Color.Red;
                ListaBotonesText[0].Focus();
            }
            // 2. Validar Nombre (TextBox 1)
            else if (ListaBotonesText[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre del producto no puede quedar vacio");
                ListaLabels[1].ForeColor = Color.Red;
                ListaBotonesText[1].Focus();
            }

            // -- Nos saltamos ListaBotonesText[2] (Descripción) porque es opcional --

            // 3. Validar Categoria (ComboBox 0)
            else if (ListaCombos[0].SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Categoría");
                ListaLabels[3].ForeColor = Color.Red; // Índice 3 es lblCategoria
                ListaCombos[0].Focus();
            }
            // 4. Validar Proveedor (ComboBox 1)
            else if (ListaCombos[1].SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Proveedor");
                ListaLabels[4].ForeColor = Color.Red; // Índice 4 es lblProveedor
                ListaCombos[1].Focus();
            }
            // 5. Validar Cantidad (NumericUpDown 0)
            else if (ListaNumeros[0].Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero");
                ListaLabels[5].ForeColor = Color.Red; // Índice 5 es lblCantidad
                ListaNumeros[0].Focus();
            }
            // 6. Si todo está correcto
            else
            {
                MessageBox.Show("Producto registrado con exito");
            }
        }
    }
}
