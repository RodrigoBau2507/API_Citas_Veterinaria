using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2._0.Clases
{
    internal class Validar
    {
        public static void Letras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }

        }

        public static void Numeros(KeyPressEventArgs n)
        {
            if (Char.IsDigit(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (Char.IsSeparator(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (Char.IsControl(n.KeyChar))
            {
                n.Handled = false;
            }
            else
            {
                n.Handled = true;
            }

        }
        public static void NumerosDecimal(KeyPressEventArgs n)
        {
            if (Char.IsDigit(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (Char.IsSeparator(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (Char.IsControl(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (n.KeyChar.ToString().Equals("."))
            {
                n.Handled = true;
            }
        }
    
    }
}
