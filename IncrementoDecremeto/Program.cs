using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementoDecremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Ingrese nota final: ");
            byte NotaFinal = Convert.ToByte(Console.ReadLine());
            Console.Write("Ingrese nota: ");
            byte Nota = Convert.ToByte(Console.ReadLine());
            string res = (Nota >= NotaFinal) ? "Haz alcazado la nota final." : "No alcanzaste la nota final.";
            Console.WriteLine(res);
            Console.ReadKey();*/

            Random rnd = new Random();
            int Aleatorio = rnd.Next(1, 13);

            Console.WriteLine($"El numero random es: {Aleatorio}");

            string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", 
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            /*for (int i = 1; i <= 12; i++)
            {
                if (Aleatorio == i)
                {
                    Console.WriteLine(meses[i-1]);
                }
            }*/


            if (Aleatorio == 1)
            {
                Console.WriteLine(meses[0]);
            }
            if (Aleatorio == 2)
            {
                Console.WriteLine(meses[1]);
            }
            if (Aleatorio == 3)
            {
                Console.WriteLine(meses[2]);
            }
            if (Aleatorio == 4)
            {
                Console.WriteLine(meses[3]);
            }
            if (Aleatorio == 5)
            {
                Console.WriteLine(meses[4]);
            }
            if (Aleatorio == 6)
            {
                Console.WriteLine(meses[5]);
            }
            if (Aleatorio == 7)
            {
                Console.WriteLine(meses[6]);
            }
            if (Aleatorio == 8)
            {
                Console.WriteLine(meses[7]);
            }
            if (Aleatorio == 9)
            {
                Console.WriteLine(meses[8]);
            }
            if (Aleatorio == 10)
            {
                Console.WriteLine(meses[9]);
            }
            if (Aleatorio == 11)
            {
                Console.WriteLine(meses[10]);
            }
            if (Aleatorio == 12)
            {
                Console.WriteLine(meses[11]);
            }
        }
    }
}
