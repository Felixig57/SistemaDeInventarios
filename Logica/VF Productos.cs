using Datos;
using Datos.Entidades.Productos;
using LinqToDB;
using LinqToDB.Common;
using Logica.Bibloteca;
using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
   public class VF_Productos : Entradas //esta clase hereda de la clase Entradas para poder usar sus validaciones
    {
        int _id = 0; //Variable para almacenar el id del producto, se inicializa en 0
        string _accion = "Insertar"; //Variabel para almacenar la accion que se vaya a realizar

        DataGridView grindView;
        PictureBox pictureBox; 

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
            this.pictureBox = (PictureBox)objects[1];
        }

        //Agregar las otras validacion a expecion de la descripcion del producto
        public void Validacion(String _accion)
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
                switch (_accion)
                {
                    case "Insertar":
                        Guardar();
                        break;

                    case "actualizar":
                        Editar();
                        break;
                }
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
                    e.Cantidad,
                    e.Imagen
                }).ToList();

            //Asignamos la lista al DataGridView
            this.grindView.DataSource = ListaProductos;
        }
        public Image ArrayToImage(byte[] bytes)
        {
            if (grindView.CurrentRow.Cells[6].Value != null)
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    return Image.FromStream(memoryStream);
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else return null;
        }

        public void ObtenerSeleccionProductos()
        {
            //Asignarle valor a la variable de id
            _id = Convert.ToInt32(grindView.CurrentRow.Cells[0].Value);

            //Asignar el contenido desde el DGV, hacia las cajas de texto
            ListaBotonesText[0].Text = grindView.CurrentRow.Cells[0].Value.ToString();
            ListaBotonesText[1].Text = grindView.CurrentRow.Cells[1].Value.ToString();
            ListaBotonesText[2].Text = grindView.CurrentRow.Cells[2].Value.ToString();
            ListaCombos[0].SelectedItem = grindView.CurrentRow.Cells[3].Value.ToString();
            ListaCombos[1].SelectedItem = grindView.CurrentRow.Cells[4].Value.ToString();
            ListaNumeros[0].Value = Convert.ToInt32(grindView.CurrentRow.Cells[5].Value);

            //intentar solicitar el array
            try
            {
                //Recoger la imagen, para lo cual, declaramos una variable tipo arreglo de bytes
                byte[] imagenComoArray = (byte[])grindView.CurrentRow.Cells[6].Value;
                //asignar la imagen
                pictureBox.Image = ArrayToImage(imagenComoArray);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro ninguna imagen: " + e);
                throw;
            }
        }
        private void LimpiarCampos()
        {
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

            foreach (var label in ListaLabels)
            {
                label.ForeColor = Color.Black;
            }
        }
        
        public void Guardar()
        {
            //Declarar una variable para recibir el retorno del metodo
            var imgToByte = SubirArchivo.imgToByte(pictureBox.Image);
            //Hacer instancia
            ConexionBD conexion = new ConexionBD();
                    //Hacer la insercion con el metodo .insert de linq2bd
               conexion.Insert(new Productos
               {
                   IdProducto = int.Parse(ListaBotonesText[0].Text),
                   NombreProducto = ListaBotonesText[1].Text,
                   DescripcionProducto = ListaBotonesText[2].Text,
                   Categoria = ListaCombos[0].SelectedItem.ToString(),
                   Proveedor = ListaCombos[1].SelectedItem.ToString(),
                   Cantidad = (int)ListaNumeros[0].Value,
                   Imagen = imgToByte
                   });
               MessageBox.Show("Inserción exitosa");
            }

        public void Editar()
        {
            ConexionBD conexion = new ConexionBD();
            var imgToByte = SubirArchivo.imgToByte(pictureBox.Image);

            //Recuperar el id de los registros de la tabla 
            var IdProducto = conexion.GetTable<Productos>()
                .FirstOrDefault(e => e.IdProducto == _id);

            //Hacemos una verificacion para corroborar si el id del producto es valido para la edicion
            if (_id != int.Parse(ListaBotonesText[0].Text))
            {
                MessageBox.Show("El ID del producto no es válido para la edición");
                return;
            }

            conexion.Update(new Productos
            {
                IdProducto = int.Parse(ListaBotonesText[0].Text),
                NombreProducto = ListaBotonesText[1].Text,
                DescripcionProducto = ListaBotonesText[2].Text,
                Categoria = ListaCombos[0].SelectedItem.ToString(),
                Proveedor = ListaCombos[1].SelectedItem.ToString(),
                Cantidad = (int)ListaNumeros[0].Value,
                Imagen = imgToByte
            });
            MessageBox.Show("Actualización exitosa");
            ListarProductos();
        }

        public void Eliminar()
        {
            //Instanciar a la clase de la conexion
            ConexionBD conexion = new ConexionBD();
            //Recuperar los registros de la tabla 
            var ProductoaBorrar = conexion.GetTable<Productos>()
                .FirstOrDefault(e => e.IdProducto == _id);
            //Evaluar
            if (ProductoaBorrar != null)
            {
                //Le vamos a pedir al usuario que confirme la eliminacion
                if (MessageBox.Show("Realmente deseas eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conexion.Delete(ProductoaBorrar);
                    MessageBox.Show("Registro eliminado de manera exitosa");
                    ListarProductos();
                    LimpiarCampos();
                }
            }
        }

        public void BuscarProductoID(int idEstudiante)
        {
            //Hacer la instancia de la conexion
            ConexionBD conexion = new ConexionBD();

            //Declarar la variable que recoge el resultado de la busqueda
            var estudiante = conexion.GetTable<Productos>()
            .FirstOrDefault(e => e.IdProducto == idEstudiante);

            //Validacion
            if (estudiante != null)
            {
                //inicilizar las variables con los datos del estudiante encontrado
                _id = estudiante.IdProducto;

                var Filtro = conexion.GetTable<Productos>()
                    .Where(e => e.IdProducto == idEstudiante)
                    .Select(e => new
                    {
                        e.IdProducto,
                        e.NombreProducto,
                        e.DescripcionProducto,
                        e.Categoria,
                        e.Proveedor,
                        e.Cantidad,
                        e.Imagen
                    }).ToList();
                this.grindView.DataSource = Filtro;

            }
            else
            {
                MessageBox.Show("No se encontraron registros con esa id: " + idEstudiante);
            }
        }

        public void BuscarProductoNombre(string Nombre)
        {
            //Instanciar la conexion
            ConexionBD conexion = new ConexionBD();

            //Haremos la busqueda
            var Producto = conexion.GetTable<Productos>()
                .Where(e => e.NombreProducto.Contains(Nombre))
                .Select(e => new
                {
                    e.IdProducto,
                    e.NombreProducto,
                    e.DescripcionProducto,
                    e.Categoria,
                    e.Proveedor,
                    e.Cantidad,
                    e.Imagen
                }).ToList();
            //Asignar al grindview
            this.grindView.DataSource = Producto;

            //validacion
            if (Producto.Count == 0)
            {
                MessageBox.Show("No se encontro registro con el nombre: " + Nombre);
            }
        }
    }
}
