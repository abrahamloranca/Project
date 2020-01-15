using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoCafeteria
{
    public partial class FrmProductosBajos : Form
    {
        Clases.ClassProducto objproducto = new Clases.ClassProducto();
        public FrmProductosBajos()
        {
            InitializeComponent();
        }

        private void FrmProductosBajos_Load(object sender, EventArgs e)
        {
            DataSet recuper = objproducto.Productosbajos();
            dtproductosbajos.DataSource = recuper.Tables[0];
            dtproductosbajos.Columns[1].Width = 270;
        }
    }
}
