using Datos;
using Datos.Entidades;
using Datos.Entidades.Almacenes;
using LinqToDB;
using Logica.Bibloteca.Validar_entrada_de_datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Bibloteca.Validar_Forms
{
    public class VF_Almacen : Entradas
    {
        private AlmacenesRepository repo = new AlmacenesRepository();//Objeto que nos permite usar los metodos que tenemos 
        private List<TextBox> Lista = new List<TextBox>();//Creamos el objeto Lista de tipo List para contener elementos tipo textbox
        private List<Label> listaLabel = new List<Label>();//Creamos el objeto listaLabel de tipo List para contener elementos tipo label
        public VF_Almacen(List<TextBox> Lista, List<Label> listaLabel) //En el contructor asignamos los parametros a las variables
        {
            this.Lista = Lista;
            this.listaLabel = listaLabel;
        }
        
        public bool ValidarCampos() //este es un metodo booleano que validará que el texto de los textboxs no estén vacíos
        {
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
                return false;
            }
            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                listaLabel[1].ForeColor = Color.Red;
                Lista[1].Focus();
                return false;
            }
            else if (Lista[2].Text == string.Empty)
            {
                MessageBox.Show("El campo Responsable no puede estar vacio");
                listaLabel[2].ForeColor = Color.Red;
                Lista[2].Focus();
                return false;
            }
            else if (Lista[3].Text == string.Empty)
            {
                MessageBox.Show("El campo Telefono no puede estar vacio");
                listaLabel[3].ForeColor = Color.Red;
                Lista[3].Focus();
                return false;
            }
            else if (Lista[4].Text == string.Empty)
            {
                MessageBox.Show("El campo Ubicacion no puede estar vacio");
                listaLabel[4].ForeColor = Color.Red;
                Lista[4].Focus();
                return false;
            }

            return true; //todo correcto
        }

        //crear metodo que que instancie el objeto para el guardado del estudiantes
        public void GuardarAlmacen()
        {
            //instancia de la conexion
            ConexionBD conexion = new ConexionBD();
                //metod insert de Linq
                    conexion.Insert(new Almacenes
                    {
                        //pasamos el texto de la listas
                        IdAlmacen = int.Parse(Lista[0].Text),
                        NombreAlmacen = Lista[1].Text,
                        ResponsableAlmacen = Lista[2].Text,
                        TelefonoAlmacen = Lista[3].Text,
                        UbicacionAlmacen = Lista[4].Text,
                    });
            
            //mensaje de registro exitoso
            MessageBox.Show("Almacen Registrado...");

        }
        //metodo guardar para la validacion correcta de los campos de texto
        public void Guardar()
        {
            if (!ValidarCampos()) return;//comprobacion de la validacion que se cumple y nos returna a los siguientes metodos
            GuardarAlmacen();//metodo que hace el insert
            LimpiarCampos();//limpar los campos que dentro tiene el restablecimineto de los labels
           
        }
        private void LimpiarCampos()
        {
            Lista[0].Clear();
            Lista[1].Clear();
            Lista[2].Clear();
            Lista[3].Clear();
            Lista[4].Clear();
            RestablecerLabels();
        }
        //para los labels va ir en cada uno
        private void RestablecerLabels()
        {
            listaLabel[0].ForeColor = Color.Black;
            listaLabel[1].ForeColor = Color.Black;
            listaLabel[2].ForeColor = Color.Black;
            listaLabel[3].ForeColor = Color.Black;
            listaLabel[4].ForeColor = Color.Black;
        }

        //este metodo es el que vamos a consumir desde el boton
        public List<Almacenes> Listar()
        {
            return repo.Listar();
        }


    }
}