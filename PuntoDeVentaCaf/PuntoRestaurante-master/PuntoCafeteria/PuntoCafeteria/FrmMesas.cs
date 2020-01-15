using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoCafeteria.Clases;

namespace PuntoCafeteria
{
   
    public partial class FrmMesas : Form
    {
        Mesas mesa = new Mesas();
        public FrmMesas()
        {
            InitializeComponent();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            Button buton = sender as Button;
            mesa.onclik(buton);
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {

        }
    }
}
