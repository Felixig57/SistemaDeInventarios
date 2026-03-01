using Logica;
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
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            validar.ValidarCampos();
        }
    }
}
