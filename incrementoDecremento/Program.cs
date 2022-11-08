using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incrementoDecremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso de operadores de incremento y decremento");
            int p;
            int devin = 1, j=1;
            p=devin++;
            Console.WriteLine("El resultado de devin++ {0} y p {1}", devin, p);

            p = ++j;

            Console.WriteLine("El resultado de devin++ {0} y p {1}", j, p);




            //Operadores de asignación
            Console.WriteLine("Uso de operadores de asignación");
            int edad = 10;
            edad *= 10;
            Console.WriteLine($"La edad multiplicada por 10 {edad}");


            //Operadores de relación
            Console.WriteLine("Uso de operadores de relación");
            bool flag = edad > p;
            Console.WriteLine("El valor de la variable flag es {0} ", flag);

            //Operador ternario
            Console.WriteLine("Uso de operadores ternarios");
            string res = (edad >= 18) ? "Eres mayor de edad" : "No eres mayor de edad";
            Console.WriteLine("Resultado del operador ternario en la variable res {0}", res);


            //Ejercicio en clase
            //Se ingresa una nota final por teclado
            Console.WriteLine("Introduce la nota final");
            byte nota = Convert.ToByte(Console.ReadLine());
            string nota2 = (nota >= 30) ? "Aprobaste" : "Reprobaste";
            Console.WriteLine("Resultado {0}", nota2);




            Console.ReadKey();

        }
    }
}
