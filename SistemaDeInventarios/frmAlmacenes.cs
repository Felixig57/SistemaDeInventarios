using Datos;
using Logica.Bibloteca.Validar_Forms;
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
    public partial class frmAlmacenes : Form
    {
        MetodosCRUD metodos = new MetodosCRUD();
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
            //metodos.InsertarAlmacen(txtNombreAlmacen.Text, txtResponsableAlmacen.Text, txtTelefonoAlmacen.Text, txtUbicacionAlmacen.Text);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //metodo privado que viene con la carga de los almacenes
        private void CargarAlmacenes()
        {
            dgvAlmacenes.DataSource = metodos.MostrarAlmacenes();//
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (Validacion.ValidarCampos())//llamar al metod validacion de los campos
            {
                int id;//variable que nos auxilia para asignar el valor numero en el txt id

                if (!int.TryParse(txtIdAlmacen.Text, out id))// si el es diferente de un numero mandar alerta
                {
                    MessageBox.Show("El ID debe ser numérico");
                    txtIdAlmacen.Focus();
                    return;
                }

                metodos.InsertarAlmacen(
                    id,
                    txtNombreAlmacen.Text,
                    txtResponsableAlmacen.Text,
                    txtTelefonoAlmacen.Text,
                    txtUbicacionAlmacen.Text
                );//metodo con la carga de todos los campos de texto

                CargarAlmacenes(); // refresca el dgv despues de anadir un registro en la bd
                LimpiarCampos(); //limpia campos
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //validacion que proviene desde la clase validacion seleccion para validar la selccion al momento de editar
            if (!ValidarSeleccionBotones.ValidarSeleccion(txtIdAlmacen.Text))
                return;

            if (Validacion.ValidarCampos())
            {
                int id;

                if (!int.TryParse(txtIdAlmacen.Text, out id))
                {
                    MessageBox.Show("Seleccione un registro válido");
                    return;
                }

                metodos.ActualizarAlmacen(
                    id,
                    txtNombreAlmacen.Text,
                    txtResponsableAlmacen.Text,
                    txtTelefonoAlmacen.Text,
                    txtUbicacionAlmacen.Text
                );

                CargarAlmacenes();
                LimpiarCampos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccionBotones.ValidarSeleccion(txtIdAlmacen.Text))
                return;

            int id;

            if (!int.TryParse(txtIdAlmacen.Text, out id))
            {
                MessageBox.Show("Seleccione un registro válido.");
                return;
            }

            // Confirmación dinamica con el MessBox
            DialogResult resultado = MessageBox.Show( "¿Está seguro que desea eliminar este almacen?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)// si se selcciona si se ejcuta
            {
                metodos.EliminarAlmacen(id); //el metodo eliminar en la bd que espera el id
                CargarAlmacenes();// y se actualiza el dgv
                LimpiarCampos();// y se limpian campos
            }
        }
        private void LimpiarCampos()
        {
            txtIdAlmacen.Clear();
            txtNombreAlmacen.Clear();
            txtResponsableAlmacen.Clear();
            txtUbicacionAlmacen.Clear();
            txtTelefonoAlmacen.Clear();
            //volver con los labels en negro y no se pinten en rojo
            RestablecerLabels();
        }
        private void frmAlmacenes_Load(object sender, EventArgs e)
        {
            CargarAlmacenes();//este metodo Carga los Almacenes al momento de abrir el formulario
        }

        //evento que carga la fila en los campos de texto 
        private void dgvAlmacenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)// si el evento en el indice mayor igual a 0 hacer una seleccion
            {
                DataGridViewRow fila = dgvAlmacenes.Rows[e.RowIndex];//objeto del formulario que obitiene los indices en la variable fila

                txtIdAlmacen.Text = fila.Cells["IdAlmacen"].Value.ToString();//los datos que carga en indice [0]
                txtNombreAlmacen.Text = fila.Cells["NombreAlmacen"].Value.ToString();//los datos que carga en indice [1]
                txtResponsableAlmacen.Text = fila.Cells["ResponsableAlmacen"].Value.ToString();//los datos que carga en indice [2]
                txtTelefonoAlmacen.Text = fila.Cells["TelefonoAlmacen"].Value.ToString();//los datos que carga en indice [3]
                txtUbicacionAlmacen.Text = fila.Cells["UbicacionAlmacen"].Value.ToString();//los datos que carga en indice [4]
            }
        }
        private void RestablecerLabels()
        {
            lbl_IdAlmacen.ForeColor = Color.Black;
            lblNombreAlmacen.ForeColor = Color.Black;
            lblResponsableAlmacen.ForeColor = Color.Black;
            lblTelefonoAlmacen.ForeColor = Color.Black;
            lblUbicacionAlmacen.ForeColor = Color.Black;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

