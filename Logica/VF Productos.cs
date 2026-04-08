using Datos;
using Datos.Entidades.Productos;
using LinqToDB;
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
   public class VF_Productos : Entradas //esta clase hereda de la clase Entradas para poder usar sus validaciones
    {
        DataGridView grindView;

        private List<TextBox> ListaBotonesText; //Creamos los objetos que necesitaremos usar 
        private List<ComboBox> ListaCombos;
        private List<NumericUpDown> ListaNumeros;
        private List<Label> ListaLabels;


        public VF_Productos(List<TextBox> listaText, List<ComboBox> listaCombo, List<NumericUpDown> listaNum, List<Label> listaLabel, Object[] objects)
        { //aquí asignamos los argumentos que llegaron del contructor a las variables locales que creamos arriba
            this.ListaBotonesText = listaText;
            this.ListaCombos = listaCombo;
            this.ListaNumeros = listaNum;
            this.ListaLabels = listaLabel; 
            this.grindView = (DataGridView)objects[0];
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
                ListaLabels[3].ForeColor = Color.Red;
                ListaCombos[0].Focus();
            }
            // 4. Validar Proveedor (ComboBox 1)
            else if (ListaCombos[1].SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Proveedor");
                ListaLabels[4].ForeColor = Color.Red;
                ListaCombos[1].Focus();
            }
            // 5. Validar Cantidad (NumericUpDown 0)
            else if (ListaNumeros[0].Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero");
                ListaLabels[5].ForeColor = Color.Red;
                ListaNumeros[0].Focus();
            }
            // 6. Si todo está correcto
            else
            {
                //Instanciamos la conexion para hacer la insercion
                ConexionBD conexion = new ConexionBD();

                //Hacemos la insercion a la base de datos con un metodo de linq2bd
                conexion.Insert(new Productos
                {
                    IdProducto = int.Parse(ListaBotonesText[0].Text),
                    NombreProducto = ListaBotonesText[1].Text,
                    DescripcionProducto = ListaBotonesText[2].Text, //Este campo es opcional, no se valido
                    Categoria = ListaCombos[0].SelectedItem.ToString(),
                    Proveedor = ListaCombos[1].SelectedItem.ToString(),
                    Cantidad = (int)ListaNumeros[0].Value
                });
                MessageBox.Show("Inserción exitosa");
                //daniel
                //agregue el limpiar campos
                LimpiarCampos();
            }
        }

        //Metodo para visualizar la lista de estudiantes en el DataGridView
        public void ListarProductos()
        {
            //Instanciar la conexion
            ConexionBD conexion = new ConexionBD();

            //Declarar una variable tipo padre para almacenar la consulta

            var ListaProductos = conexion.GetTable<Productos>()
                .Select(e => new
                {
                    //Tenemos que seleccionar cada una de las columnas que queremos mostrar en el DataGridView
                    e.IdProducto,
                    e.NombreProducto,
                    e.DescripcionProducto,
                    e.Categoria,
                    e.Proveedor,
                    e.Cantidad
                }).ToList();

            //Asignamos la lista al DataGridView
            this.grindView.DataSource = ListaProductos;
        }
        private void LimpiarCampos()
        {

            //ListaBotonesText[0].Clear();
            //ListaBotonesText[1].Clear();
            //ListaBotonesText[2].Clear();
            //ListaCombos[3].SelectedIndex = -1;
            //ListaCombos[4].SelectedIndex = -1;
            //ListaNumeros[5].Value = 0;
            // Limpia todas las cajas de texto automáticamente
            foreach (var textBox in ListaBotonesText)
            {
                textBox.Clear();
            }

            // Reinicia todos los combos automáticamente sin importar el índice
            foreach (var combo in ListaCombos)
            {
                combo.SelectedIndex = -1;
            }

            // Reinicia tus controles numéricos (asumiendo que es un NumericUpDown)
            foreach (var numControl in ListaNumeros)
            {
                numControl.Value = 0;
            }

            RestablecerLabels();

        }
        private void RestablecerLabels()
        {
            ListaLabels[0].ForeColor = Color.Black;
            ListaLabels[1].ForeColor = Color.Black;
            ListaLabels[2].ForeColor = Color.Black;
            ListaLabels[3].ForeColor = Color.Black;
            ListaLabels[4].ForeColor = Color.Black;
            ListaLabels[5].ForeColor = Color.Black;
        }
    }
}
