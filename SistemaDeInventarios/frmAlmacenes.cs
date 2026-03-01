using Logica.Bibloteca.Validar_Forms;
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
    public partial class frmAlmacenes : Form
    {
        VF_Almacen Validacion;
        public frmAlmacenes()
        {
           
           
            InitializeComponent();
            List<TextBox> list = new List<TextBox>();
            list.Add(txtIdAlmacen);
            list.Add(txtNombreAlmacen);
            list.Add(txtResponsableAlmacen);
            list.Add(txtTelefonoAlmacen);
            list.Add(txtUbicacionAlmacen);
            List<Label> listaLabel = new List<Label>();
            listaLabel.Add(lbl_IdAlmacen);
            listaLabel.Add(lblNombreAlmacen);
            listaLabel.Add(lblResponsableAlmacen);
            listaLabel.Add(lblTelefonoAlmacen);
            listaLabel.Add(lblUbicacionAlmacen);

            Validacion = new VF_Almacen(list, listaLabel);
        }
        //Retroalimentar al usuario, para que sepa que dejo algun campo vacio
        #region Eventos lbl
        private void txtUbicacionAlmacen_TextChanged(object sender, EventArgs e)
        {
            if (txtUbicacionAlmacen.Text.Equals(""))
            {
                lblUbicacionAlmacen.ForeColor = Color.Red;
            }
            else
            {
                lblUbicacionAlmacen.ForeColor = Color.Green;
            }
        }
        private void txtIdAlmacen_TextChanged(object sender, EventArgs e)
        {
            if (txtIdAlmacen.Text.Equals(""))
            {
                lbl_IdAlmacen.ForeColor = Color.Red;
            }
            else
            {
                lbl_IdAlmacen.ForeColor = Color.Green;
            }
        }
        private void txtTelefonoAlmacen_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefonoAlmacen.Text.Equals(""))
            {
                lblTelefonoAlmacen.ForeColor = Color.Red;
            }
            else
            {
                lblTelefonoAlmacen.ForeColor = Color.Green;
            }
        }
        private void txtNombreAlmacen_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreAlmacen.Text.Equals(""))
            {
                lblNombreAlmacen.ForeColor = Color.Red;
            }
            else
            {
                lblNombreAlmacen.ForeColor = Color.Green;
            }
        }
        public void txtResponsableAlmacen_TextChanged(object sender, EventArgs e)
        {
            if (txtResponsableAlmacen.Text.Equals(""))
            {
                lblResponsableAlmacen.ForeColor = Color.Red;
            }
            else
            {
                lblResponsableAlmacen.ForeColor = Color.Green;
            }
        }

        #endregion
        //Validar caracteres de registro en textbox
        #region Eventos Keypress
        private void txtIdAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtTelefonoAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Celular(e);
        }

        private void txtNombreAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetrasNumeros(e);
        }

        private void txtUbicacionAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Direccion(e);
        }

        private void txtResponsableAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Validacion.ValidarCampos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Validacion.ValidarCampos();
        }
    }
}

