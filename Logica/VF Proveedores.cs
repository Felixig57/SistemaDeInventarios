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
   public class VF_Proveedores : Entradas
        {
            private List<TextBox> Lista = new List<TextBox>();
        private List<Label> listaLabel = new List<Label>();
            public VF_Proveedores(List<TextBox> Lista, List<Label> listaLabel)
            {
                this.Lista = Lista;
            this.listaLabel = listaLabel;
            }
            public void ValidarCampos()
            {
            // 0 = ID
            if (Lista[0].Text == string.Empty)
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                listaLabel[0].ForeColor = Color.Red;
                Lista[0].Focus();
            }
            // 1 = Nombre
            else if (Lista[1].Text == string.Empty)
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                listaLabel[1].ForeColor = Color.Red;
                Lista[1].Focus();
            }
            // 2 telefono
            else if (Lista[2].Text == string.Empty)
            {
                
                MessageBox.Show("El campo Telefono no puede estar vacio");
                listaLabel[2].ForeColor = Color.Red;
                Lista[2].Focus();
            }

            // 3 = correo
            else if (Lista[3].Text == string.Empty)
            {
                MessageBox.Show("El campo Correo no puede estar vacio");
                listaLabel[3].ForeColor = Color.Red;
                Lista[3].Focus();
            }
            // 4 = direccion
            else if (Lista[4].Text == string.Empty)
            {
                MessageBox.Show("El campo Direccion no puede estar vacio");
                listaLabel[4].ForeColor = Color.Red;
                Lista[4].Focus();
            }
            
            // Si pasa todas las validaciones
            else
            {
                MessageBox.Show("Proveedor Agregado Correctamente");

                // Aquí irá el código para guardar el proveedor en la base de datos
            }
        }

        }
    }

