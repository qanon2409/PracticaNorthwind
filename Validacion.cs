using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaNorthwind
{
    class Validacion
    {
        public static void SoloLetras(KeyPressEventArgs V)
        {
            if(Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }

            else
            {
                V.Handled = true;
                MessageBox.Show("Solo letras");

            }

        }

        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }

            else if(Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }

            else if(Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }

            else
            {
                V.Handled = true;
                MessageBox.Show("Solo numeros");
            }
        }

        public static void NumberDecimal(KeyPressEventArgs V)
        {
            if(Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }

            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }


            else if (V.KeyChar.ToString().Equals("."))
            {
                V.Handled = false;
            }

            else
            {
                V.Handled = true;
                MessageBox.Show("Solo numeros decimales");
            }
        }

        public static void PhoneNum(KeyPressEventArgs V)
        {
            if (!Char.IsDigit(V.KeyChar) && !Char.IsControl(V.KeyChar))
            {
                V.Handled = true;
                MessageBox.Show("Un numero telefonico no debe contener letras");
            }

            //else if (V.KeyChar.ToString().Length == 10)
            //{
            //    V.Handled = false;
            //}

            //else
            //{
            //    V.Handled = true;
            //    MessageBox.Show("Un numero telefonico no debe contener mas de 10 digitos");

            //}
            //else if (V.KeyChar.ToString().Length < 10)
            //{
            //    V.Handled = true;
            //    MessageBox.Show("Un numero telefonico no debe contener mas de 10 digitos");

            //}

            //else if (V.KeyChar.ToString().Length > 10)
            //{
            //    V.Handled = true;
            //    MessageBox.Show("Un numero telefonico no debe contener mas de 10 digitos");

            //}

        }

        public static void HomePage(KeyPressEventArgs V)
        {
            
            
            //if (V.KeyChar.ToString().Equals("www.") && V.KeyChar.ToString().Equals(".com"))
            //{
            //    V.Handled = false;
            //}

            //else
            //{
            //    V.Handled = true;
            //    MessageBox.Show("Abc");
            //}
        }

       
}
}
