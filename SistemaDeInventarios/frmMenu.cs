using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using SistemaDeInventarios.Navegacion;

namespace SistemaDeInventarios
{
    public partial class frmMenu : Form
    {
        ConexiónBD conexionBD = new ConexiónBD();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btn categorias
            GestorNavegacion.AbrirYOCultarMenu<frmCategorias>(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn productos
            GestorNavegacion.AbrirYOCultarMenu<frmProductos>(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //btn proveedores
            GestorNavegacion.AbrirYOCultarMenu<frmProveedores>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //btn Almacenes
            GestorNavegacion.AbrirYOCultarMenu<frmAlmacenes>(this);
            
        }

<<<<<<< HEAD
        #region funciones privada
        private void NavegacionProductos()
        {
            this.Hide();
            frmProductos frmProductos = new frmProductos(); 
            frmProductos.ShowDialog();
            
            
        }
        #endregion


=======
        private void button4_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
        }
>>>>>>> f10ff7a (Reapply "Reapply "Hora del vladimir"")
    }
}
