using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PuntoCafeteria.Clases
{
    class textboxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //condicion que solo permite inresar datos tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //condicion tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numberkeypress(KeyPressEventArgs e)
        {
            //condicion que solo permite inresar datos tipo texto
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //condicion tecla backspace
            if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            //tecla espacio
           
        }
        public void numberDecimalkeypress(TextBox textBox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //condicion tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; SendKeys.Send(","); }
            else if ((e.KeyChar == '.') && (!textBox.Text.Contains("."))) {
                SendKeys.Send(",");
                e.Handled= false;
               
            }


            else { e.Handled = true; }

        }
    }
}
