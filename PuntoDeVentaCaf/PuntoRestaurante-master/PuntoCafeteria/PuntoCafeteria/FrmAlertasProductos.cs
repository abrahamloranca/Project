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
using System.Speech.Synthesis;

namespace PuntoCafeteria
{
  
    public partial class FrmAlertasProductos : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        ClassProducto objproducto = new ClassProducto();
        public FrmAlertasProductos()
        {
            InitializeComponent();
        }

        private void FrmAlertasProductos_Load(object sender, EventArgs e)
        {
            DataSet recuper = objproducto.Productosbajos();
            dtproductosbajos.DataSource = recuper.Tables[0];
            dtproductosbajos.Columns[1].Width = 270;
            synthesizer.SelectVoice("Microsoft Sabina Desktop");
            synthesizer.Volume = 100;
            synthesizer.Rate =-1;
            synthesizer.Speak("Alerta,escasez de producto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
