using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TablaTiempos
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        public  int TamT=0;
        public int tcc = 0;
       //creacion de arreglos para guardar los totales 
        public double[] totalto,totaltn,tnprom,suplementos,tiempoest,tiempoesti2;
        public double tiempoestandar;
       // se crea un objeto de la clase para llamar a los metodos
        clase objeto = new clase();
        private void button1_Click(object sender, EventArgs e)
        {
            // for que controla el numero de tareas 
            int Tn = 1;
            for (int i = 0; i < TamT; i++)
            {
              //agrga los totales a el list view de el formulario dos
                listView1.Items.Add("tarea" + Tn + ": " + totalto[i].ToString());
                //agrega el tn promedio
                listView3.Items.Add("tarea" + Tn + ": " + tnprom[i].ToString());
                //agrega el total del tn
                listView2.Items.Add("tarea" + Tn + ": " + totaltn[i].ToString());
                //agrega el tcc
                listView4.Items.Add("tarea" + Tn + ": " + tcc);
                //agrega el suplemento
                listView5.Items.Add("tarea" + Tn + ": " + suplementos[i].ToString());
                //agrega el tiemp estimado 
                Tiempo.Items.Add("tarea" + Tn + ": " + tiempoest[i].ToString());
                //agrega el tiempo estimado dos
                listView7.Items.Add("tarea" + Tn + ": " + tiempoesti2[i].ToString());
                Tn++;

            }
            lblTotalestimado.Text = tiempoestandar.ToString();
            DialogResult result = MessageBox.Show("desea ver algunas recomendaciones?", "RECOMENDACIONES", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                Recomendaciones reco = new Recomendaciones();
                reco.Show();
            }
            else if (result == DialogResult.No)
            {
            }
            else if (result == DialogResult.Cancel)
            {
            }

          

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
