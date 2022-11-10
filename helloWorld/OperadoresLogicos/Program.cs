using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicsOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios con operadores lógicos");
            string genero;
            int edad;
            Console.WriteLine("Ingresa tu género (h-m)");
            genero = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad");
            edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu nombre");
            string nombre = Console.ReadLine();

            if (edad >= 18 && (genero == "h" || genero == "H"))
            {
                Console.WriteLine($"Hola señor {nombre}, eres mayor de edad y tienes {edad} años.");
            }
            else if (edad < 18 && (genero == "h" || genero == "H"))
            {
                Console.WriteLine($"Hola joven {nombre} eres menor de edad y tiene {edad} años.");
            }
            else if (edad >= 18 && (genero == "m" || genero == "M"))
            {
                Console.WriteLine($"Hola señora {nombre}, eres mayor de edad y tienes {edad} años.");
            }
            else if ((genero != "h" || genero != "H") && (genero != "m" || genero != "M"))
            {
                Console.WriteLine("Genero Inválido.");
            }
            else
            {
                Console.WriteLine($"Hola señorita {nombre}, eres mayor de edad y tienes {edad} años.");
            }



            if (!(edad >= 16 && edad <= 60))
            {
                Console.WriteLine("Tu edad no está entre 16 y 60 años, por lo tanto no puedes votar");
            }
            else
            {
                Console.WriteLine("Si puedes votar en las elecciones del 2023");
            }
        }
    }
}