using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
namespace TablaTiempos
{
    public partial class Form1 : Form
    {
        // se llama a la clase //
        clase objeto;
        int tamT = 0, TCC = 0; 
         string texto;
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular1_Click(object sender, EventArgs e)
        {
            if (txtconsistencia.Text != "" && txtdondicion.Text != "" && txtezf.Text != "" && txthabi.Text != "" && txtsuple.Text != "" && comboBox1.Text != "")
            {
                btncalif.Enabled = true;
                //envia la informacion de los txt a variables
                double fuerza = Convert.ToDouble(txtezf.Text);
                double habilidad = Convert.ToDouble(txthabi.Text);
                double consistencia = Convert.ToDouble(txtconsistencia.Text);
                double condicion = Convert.ToDouble(txtdondicion.Text);
                tamT = Convert.ToInt32(numericUpDown1.Value);
                int tamaño = 220;
                //crea un controlador uno de tipo control y otro de tipo textbox//
                control tb = new control();
                TextBox tareas = new TextBox();
                String num = comboBox1.Text;
                TextBox ciclos = new TextBox();
                TextBox C = new TextBox();
                C = new TextBox();
                //se el tamaño a los controladores//
                C.Size = new System.Drawing.Size(20, 0);
                //selecciona las cordenadas donde quiere que aparesca el controlador
                C.Location = new System.Drawing.Point(0, 200);
                C.Text = "CI";
                //añade el nuevo controlador 
                Controls.Add(C);
                int tamañotare = 20;




                for (int i = 1; i <= numericUpDown1.Value; i++)
                {
                    /*/  crea un textbox con sus respectivos tamaños y cordenadas donde 
                    queremos que aparesca el TextBox/*/

                    btn1.Enabled = false;
                    tb = new control();
                    tb.Size = new System.Drawing.Size(120, 20);
                    tb.Location = new System.Drawing.Point(tamañotare, 200);
                    tareas = new TextBox();
                    tareas.Size = new System.Drawing.Size(117, 200);
                    tareas.Location = new System.Drawing.Point(tamañotare, 180);

                    //esta instruccion creara una ventana aparte donde se introduciran las tareas//
                    String texto = Microsoft.VisualBasic.Interaction.InputBox(

                 "Tarea:" + i,

                 "",

                 "");
                    tareas.Text = texto;
                    Controls.Add(tb);
                    Controls.Add(tareas);
                    tamañotare = tamañotare + 120;
                }
                switch (num)
                {
                    //dependiendo del tiempo que seleccione el usuario en minutos sera la cantidad de ciclos//
                    case "0,10":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 200; i++)
                        {

                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(200, tamT, 200, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToInt32(txtsuple.Text));
                            TCC = 200;
                        }

                        break;
                    case "0,25":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 100; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(100, tamT, 100, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 100;
                        }

                        break;
                    case "0,50":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 60; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(60, tamT, 60, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 60;
                        }
                        break;
                    case "0,75":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 40; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(40, tamT, 40, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 40;
                        }
                        break;
                    case "1,00":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 30; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(30, tamT, 30, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 30;
                        }
                        break;
                    case "2,00":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 20; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(20, tamT, 20, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 20;
                        }
                        break;
                    case "2,00-5,00":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 15; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(15, tamT, 15, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 15;
                        }
                        break;
                    case "5,00-10,00":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 10; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(10, tamT, 10, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 10;
                        }
                        break;
                    case "10,00-20,00":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 8; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(8, tamT, 8, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 8;
                        }
                        break;
                    case "20,00-40,00":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 5; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(5, tamT, 5, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 5;
                        }
                        break;
                    case "40,00 o mas":
                        // el for se encarga de determinar cuantas veces sera el ciclo
                        for (int i = 1; i <= 3; i++)
                        {
                            //crea los cuadros con el numero del ciclo con su respectivo tamaño y posicion en cordenadas
                            ciclos = new TextBox();
                            ciclos.Size = new System.Drawing.Size(20, 80);
                            ciclos.Location = new System.Drawing.Point(0, tamaño);
                            ciclos.Text = Convert.ToString(i);
                            Controls.Add(ciclos);
                            tamaño = tamaño + 20;
                            objeto = new clase(3, tamT, 3, tamT, fuerza, condicion, habilidad, consistencia, Convert.ToDouble(txtsuple.Text));
                            TCC = 3;
                        }
                        break;



                }



            }
            else
            {
                MessageBox.Show("Falta ingresar algun dato");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnto.Enabled = true;
            btntc.Enabled = false;
            
            // variables 
            int tama = 0;
            double time = 0;
            TextBox tc = new TextBox();
            for (int t = 0; t < tamT; t++)
            {
               //variables
                tama = tama + 120;
                int tame = 220;
                //for que controla el numero de ciclos
                for (int c = 0; c < TCC; c++)
                {
                    //if controla la cordenada donde aparecera el textbox
                    if (tama == 120)
                    {
                        tama = 48;
                    }
                    //abrira una ventana nueva donde se ingresara los tiempo cronometro
                    do
                    {
                     texto = Microsoft.VisualBasic.Interaction.InputBox(

                         "ingrese el TC, ciclo:" + c,

                         "Tarea:" + t,

                         "");
                     if (texto == "" || char.IsLetter(texto,0))
                     {MessageBox.Show("No puedes dejar el campo vacio u Ingresa un numero Entero", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    } while (texto == "" || char.IsLetter(texto,0));
                    //añadira los textbox con los tiempos cronometros uno por uno
                    time = Convert.ToDouble(texto);
                   // se crea un tipo de dato textbox
                    tc = new TextBox();
                    // se le da tamaño 
                    tc.Size = new System.Drawing.Size(30, 20);
                    // se le da la localizacion 
                    tc.Location = new System.Drawing.Point(tama, tame);
                    //se ingresa el texto que aparecera en el textbox
                    tc.Text = Convert.ToString(time);
                   //agregar los controles creados arriba
                    Controls.Add(tc);
                    //incrementa la posicion de el textbox para que no se encime
                    tame = tame + 20;
                    // se llama al objeto agregar //
                    objeto.Agregar(c, t, time);
                }


            }
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            btnto.Enabled = false;
            btnTN .Enabled = true;
            
            int tama = 0;
            TextBox to = new TextBox();
            //controla las repeticiones de las tareas 
            for (int t = 0; t < tamT; t++)
            {
                //40,128//
                tama = tama + 120;
                int tame = 220;
                // crea una matriz 
                double[,] To = new double[objeto._numciclos, tamT];
                if (tama == 120)
                {
                    tama = 75;
                }
                To = objeto.To(t);
                //for que controla el numeo de ciclos 
                for (int c = 0; c < objeto._numciclos; c++)
                {
                    //crea un objeto de tipo textbox
                    to = new TextBox();
                    //tamaño de el textbox
                    to.Size = new System.Drawing.Size(30, 20);
                    //localizacion de el textbox
                    to.Location = new System.Drawing.Point(tama, tame);
                    //se incrementa el tamaño de la variable que controla la posicion donde aparece el textbox
                    tame = tame + 20;
                    to.Text = Convert.ToString(To[c, t]);
                    Controls.Add(to);
                }




            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //activa o desactiva los botones
            btncalif.Enabled = false;
            btntc.Enabled = false;
            btnTN.Enabled = false;
            btnto.Enabled = false;
            btnTotal.Enabled = false;
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pondra las calificacion 
            btntc.Enabled = true;
            btncalif.Enabled = false;
            double calif;
            calif = objeto.C();
            int tama = 0;

            TextBox to = new TextBox();
            //for que controla cuantas tareas son 
            for (int t = 0; t < tamT; t++)
            {
                //40,128//
                tama = tama + 120;
                int tame = 220;
                //crea una matriz donde se guardaran los TO
                double[,] To = new double[objeto._numciclos, tamT];
                if (tama == 120)
                {
                    tama = 20;
                }

                //manda a llamar al metodo to y se asigna a la matriz arriba creada
                To = objeto.To(t);
               //for que controla los ciclos 
                for (int c = 0; c < objeto._numciclos; c++)
                {
                    //se crea un objeto de tipo textbox
                    to = new TextBox();
                   //se leda el tamaño al textbox
                    to.Size = new System.Drawing.Size(30, 20);
                    //la posicion que aparecera el textbox
                    to.Location = new System.Drawing.Point(tama, tame);
                    // se suma la posicion que aparecera para que no se encime 
                    tame = tame + 20;
                    //se asigna que textocontendra y sera la calificacion 
                    to.Text = Convert.ToString(calif);
                    // agrega los controles to creado arriba 
                    Controls.Add(to);
                }
            }
        }

        private void btnTN_Click(object sender, EventArgs e)
        {
            //desactivara el boton tn
            btnTN.Enabled = false;
            //activara el boton total
            btnTotal.Enabled = true;
            //se crea una matriz
            double[,] Tn = new double[objeto._numciclos, tamT];
            //variable que controla la posicion donde aparece el textbox de abajo 
            int tama = 0;
           // se crea el el objeto de tipo  textbox 
            TextBox to = new TextBox();
           // se llena la matriz que se creo arriba con lo que devuelva el metodo TN
            Tn = objeto.TN(tamT);
            //for que controla el numero de tareas
            for (int t = 0; t < tamT; t++)
            {
                // se suma la posicion de la cordenada del textbox
                tama = tama + 120;
                int tame = 220;

                
                if (tama == 120)
                {
                    tama = 105;
                }
              //for que controla el numero de ciclos
                for (int c = 0; c < objeto._numciclos; c++)
                {
                    //se crea el objeto textbox de tipo textbox 
                    to = new TextBox();
                    // se le da el tmaño al objeto textbox
                    to.Size = new System.Drawing.Size(30, 20);
                    // se asigna las cordenadas la cual se suma arriba tama
                    to.Location = new System.Drawing.Point(tama, tame);
                    //se suma tame esto para quno se encimen y caigan en las mismas cordenadas 
                    tame = tame + 20;
                    // se le asigna lo que tendra el texto 
                    to.Text = Convert.ToString(Tn[c, t]);
                    //agrega los controles que se crearon arriba (to)
                    Controls.Add(to);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //matriz que guardara el totalde to
            double[] totalto = new double[tamT];
            //matriz que guardara el total de tn
            double[] totaltn = new double[tamT];
            //matriz que uardara el total de tnpromedio
            double[] totaltnprom = new double[tamT];
            //matriz que guardara el total del suplemento
            double[] suple = new double[tamT];
            //guardara el primer tiempo estimado
            double[] Tiempoestim = new double[tamT];
            //guardara el tiempo estimado 2 
            double[] tiempoestimad2 = new double[tamT];
            //tiempo estandar 
            double tiempoestandar;
            //las siguiente 7 lineas de codigo llaman a los metodos para 
            //devolver el total de cada uno
            totalto = objeto.totalTo(tamT, TCC);
            totaltn = objeto.totalTn(tamT, TCC);
            totaltnprom = objeto.Tnprom(TCC, tamT);
            suple = objeto.Porcentajesuplemento(tamT);
            Tiempoestim = objeto.Tiempoestimado(tamT);
            tiempoestimad2 = objeto.tiempoesti2(tamT, Convert.ToInt32(numericUpDown2.Value));
            tiempoestandar = objeto.Tiempoestandarproceso(tamT);
            //se crea un tipo de dato formulario 2 con esto abriremos el proximo formulario en el mostrar los totales
            frm.TamT =Convert.ToInt32(numericUpDown1.Value);
            //se asignan todas las variables a mostrar en el formulario dos 
            frm.tcc = TCC;
            frm.totalto = totalto;
            frm.totaltn = totaltn;
            frm.tnprom = totaltnprom;
            frm.suplementos = suple;
            frm.tiempoest = Tiempoestim;
            frm.tiempoesti2 = tiempoestimad2;
            frm.tiempoestandar = tiempoestandar;
            // se abre el formulario dos
            frm.Show();

        }

        private void txthabi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // este bloque de codigo son  eventos que ayudan a restringir lo que el usurio igrese
            //si el usuario ingresa una letra 
            if (!char.IsDigit(e.KeyChar))
            {
                //escribir sera bloqueado
                e.Handled = true;
            }
            //si el textbox contiene un punto
            if (txthabi.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    //no podras escribir otro punto
                    e.Handled = true;
                }
            }
            //si contiene un menos 
            if (txthabi.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    //no podras escribir otro menos
                    e.Handled = true;
                }
            }

            else
            {
                //si el usuario  ingresa un caracter diferente de numero sera bloqueado el escribir 
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                // el menos y el punto son los unicos caracteres que ingresara el usrio
                if (e.KeyChar == '-' && e.KeyChar == '.')
                {
                    e.Handled = false;
                }


            }

            if (txthabi.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
            if (txthabi.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b' || e.KeyChar == '-')
                {
                    e.Handled = false;
                }
            }


        }

        private void txtdondicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdondicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtdondicion.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (txtdondicion.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '-' && e.KeyChar == '.')
                {
                    e.Handled = false;
                }


            }

            if (txtdondicion.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
            if (txtdondicion.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b' || e.KeyChar == '-')
                {
                    e.Handled = false;
                }
            }


        }

        private void txtezf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtezf.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (txtezf.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '-' && e.KeyChar == '.')
                {
                    e.Handled = false;
                }


            }

            if (txtezf.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
            if (txtezf.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b' || e.KeyChar == '-')
                {
                    e.Handled = false;
                }
            }

        }
        //evento que no deja escribir letras
        private void txtconsistencia_KeyPress(object sender, KeyPressEventArgs e)
      {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtconsistencia.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (txtconsistencia.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
           
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar=='-' && e.KeyChar == '.' )
                {
                    e.Handled = false;
                }
              

            }

            if (txtconsistencia.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
            if (txtconsistencia.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b' || e.KeyChar=='-')
                {
                    e.Handled = false;
                }
            }

        }

        private void txtsuple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txthabi.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (txthabi.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '-' && e.KeyChar == '.')
                {
                    e.Handled = false;
                }


            }

            if (txthabi.Text.Contains("-"))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
            }
            if (txthabi.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b' || e.KeyChar == '-')
                {
                    e.Handled = false;
                }
            }

           
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void txtsuple_TextChanged(object sender, EventArgs e)
        {

        }
    }
}