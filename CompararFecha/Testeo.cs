using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompararFecha
{
    public class Testeo
    {
        public Testeo() { 
        
        }
        public  void process( )
        {
            
            Console.WriteLine( esAtrasado("14/07/2019","Programado") );
            Console.ReadKey();
        }
        private bool esAtrasado(String fechaComparar,String estado ) {
            bool res = false;
            if( estado == "Programado"){
                int[] fechaActual = sacarDiaMesAño(obtenerFechaActual());
                int[] fechaCompa = sacarDiaMesAño(fechaComparar);
                if (fechaCompa[2] < fechaActual[2]) {//si es un pedido de años anteriores 
                    MessageBox.Show("del año pasdo es");res =true;
                }

                if( fechaCompa[2] == fechaActual[2] ){// si son de este año los envios
                if( fechaCompa[1] < fechaActual[1] ){//tienen meses de atraso
                    MessageBox.Show("tiene un mes de atrasado "); res = true;
                }
                if (fechaCompa[1] == fechaActual[1]) { //si son del mes corriente
                if (fechaCompa[0] < fechaActual[0]){
                    MessageBox.Show("tiene dias de atraso"); res= true;
                }
                }

                }
            }
            return false;
        }
        private int[] sacarDiaMesAño(String cade){
            int[] datos= new int[3];
            
            String dia="",mes="",año="";
            var cara = cade.ToCharArray();
            int zentinela = 0;
            for (int i = 0; i < cara.Length; i++ ) {

                if (cara[i] == '/' ) {
                    zentinela++;
                    continue;
                } 
                if (zentinela == 0) { 
                dia +=cara[i].ToString();
                }if(zentinela == 1) { 
                mes+= cara[i].ToString();
                } if (zentinela == 2) { 
                año+= cara[i].ToString();
                }
            }
            datos[0] = Convert.ToInt32( dia );
            datos[1]= Convert.ToInt32( mes );
            datos[2] = Convert.ToInt32(año);
        return datos;
        }

        private  String obtenerFechaActual() {
            return System.DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void test()
        {

            int[] diasMes = { 31, 28, 21 };
            foreach (int dias in diasMes)
            {
                Console.WriteLine("Dias del mes: {0}", dias);
            }

            string[] nombres = { "Alberto", "Andrés", "Antonio" };
            foreach (string nombre in nombres)
            {
                Console.Write(" {0}", nombre);
            }
            Console.WriteLine();

            string saludo = "Hola";
            foreach (char letra in saludo)
            {
                Console.Write("{0}-", letra);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
