using Datos;
using Logica;
using SistemaDeInventarios.Botones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios
{
    public partial class frmCategorias : Form 
    {
        MetodosCRUD metodos = new MetodosCRUD(); //Hacemos la instancia de los metodos CRUD
        VF_Categorias Validar; //Creamos un objeto de tipo VF_Categorias que es la clase donde están las funciones de verificación
        public frmCategorias()
        {
     
            InitializeComponent();
            List<TextBox> Lista = new List<TextBox>(); // acá creamos el objeto lista tipo textbox que contendrá los indices de los textbox
            Lista.Add(txtId_Categoria); //0
            Lista.Add(txtNombreCategoria);//1
            Lista.Add(txtDescripcionCategoria);//2

            List<Label> listaLabel = new List<Label>();// acá creamos el objeto lista tipo textbox que contendrá los indices de los labels
            listaLabel.Add(lblId_Categoria); //indice 0
            listaLabel.Add(lblNombreCategoria);//indice 1
            listaLabel.Add(lblDescripcionCategoria);//indice 2
            Validar = new VF_Categorias(Lista, listaLabel); //acá le mandamos los argumentos que asignamos al objeto validar
        }

        private void lblNombre_TextChanged(object sender, EventArgs e) //acá estamos creando el evento que cambia el color de la etiqueta dependiendo de si está vacia
        {
            if(txtNombreCategoria.Text == string.Empty)
            {
                lblNombreCategoria.ForeColor = Color.Red;
            }
            else
            {
               lblNombreCategoria.ForeColor = Color.Green;
            }
        }
        private void lblDescripcion_TextChanged(object sender, EventArgs e) //acá estamos creando el evento que cambia el color de la etiqueta dependiendo de si está vacía
        {
            if (txtDescripcionCategoria.Text == string.Empty)
            {
                lblDescripcionCategoria.ForeColor = Color.Red;
            }
            else
            {
                lblDescripcionCategoria.ForeColor = Color.Green;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)//acá estamos creando el evento que cambia el color de la etiqueta dependiendo de si está vacía
        {
            Validar.SoloLetras(e);
        }
        #region eventos que estorban generados sin codigo adentro
        private void FrmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbTituloC_Enter(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        #endregion

      //metoddo que valida, carga, y manda datos a ala BD
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarCampos()) //Llamada al metodo validacion de campos
            {
                int id; //Variable auxiliar para asignar valor numero al txtId

                if (!int.TryParse(txtId_Categoria.Text, out id)) //Si es diferente a un numero mandae alerta
                {
                    MessageBox.Show("El ID debe ser numerico");
                    txtId_Categoria.Focus();
                    return;
                }

                metodos.InsertarCategoria(
                    id,
                    txtNombreCategoria.Text,
                    txtDescripcionCategoria.Text
                ); //Metodo con la carga de todos los campos de texto

                CargarCategorias();
                LimpiarCampos();
            }
        }

        #region FUNCIONES PRIVADAS
        private void CargarCategorias()
        {
            dgvCategorias.DataSource = metodos.MostrarCategorias();
        }

        private void LimpiarCampos()
        {
            txtId_Categoria.Clear();
            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();
            //volver con los labels en negro y no se pinten en rojo
            RestablecerLabels();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();//este metodo Carga los Proveedores al momento de abrir el formulario
        }

        //evento que carga la fila en los campos de texto 
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// si el evento en el indice mayor igual a 0 hacer una seleccion
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];//objeto del formulario que obtiene los indices en la variable fila
                txtId_Categoria.Text = fila.Cells["IdCategoria"].Value.ToString();//los datos que carga en indice [0]
                txtNombreCategoria.Text = fila.Cells["NombreCategoria"].Value.ToString();//los datos que carga en indice [1]
                txtDescripcionCategoria.Text = fila.Cells["DescripcionCategoria"].Value.ToString();//los datos que carga en indice [2]
            }
        }
        private void RestablecerLabels()
        {
            lblId_Categoria.ForeColor = Color.Black;
            lblNombreCategoria.ForeColor = Color.Black;
            lblDescripcionCategoria.ForeColor = Color.Black;
        }

        #endregion
        private void btnRegresar_Click(object sender, EventArgs e)//botón de regresar
        {
            this.Close();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)//evento de el boton que ayuda a regresar *no necesario*
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //metodos.ActualizarCategoria(int.Parse(txtIdCategoria.Text), txtNombreCategoria.Text, txtDescripcionCategoria.Text);
            if (!ValidarSeleccionBotones.ValidarSeleccion(txtId_Categoria.Text))
                return;
            if (Validar.ValidarCampos())
            {
                int id;
                if (!int.TryParse(txtId_Categoria.Text, out id)) //Si el Id no coincide con el ingresado regresara un msj de error
                {
                    MessageBox.Show("Seleccione un registro valido");
                    return;
                }

                metodos.ActualizarCategoria( //llamamos al metodo y metemos los cambios dentro de las debidas textbox
                    id,
                    txtNombreCategoria.Text,
                    txtDescripcionCategoria.Text
                    );

                CargarCategorias();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //metodos.EliminarCategoria(int.Parse(txtIdCategoria.Text));
            if (!ValidarSeleccionBotones.ValidarSeleccion(txtId_Categoria.Text))
                return;
            int id;
            if (!int.TryParse(txtId_Categoria.Text, out id))
            {
                MessageBox.Show("Seleccione un registro valido");
                return;
            }

            //Confirmacion dinamica con el MessBox
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar esta Categoria?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) //Si se selecciona si se ejecuta
            {
                metodos.EliminarCategoria(id); //El metodo eliminar en la BD que espera el id
                CargarCategorias(); //Actualiza el DGV
                LimpiarCampos(); //Se limpian Campos
            }
        }

        private void txtId_Categoria_TextChanged(object sender, EventArgs e) 
        {
            if(txtId_Categoria.Text == string.Empty)
            {
                lblId_Categoria.ForeColor = Color.Red;
            }
            else
            {
                lblId_Categoria.ForeColor= Color.Green;
            }

        }

        private void txtId_Categoria_KeyPress(object sender, KeyPressEventArgs e) //evento que valida que solo haya numeros
        {
            Validar.SoloNumeros(e);
        }
        
    }
}
