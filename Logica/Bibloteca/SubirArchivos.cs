using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Bibloteca
{
    public class SubirArchivos
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public void cargar_Fotografia(PictureBox pictureBox)
        {
            //Verificamos la carga de la imagen
            pictureBox.WaitOnLoad = true;
            //Verificamos el Formato de imagen 
            openFileDialog.Filter = "Formato|*.jpg; *.gif; *.bmp";
            //Mostramos la ventana de dialogo
            openFileDialog.ShowDialog();

            //Hacemos una validacion
            if (openFileDialog.FileName != string.Empty)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }

        //Crear un metodo publico que transforme de img a byte

        public byte[] imgToByte(Image imagen)
        {
            //Instancia de clase
            var converter = new ImageConverter();

            //colocamos un retorno
            return (byte[])converter.ConvertTo(imagen, typeof(byte[]));
        }
    }
}
