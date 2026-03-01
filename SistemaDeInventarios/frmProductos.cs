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
    public partial class frmProductos : Form
    {
        VF_Productos validar;
        public frmProductos()
        {
          

            InitializeComponent();
            //No se como se agrege a la lista los combobox y el numeric up down, asi que no se Xd
            List<TextBox> Lista = new List<TextBox>();
            Lista.Add(txtIdProducto);
            Lista.Add(txtNombreProducto);
            validar = new VF_Productos(Lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar.Validacion();
        }
        //Aqui agregen los otros eventos del combobox y numeric up down
        #region Eventos lbl
        private void lblNombre_TextChanged(object sender, EventArgs e)
        {

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
    }
}
