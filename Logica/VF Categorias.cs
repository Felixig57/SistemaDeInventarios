using Datos;
using Datos.Entidades.Categorias;
using Datos.Entidades.Productos;
using LinqToDB;
using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class VF_Categorias : Entradas
    {
        DataGridView gridView;

        //Variables bandera
        int _idCat = 0;
        string _accion = "Insert";

        private List<TextBox> Lista = new List<TextBox>(); //Creamos el objeto Lista de tipo List para contener elementos tipo textbox
        private List<Label> listaLabel = new List<Label>();//Creamos el objeto listaLabel de tipo  List para contener elementos tipo Label
        private CategoriasRepository repository = new CategoriasRepository(); //Objeto para utilizar metodos
        public VF_Categorias(List<TextBox> Lista, List<Label> listaLabel, object[] objects) //En el contructor asignamos los parametros a las variables
        {
            this.Lista = Lista;
            this.listaLabel = listaLabel;
            this.gridView = (DataGridView)objects[0];
        }

        public void ValidarCampos() //este es un metodo booleano que validará que el texto de los textboxs no estén vacíos
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede quedar vacío");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
            }

            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("Nombre vacío");
                listaLabel[1].ForeColor = Color.Red;
                Lista[1].Focus();
            }

            else if (Lista[2].Text == string.Empty)
            {
                MessageBox.Show("Descripción vacía");
                listaLabel[2].ForeColor = Color.Red;
                Lista[2].Focus();
            }
            else
            {
                switch (_accion)
                {
                    case "Insert":
                        guardarCat();
                        break;

                    case "Update":
                        editarCat();
                        break;
                }
            }
        }


        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            for (int i = 0; i <3; i++)
            {
                Lista[i].Text = "";

                _accion = "Insert";
            }
            RestablecerLbls();
        }

        //Metodo para restablecer labels
        private void RestablecerLbls()
        {
            listaLabel[0].ForeColor = Color.Black;
            listaLabel[1].ForeColor = Color.Black;
            listaLabel[2].ForeColor = Color.Black;
        }

        //Metodo que utilizaremos para consumir en el boton
        public List<Categorias> Enlistar()
        { 
            return repository.Enlistar();
        }

        public void listarCategoria() 
        {
            //Instancia conexion 
            ConexionBD conexion = new ConexionBD();
            //Variable tipo padre
            var lista = conexion.GetTable<Categorias>().Select(e => new
            {
                //Accedemos a las propiedades
                e.IdCategoria,
                e.NombreCategoria,
                e.DescripcionCategoria
            }).ToList();
            
            this.gridView.DataSource = lista;

        }

        public void getCategoria()
        {
            _accion = "Update";
            //Asignarle valor a la variable de id
            _idCat = Convert.ToInt32(gridView.CurrentRow.Cells[0].Value);

            //Asignar el contenido desde el DGV, hacia las cajas de texto
            Lista[0].Text = gridView.CurrentRow.Cells[0].Value.ToString();
            Lista[1].Text = gridView.CurrentRow.Cells[1].Value.ToString();
            Lista[2].Text = gridView.CurrentRow.Cells[2].Value.ToString();
        }

        public void guardarCat()
        {
            //Instanciar
            ConexionBD conexion = new ConexionBD();
            //Insercion de un metodo Linq2bd
            conexion.Insert(new Categorias
            {
                IdCategoria = int.Parse(Lista[0].Text),
                NombreCategoria = Lista[1].Text,
                DescripcionCategoria = Lista[2].Text,
             });
            MessageBox.Show("Insercion Exitosa");
            listarCategoria();
            LimpiarCampos();
        }

        public void editarCat()
        {
            ConexionBD conexion = new ConexionBD();

            //Recuperar el id de los registros de la tabla 
            var idCat = conexion.GetTable<Categorias>()
                .FirstOrDefault(e => e.IdCategoria == _idCat);

            //Hacemos una verificacion para corroborar si el id del producto es valido para la edicion
            if (_idCat != int.Parse(Lista[0].Text))
            {
                MessageBox.Show("El ID de la categoria no es válido para la edición");
                return;
            }

            conexion.Update(new Categorias
            {
                IdCategoria = int.Parse(Lista[0].Text),
                NombreCategoria = Lista[1].Text,
                DescripcionCategoria = Lista[2].Text,
            });
            MessageBox.Show("Actualización exitosa");
            listarCategoria();
        }
        public void eliminarRegistroCat()
        {
            //Instanciar
            ConexionBD conexion = new ConexionBD();

            //Declarara la variable que nos permita almacenar el registra que eliminaremos
            var registroEliminar = conexion.GetTable<Categorias>().
                FirstOrDefault(e => e.IdCategoria == _idCat);

            if (registroEliminar != null)
            {
                if (MessageBox.Show("Realmente deseas eliminar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //INstanciar
                    Categorias categorias = new Categorias
                    {
                        IdCategoria = int.Parse(Lista[0].Text),
                        NombreCategoria = Lista[1].Text,
                        DescripcionCategoria = Lista[2].Text,
                    };
                    //Aplicamos la eliminacion
                    conexion.Delete(categorias);
                    MessageBox.Show("Registro eliminado de manera exitosa");
                    listarCategoria();
                }
            }
        }

        public void BuscarProductoCat(int idcategoria)
        {
            //Hacer la instancia de la conexion
            ConexionBD conexion = new ConexionBD();

            //Declarar la variable que recoge el resultado de la busqueda
            var categoria = conexion.GetTable<Categorias>()
            .FirstOrDefault(e => e.IdCategoria == idcategoria);

            //Validacion
            if (categoria != null)
            {
                //inicilizar las variables con los datos del estudiante encontrado
                _idCat = categoria.IdCategoria;

                var Filtro = conexion.GetTable<Categorias>()
                    .Where(e => e.IdCategoria == idcategoria)
                    .Select(e => new
                    {
                        e.IdCategoria,
                        e.NombreCategoria,
                        e.DescripcionCategoria
                    }).ToList();
                this.gridView.DataSource = Filtro;

            }
            else
            {
                MessageBox.Show("No se encontraron registros con esa id: " + idcategoria);
            }
        }

        public void BuscarCatNombre(string Nombre)
        {
            //Instanciar la conexion
            ConexionBD conexion = new ConexionBD();

            //Haremos la busqueda
            var categoria = conexion.GetTable<Categorias>()
                .Where(e => e.NombreCategoria.Contains(Nombre))
                .Select(e => new
                {
                    e.IdCategoria,
                    e.NombreCategoria,
                    e.DescripcionCategoria
                }).ToList();
            //Asignar al grindview
            this.gridView.DataSource = categoria;

            //validacion
            if (categoria.Count == 0)
            {
                MessageBox.Show("No se encontro registro con el nombre: " + Nombre);
            }
        }
    }
}

