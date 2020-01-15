using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace PuntoCafeteria.Clases
{
    class Mesas
    {
        public void onclik(Button boton)
        {
            if (boton.BackColor == Color.Lime)
            {
                boton.BackColor = Color.Red;
            }  
            else
            {
                boton.BackColor = Color.Lime;
            }
        }
    }
}

