using Datos;
using Datos.Entidades.Almacenes;
using Datos.Entidades.Proveedores;
using LinqToDB;
using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class VF_Proveedores : Entradas //esta clase hereda de la clase Entradas para poder usar sus validaciones
    {
        private ProveedoresRepository PR = new ProveedoresRepository();
        private List<TextBox> Lista = new List<TextBox>(); //se crean los objetos que necesitaremos
        private List<Label> listaLabel = new List<Label>();
        private int IDProveedor;
        private DataGridView gridView;
        public VF_Proveedores(List<TextBox> Lista, List<Label> listaLabel, Object[] dgv) //en el contructor asignamos los argumentos que pedimos y los asignamos a las variables locales
        {
            this.Lista = Lista;
            this.listaLabel = listaLabel;
            this.gridView = (DataGridView)dgv[0];
        }
        public bool ValidarCampos() //programamos esta funcion booleana que valida si los campos están vacíos
        {
            // 0 = ID
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
                return false;
            }
            // 1 = Nombre
            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                listaLabel[1].ForeColor = Color.Red;
                Lista[1].Focus();
                return false;
            }
            // 2 = Telefono
            else if (Lista[2].Text == string.Empty)
            {
                MessageBox.Show("El campo Telefono no puede estar vacio");
                listaLabel[2].ForeColor = Color.Red;
                Lista[2].Focus();
                return false;
            }
            // 3 = Correo
            else if (Lista[3].Text == string.Empty)
            {
                MessageBox.Show("El campo Correo no puede estar vacio");
                listaLabel[3].ForeColor = Color.Red;
                Lista[3].Focus();
                return false;
            }
            // 4 = Direccion
            else if (Lista[4].Text == string.Empty)
            {
                MessageBox.Show("El campo Direccion no puede estar vacio");
                listaLabel[4].ForeColor = Color.Red;
                Lista[4].Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GuardarenBD()
        {
            ConexionBD conex = new ConexionBD();
            conex.Insert(new Proveedores
            {
                IdProveedor = int.Parse(Lista[0].Text),
                NombreProveedor = Lista[1].Text,
                TelefonoProveedor = Lista[2].Text,
                CorreoProveedor = Lista[3].Text,
                DireccionProveedor = Lista[4].Text
            });
            MessageBox.Show("Se ha guardado el proveedor correctamente en la Base de Datos");

        }
        public void Guardar()
        {
            if (ValidarCampos())
            {
                GuardarenBD();
                LimpiarCampos();

            }

        }
        //Metodo para mostrar en DGV
        public List<Proveedores> Mostrardgv()
        {
            return PR.Lista();
        }
        private void LimpiarCampos()
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Lista[i].Clear();
            }
            RestablecerLabels();
        }
        private void RestablecerLabels()
        {
            listaLabel[0].ForeColor = Color.Black;
            listaLabel[1].ForeColor = Color.Black;
            listaLabel[2].ForeColor = Color.Black;
            listaLabel[3].ForeColor = Color.Black;
            listaLabel[4].ForeColor = Color.Black;
        }
        public void Seleccionar()
        {
            //accion = "Update";
            IDProveedor = Convert.ToInt32(gridView.CurrentRow.Cells[0].Value);
            //Asignar los datos que tenemos en la fila a las cajas
            Lista[0].Text = Convert.ToString(gridView.CurrentRow.Cells[0].Value);
            Lista[1].Text = Convert.ToString(gridView.CurrentRow.Cells[1].Value);
            Lista[2].Text = Convert.ToString(gridView.CurrentRow.Cells[2].Value);
            Lista[3].Text = Convert.ToString(gridView.CurrentRow.Cells[3].Value);
            Lista[4].Text = Convert.ToString(gridView.CurrentRow.Cells[4].Value);

        }
        public void Eliminar()
        {

            ConexionBD conexion = new ConexionBD();

            var registroExistente = conexion.GetTable<Proveedores>()
                  .FirstOrDefault(e => e.IdProveedor == IDProveedor);

            if (registroExistente != null)
            {
                if (MessageBox.Show("Este Proveedor sera eliminado.     Estas seguro de querer eliminarlo?",
                    "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Proveedores EstudianteEliminado = new Proveedores
                    {
                        IdProveedor = int.Parse(Lista[0].Text),
                        NombreProveedor = Lista[1].Text,
                        TelefonoProveedor = Lista[2].Text,
                        CorreoProveedor = Lista[3].Text,
                        DireccionProveedor = Lista[4].Text,

                    };
                    conexion.Delete(EstudianteEliminado);
                    MessageBox.Show("Proveedor Eliminado");

                }
            }
        }
        public void Editar()
        {
            ConexionBD conexion = new ConexionBD();
            var registroExistente = conexion.GetTable<Proveedores>()
                  .FirstOrDefault(e => e.IdProveedor == IDProveedor);
            if (registroExistente != null)
            {
                if (MessageBox.Show("Estas seguro de querer editar este proveedor?",
                    "Editar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Proveedores ProveedorEditado = new Proveedores
                    {
                        IdProveedor = int.Parse(Lista[0].Text),
                        NombreProveedor = Lista[1].Text,
                        TelefonoProveedor = Lista[2].Text,
                        CorreoProveedor = Lista[3].Text,
                        DireccionProveedor = Lista[4].Text,
                    };
                    conexion.Update(ProveedorEditado);
                    MessageBox.Show("Proveedor Editado");
                }
            }

        }
    }
}

