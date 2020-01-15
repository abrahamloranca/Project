using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PuntoCafeteria.Clases;

namespace PuntoCafeteria
{
    public partial class FrmReportesVentas : Form
    {
        public FrmReportesVentas()
        {
            InitializeComponent();
        }
        ClassReporte reporte = new ClassReporte();
        private void FrmReportesVentas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha1 = dtp1.Value.ToString("yyyy-MM-dd");
            string fecha2 = dtp2.Value.ToString("yyyy-MM-dd");
            DataSet recuper= reporte.Consultarmasvendido(fecha1,fecha2);
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Series.Clear();
            for (int i = 0; i < recuper.Tables[0].Rows.Count; i++)
            {
              Series serie=  chart1.Series.Add(recuper.Tables[0].Rows[i][0].ToString());
                serie.Label = recuper.Tables[0].Rows[i][1].ToString();
                serie.Points.Add(Convert.ToInt32(recuper.Tables[0].Rows[i][1]));

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
