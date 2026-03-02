using Logica.Seguridad;
using SistemaDeInventarios.Navegacion;
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
    public partial class frmLogin : Form
    {
        UsuarioNegocio objUsuarioNegocio = new UsuarioNegocio();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuario = objUsuarioNegocio.ValidarLogin(txtUsuario.Text, txtContrasena.Text);
            if (usuario != null)
            {
                MessageBox.Show("Bienvenido "+usuario.rolUsuario);
                GestorNavegacion.AbrirYOCultarMenu<frmMenu>(this);
                LimpiarCampos();
                textBox1_Enter(txtUsuario, e);
                textBox1_Leave(txtUsuario, e);
                textBox2_Enter(txtUsuario, e);
                textBox2_Leave(txtUsuario, e);

            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrectos");
            }
        }
        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Gray;
            }
        }
    }
}
