using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Logica.Bibloteca.Validar_entrada_de_datos
{
    public class Entradas //acá programamos todos las validaciónes
    {
        public void SoloLetras(KeyPressEventArgs e)// validacion que solo permite letras, retroceso y espacio en blanco
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
              
                e.Handled = false;
            }
        }
        public void SoloNumeros(KeyPressEventArgs e) //evento que valida que solo se usen numeros, retrocesos y espacios
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
            else
            {
               
                e.Handled = false;
            }
        }
        public void Celular(KeyPressEventArgs e) //evento que calida el formato que especificamos para los numeros celulares
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ' && e.KeyChar != '+' &&
                    e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                MessageBox.Show("Solo se permiten números, guiones, paréntesis y simbolo de suma");
                e.Handled = true;
            }
            else
            {
                
                e.Handled = false;
            }
        }
        public void Direccion(KeyPressEventArgs e) //evento que valida el formato que especificamos para la dirección
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' '
                && e.KeyChar != '-' && e.KeyChar != '#')
            {
                MessageBox.Show("Solo se permiten letras, números, guiones y simbolo de numeral");
                e.Handled = true;
            }
            else
            {
                
                e.Handled = false;
            }
        }
        public void Correo(KeyPressEventArgs e) //evento que valida el formato que especificamos para el correo
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ' && e.KeyChar != '-' &&
                    e.KeyChar != '_' && e.KeyChar != '.' && e.KeyChar != '@')
            {
                MessageBox.Show("Solo se permiten letras, números, guiones, guion bajo, puntos y arroba");
                e.Handled = true;
            }
            else
            {
         
                e.Handled = false;
            }
        }
        public void SoloLetrasNumeros(KeyPressEventArgs e) //evento que valida el formato de solo letras y numeros
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se permiten letras y números");
                e.Handled = true;
            }
            else
            {
       
                e.Handled = false;
            }
        }
    }
   
}
