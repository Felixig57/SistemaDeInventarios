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
    public partial class frmProductos : Form
    {
        MetodosCRUD metodos = new MetodosCRUD();
        VF_Productos validar;
        public frmProductos()
        {
          

            InitializeComponent();
            // Lista de TextBox
            List<TextBox> listaText = new List<TextBox>();
            listaText.Add(txtIdProducto);   // Índice 0
            listaText.Add(txtNombreProducto); // Índice 1
            listaText.Add(txtDescripcionProducto);  // Índice 2

            // Lista de ComboBox
            List<ComboBox> listaCombo = new List<ComboBox>();
            listaCombo.Add(cmbCategoria);    // Índice 0
            listaCombo.Add(cmbProveedor);    // Índice 1

            // Lista de NumericUpDown
            List<NumericUpDown> listaNum = new List<NumericUpDown>();
            listaNum.Add(nudCantidad);      // Índice 0

            //Lista de Labels
            List<Label> listaLabel = new List<Label>();
            listaLabel.Add(lbl_IdProducto);  // Índice 0
            listaLabel.Add(lblNombreProducto);      // Índice 1
            listaLabel.Add(lblDescripcionProducto); // Índice 2 
            listaLabel.Add(lblCategoriaProducto);   // Índice 3
            listaLabel.Add(lblProveedorProducto);   // Índice 4
            listaLabel.Add(lblCantidadProducto);    // Índice 5

            // Le mandamos todo a la clase
            validar = new VF_Productos(listaText, listaCombo, listaNum, listaLabel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar.Validacion();
        }
        //Aqui agregen los otros eventos del combobox y numeric up down
        #region Eventos lbl
        private void lblNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtNombreProducto.Text == string.Empty)
            {
                lblNombreProducto.ForeColor = Color.Red;
            }
            else
            {
                lblNombreProducto.ForeColor = Color.Green;
            }
        }
        private void lblIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == string.Empty)
            {
                lbl_IdProducto.ForeColor = Color.Red;
            }
            else
            {
                lbl_IdProducto.ForeColor = Color.Green;
            }
        }
        private void lblDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcionProducto.Text == string.Empty)
            {
                lblDescripcionProducto.ForeColor = Color.Red;
            }
            else
            {
                lblDescripcionProducto.ForeColor = Color.Green;
            }
        }
        #endregion

        private void txtId_KetPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //metodos.InsertarProducto(txtNombreProducto.Text, txtDescripcionProducto.Text, cmbCategoria.Text, cmbProveedor.Text, (int)nudCantidad.Value);
            if (validar.Validacion()) //Llamada al metodo validacion de campos
            {
                int id; //Variable auxiliar para asignar valor numero al txtId
                
                if (!int.TryParse(txtIdProducto.Text, out id)) //Si es diferente a un numero mandar alerta
                {
                    MessageBox.Show("El ID debe ser numerico");
                    txtIdProducto.Focus();
                    return;
                }
                
                metodos.InsertarProducto(
                    id,
                    txtNombreProducto.Text,
                    txtDescripcionProducto.Text,
                    cmbCategoria.Text,
                    cmbProveedor.Text,
                    (int)nudCantidad.Value
                ); //Metodo con la carga de todos los campos de texto

                CargarProductos();
                LimpiarCampos();
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1)
            {
                lblCategoriaProducto.ForeColor = Color.Red;
            }
            else
            {
                lblCategoriaProducto.ForeColor = Color.Green;
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex == -1)
            {

                lblProveedorProducto.ForeColor= Color.Red;
            }
            else
            {
                lblProveedorProducto.ForeColor=Color.Green;
            }
        
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if(nudCantidad.Value <= 0)
            {
                lblCantidadProducto.ForeColor= Color.Red;
            }
            else
            {
                lblCantidadProducto.ForeColor = Color.Green;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //metodos.ActualizarProducto(int.Parse(txtIdProducto.Text), txtNombreProducto.Text, txtDescripcionProducto.Text, cmbCategoria.Text, cmbProveedor.Text, (int)nudCantidad.Value);
            if (!ValidarSeleccionBotones.ValidarSeleccion(txtIdProducto.Text))
                return;
            if (validar.Validacion())
            {
                int id;
                if (!int.TryParse(txtIdProducto.Text, out id)) //Si el Id no coincide con el ingresado regresara un msj de error
                {
                    MessageBox.Show("Seleccione un registro valido");
                    return;
                }

                metodos.ActualizarProducto( //llamamos al metodo y metemos los cambios dentro de las debidas textbox
                    id,
                    txtNombreProducto.Text,
                    txtDescripcionProducto.Text,
                    cmbCategoria.Text,
                    cmbProveedor.Text,
                    (int)nudCantidad.Value
                    );

                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccionBotones.ValidarSeleccion(txtIdProducto.Text))
                return;
            int id;
            if (!int.TryParse(txtIdProducto.Text, out id))
            {
                MessageBox.Show("Seleccione un registro valido");
                return;
            }

            //Confirmacion dinamica con el MessBox
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar este Producto?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) //Si se selecciona si se ejecuta
            {
                metodos.EliminarProducto(id); //El metodo eliminar en la BD que espera el id
                CargarProductos(); //Actualiza el DGV
                LimpiarCampos(); //Se limpian Campos
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// si el evento en el indice mayor igual a 0 hacer una seleccion
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];//objeto del formulario que obtiene los indices en la variable fila
                txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();//los datos que carga en indice [0]
                txtNombreProducto.Text = fila.Cells["NombreProducto"].Value.ToString();//los datos que carga en indice [1]
                txtDescripcionProducto.Text = fila.Cells["DescripcionProducto"].Value.ToString();//los datos que carga en indice [2]
                cmbCategoria.Text = fila.Cells["Categoria"].Value.ToString();//los datos que carga en indice [3]
                cmbProveedor.Text = fila.Cells["Proveedor"].Value.ToString();//los datos que carga en indice [4]
                nudCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
            }
        }

        #region Funciones Privadas
        private void CargarProductos()
        {
            dgvProductos.DataSource = metodos.MostrarProductos();
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            cmbCategoria.Items.Clear();
            cmbProveedor.Items.Clear();
            nudCantidad.Value = 0;
            //volver con los labels en negro y no se pinten en rojo
            RestablecerLabels();
        }

        private void RestablecerLabels()
        {
            lbl_IdProducto.ForeColor = Color.Black;
            lblNombreProducto.ForeColor = Color.Black;
            lblDescripcionProducto.ForeColor = Color.Black;
            lblCategoriaProducto.ForeColor = Color.Black;
            lblProveedorProducto.ForeColor = Color.Black;
            lblCantidadProducto.ForeColor = Color.Black;   
        }
        #endregion

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }

}
