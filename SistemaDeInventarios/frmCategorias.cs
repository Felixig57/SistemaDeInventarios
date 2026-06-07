using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeInventarios
{
    public partial class frmCategorias : Form
    {
        //   MetodosCRUD metodos = new MetodosCRUD(); //Hacemos la instancia de los metodos CRUD
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
            object[] objects = { dgvCategorias };
            Validar = new VF_Categorias(Lista, listaLabel, objects); //acá le mandamos los argumentos que asignamos al objeto validar
           // Validar.listarCategoria();
        }

        #region Eventos lbl
        private void lblNombre_TextChanged(object sender, EventArgs e) //acá estamos creando el evento que cambia el color de la etiqueta dependiendo de si está vacia
        {
            if (txtNombreCategoria.Text == string.Empty)
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
        private void txtId_Categoria_TextChanged(object sender, EventArgs e)
        {
            if (txtId_Categoria.Text == string.Empty)
            {
                lblId_Categoria.ForeColor = Color.Red;
            }
            else
            {
                lblId_Categoria.ForeColor = Color.Green;
            }

        }

        #endregion

        #region Eventos Keypress
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)//acá estamos creando el evento que cambia el color de la etiqueta dependiendo de si está vacía
        {
            Validar.SoloLetras(e);
        }
        private void txtId_Categoria_KeyPress(object sender, KeyPressEventArgs e) //evento que valida que solo haya numeros
        {
            Validar.SoloNumeros(e);
        }
        #endregion

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
            //Borramos aqui
            //Mandamos a llamar al metodo guardar en Logica Categoria
            Validar.ValidarCampos();
            Validar.guardarCat();
            //Llamamos al metodo Cargar categorias
            CargarCategorias();
        }


        #region FUNCIONES PRIVADAS

        //Metodo privado con la carga de categorias
        private void CargarCategorias()
        {
            dgvCategorias.DataSource = Validar.Enlistar();
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
            CargarCategorias();//este metodo Carga los datos guardados de la categoria al momento de abrir el formulario

        }

        //evento que carga la fila en los campos de texto 
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Validar.getCategoria();
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
            Validar.editarCat();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Validar.eliminarRegistroCat();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBuscarClick(object sender, EventArgs e)
        {
           
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Validar.getCategoria();
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            //Validar.getCategoria();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Validar.BuscarProductoCat(int.Parse(txtBuscarId.Text));
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            Validar.BuscarCatNombre(txtBuscarNombreCat.Text);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Validar.listarCategoria(); 
        }
    }
}
