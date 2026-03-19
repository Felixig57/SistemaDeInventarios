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
    public partial class frmProveedores : Form
    {
        MetodosCRUD metodos = new MetodosCRUD();
        VF_Proveedores validar;

        public frmProveedores()
        {
            
            InitializeComponent();
            List<TextBox> list = new List<TextBox>();
            list.Add(txtIdProveedor);
            list.Add(txtNombreProveedor);
            list.Add(txtTelefonoProveedor);
            list.Add(txtCorreoProveedor);
            
            list.Add(txtDireccionProveedor);
            
            List<Label> listaLabel = new List<Label>();
            listaLabel.Add(lbl_IdProveedor);
            listaLabel.Add(lblNombreProveedor);
            listaLabel.Add(lblTelefonoProveedor);
            listaLabel.Add(lblCorreoProveedor);
            listaLabel.Add(lblDireccionProveedor);
            validar = new VF_Proveedores(list, listaLabel);
        }
        //Retroaliemntacion al usario para no dejar campos vacios
        #region Eventos lbl
        private void lblIDProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text == string.Empty)
            {
                lbl_IdProveedor.ForeColor = Color.Red;
            }
            else
            {
                lbl_IdProveedor.ForeColor = Color.Green;
            }
        }
        private void lblCorreoProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreoProveedor.Text == string.Empty)
            {
                lblCorreoProveedor.ForeColor = Color.Red;
            }
            else
            {
                lblCorreoProveedor.ForeColor = Color.Green;
            }
        }
        private void lblNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == string.Empty)
            {
                lblNombreProveedor.ForeColor = Color.Red;
            }
            else
            {
                lblNombreProveedor.ForeColor = Color.Green;
            }
        }
        private void lblDireccionProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccionProveedor.Text == string.Empty)
            {
                lblDireccionProveedor.ForeColor = Color.Red;
            }
            else
            {
                lblDireccionProveedor.ForeColor = Color.Green;
            }
        }
          private void lblTelefonoProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefonoProveedor.Text == string.Empty)
            {
                lblTelefonoProveedor.ForeColor = Color.Red;
            }
            else
            {
                lblTelefonoProveedor.ForeColor = Color.Green;
            }
        }
        #endregion   
      
        #region Eventos Keypress
        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Celular(e);
        }
        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }
        private void txtDireccionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Direccion(e);
        }
        private void txtCorreoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Correo(e);
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            validar.ValidarCampos();
            //metodos.InsertarProveedor(txtNombreProveedor.Text, txtCorreoProveedor.Text, txtTelefonoProveedor.Text, txtDireccionProveedor.Text);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
        //borramos codigo para anadir y ajustar a los requerimientos necesarios
        }

        #region Funciones Privadas
        private void CargarProveedores()
        {
           // dgvProveedores.DataSource = metodos.MostrarProveedores();
        }

        private void LimpiarCampos()
        {
            txtIdProveedor.Clear();
            txtNombreProveedor.Clear();
            txtCorreoProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDireccionProveedor.Clear();
            //volver con los labels en negro y no se pinten en rojo
            RestablecerLabels();
        }

        //evento que carga la fila en los campos de texto 
        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// si el evento en el indice mayor igual a 0 hacer una seleccion
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];//objeto del formulario que obtiene los indices en la variable fila
                txtIdProveedor.Text = fila.Cells["IdProveedor"].Value.ToString();//los datos que carga en indice [0]
                txtNombreProveedor.Text = fila.Cells["NombreProveedor"].Value.ToString();//los datos que carga en indice [1]
                txtCorreoProveedor.Text = fila.Cells["CorreoProveedor"].Value.ToString();//los datos que carga en indice [2]
                txtTelefonoProveedor.Text = fila.Cells["TelefonoProveedor"].Value.ToString();//los datos que carga en indice [3]
                txtDireccionProveedor.Text = fila.Cells["DireccionProveedor"].Value.ToString();//los datos que carga en indice [4]
            }
        }
        private void RestablecerLabels()
        {
            lbl_IdProveedor.ForeColor = Color.Black;
            lblNombreProveedor.ForeColor = Color.Black;
            lblCorreoProveedor.ForeColor = Color.Black;
            lblTelefonoProveedor.ForeColor = Color.Black;
            lblDireccionProveedor.ForeColor = Color.Black;
        }
        #endregion
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //borramos codigo para anadir y ajustar a los requerimientos necesarios
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //borramos codigo para anadir y ajustar a los requerimientos necesarios
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmProveedores_Load_1(object sender, EventArgs e)
        {
            //CargarProveedores();//este metodo Carga los Proveedores al momento de abrir el formulario
        }
    }
}
