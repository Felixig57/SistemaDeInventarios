using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Bibloteca.Validar_entrada_de_datos
{
    public class Entradas
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = false;
            }
            else
            {
               
                e.Handled = true;
            }
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = false;
            }
            else
            {
                
                e.Handled = true;
            }
        }
        public void Celular(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ' && e.KeyChar != '+' &&
                    e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                MessageBox.Show("Solo se permiten números, guiones, paréntesis y simbolo de suma");
                e.Handled = false;
            }
            else
            {
                
                e.Handled = true;
            }
        }
        public void Direccion(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' '
                && e.KeyChar != '-' && e.KeyChar != '#')
            {
                MessageBox.Show("Solo se permiten letras, números, espacios, guiones y el símbolo de numeral");
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void Correo(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ' && e.KeyChar != '-' &&
                    e.KeyChar != '_' && e.KeyChar != '.' && e.KeyChar != '@')
            {
                MessageBox.Show("Solo se permiten letras, números, guiones, guiones bajos, puntos y el símbolo de arroba");
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SoloLetrasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se permiten letras y números");
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
   
}
