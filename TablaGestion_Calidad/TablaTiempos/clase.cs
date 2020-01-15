using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TablaTiempos
{
    class clase
    {
            private double [,] vect;
            private int numC;
            private int numT;
            private double habilidad;
            private double esfuerzo;
            private double condicionT,suplemento;
            private double cnsistencia;
            private double totalc = 0;
            double[,] inicio;
            double[,] TN0;
            double[] totalto,totaltn,totaltnprom,suplementos,timeestimado,timeestimado2;



        //propiedad de la matriz se guarda la informacion aqui//
        public double [,] _vect
        {

            get { return vect; }
        
        }

        public int _numT
        {
            set{}
            get { return numT;; }

        }
        //propiedad tarea se guarda el limite de tareas//
       
        //propiedad numero de ciclos//
        public int _numciclos
        {

            set {}
            get { return numC; }
        }
        public double[,] _to
        {

            set { }
            get { return inicio; }
        }
        //propiedad calificacion
        public double _C
        {

            set {}
            get { return totalc; }
        }
        //propiedad de lectura de la matriz//
        public double [,] retorna()
        {

            return vect;
        }

        //constructor 
        public clase()
        {
            vect = new double [4, 5];

        }
        //contructor con pase de parametros//
        public clase(int tamT, int tamC,int numc,int numt,double fuerza,double condi,double habi,double consis,double suple)
        {
            vect = new double[tamT, tamC];
            numC = numc;
            numT = numt;
            esfuerzo = fuerza;
            condicionT = condi;
            habilidad = habi;
            cnsistencia = consis;
            inicio = new double[_numciclos, numT];
            suplemento = suple;
        }
        
       
        //agregando datos a la matriz

        public void Agregar(int num, int dia,double TC)
        {

           
           vect[num, dia]= TC;
               
      
        }
        //metodo que saca rl resultado de los TO//
        public double[,] To(int tarea)
        {
           
          //  tarea=tarea-1;//
           if (tarea == 0)
           {
               for (int i = 0; i < _numciclos; i++)
               {
                   if (i == 0)
                   {
                       inicio[i, tarea] = vect[i, tarea];
                   }
                   else
                   {
                       inicio[i, tarea] = vect[i, tarea] - vect[i - 1 , numT - 1];
                   }
               }


           }
           else
           {
               for (int i = 0; i < _numciclos; i++)
               {
                   inicio[i, tarea] = vect[i, tarea] - vect[i, tarea - 1];

               }
           }
            return inicio;
        }

        //metodo que saca el resultado de los TN//
        public double[,] TN(int tarea)
        {

            TN0 = new double[_numciclos, numT];
            for (int j = 0; j < tarea; j++)
            {

                for (int i = 0; i < _numciclos; i++)
                {

                    TN0[i, j] = inicio[i, j] * totalc;

                }
            }
            return TN0;
        }
        //metodo que suma las calificaciones que vaya ingresando el operador//
        public double C()
        {
            
            if (cnsistencia >= 0)
            {
                totalc = totalc + cnsistencia;
            }
            else
            {
                totalc = totalc - Math.Abs(cnsistencia);
            }
            if (habilidad >= 0)
            {
                totalc = totalc + habilidad;
            }
            else
            {
                totalc = totalc -Math.Abs( habilidad);
            }
            if (esfuerzo >= 0)
            {
                totalc = totalc + Math.Abs(esfuerzo);
            }
            else
            {
                totalc = totalc -Math.Abs(esfuerzo);
            }
            if (condicionT >= 0)
            {
                totalc = totalc + condicionT;
            }
            else
            {
                totalc = totalc - Math.Abs(condicionT);
            }
           totalc=totalc + 1;
            return totalc;

        }


        //saca el total del TO//
        public double[] totalTo(int tarea,int tcc)
        {
            totalto = new double[tarea];
            int POS=0;

            for (int i = 0; i <  tarea; i++)
            {
                for (int c = 0; c < tcc; c++)
                {
                    totalto[POS] = inicio[c, i] + totalto[POS];
                }
                POS++;
            }
            return totalto;
        }

        //total tn//
        public double[] totalTn(int tarea, int tcc)
        {
            totaltn = new double[tarea];
            int POS = 0;

            for (int i = 0; i < tarea; i++)
            {
                for (int c = 0; c < tcc; c++)
                {
                    totaltn[POS] = TN0[c, i] + totaltn[POS];
                }
                POS++;
            }
            return totaltn;
        }

        //TN promedio recive dos parametros que seria cantidad ciclos y tareas//
        public double[] Tnprom(int ciclos,int tarea)
        {
            totaltnprom = new double[tarea];
            int pos=0;
            for (int i = 0; i < tarea; i++)
            {


                totaltnprom[i] = totaltn[i] / ciclos;
               pos++;
              
   
            }
            return totaltnprom;
        
        }

        //metodo que devuelve el porcentaje del suplemento
        public double[] Porcentajesuplemento(int tarea)
          
          {
            suplementos= new double[tarea];
            for (int i = 0; i < tarea; i++)
            {


                suplementos[i] =totaltnprom[i]*suplemento/100;
              
   
            }
            return  suplementos;
        
        }

        // metodo qe devuelve el tiempo estimado 
        public double[] Tiempoestimado(int tarea)
        {
            timeestimado = new double[tarea];
            for (int i = 0; i < tarea; i++)
            {


                timeestimado[i] = totaltnprom[i]+suplementos[i];


            }
            return timeestimado;

        }
        // metodo que devuelve el segundo tiempo estimado //
        public double[] tiempoesti2(int tarea,int ocurrencias)
        {
            timeestimado2 = new double[tarea];
            for (int i = 0; i < tarea; i++)
            {


                timeestimado2[i] = timeestimado[i] * ocurrencias;


            }
            return timeestimado2;

        }
        //metodo que devuelve el tiempo estandar de proceso//
        public double Tiempoestandarproceso(int tarea)
        {
            double timeestandar=0;
            for (int i = 0; i < tarea; i++)
            {


                timeestandar+=timeestimado2[i];


            }
            return timeestandar;

        }
    }
}
