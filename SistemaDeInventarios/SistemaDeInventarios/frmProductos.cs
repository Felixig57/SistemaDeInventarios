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

        VF_Productos LogicaProductos;
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

            //Crear un arreglo que contenga los objetos
            Object[] objects = { dgvProductos, PictureBox };

            // Le mandamos todo a la clase
            LogicaProductos = new VF_Productos(listaText, listaCombo, listaNum, listaLabel, objects);

            LogicaProductos.ListarProductos();
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
            LogicaProductos.SoloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            LogicaProductos.SoloLetras(e);
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
            //Aquí se mandará a hacer la validacion de los campos
            LogicaProductos.Validacion("Insertar");
            LogicaProductos.ListarProductos();
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
            LogicaProductos.Validacion("actualizar");
            LogicaProductos.ListarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LogicaProductos.Eliminar();
            LogicaProductos.ListarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Funciones Privadas
        private void CargarProductos()
        {
          //  dgvProductos.DataSource = metodos.MostrarProductos();
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
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
            LogicaProductos.ListarProductos();
            LimpiarCampos();
            txtBuscarID.Text = "";
            txtBuscarNombre.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Click(object sender, EventArgs e)
        {
            LogicaProductos.SubirArchivo.cargar_Fotografia(PictureBox);
        }

        private void Celldoubleclick(object sender, DataGridViewCellEventArgs e)
        {
            LogicaProductos.ObtenerSeleccionProductos();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LogicaProductos.ObtenerSeleccionProductos();
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            LogicaProductos.ObtenerSeleccionProductos();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            LogicaProductos.BuscarProductoID(int.Parse(txtBuscarID.Text));
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            LogicaProductos.SoloLetras(e);
        }

        private void KeyPressId(object sender, KeyPressEventArgs e)
        {
            LogicaProductos.SoloNumeros(e);
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            LogicaProductos.BuscarProductoNombre(txtBuscarNombre.Text);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            LogicaProductos.ListarProductos();
        }
    }

}
