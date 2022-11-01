using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos
            //Tipo entero
            int edad, peso = 76;
            edad = 17;
            Console.WriteLine("La edad es {0} y la edad duplicada es {1}, y tu peso es {2}", edad, edad * 2, peso);

            //Tipo de cadenas de caracteres
            string nombre = "Lovelace";
            Console.WriteLine("Tu nombre es {0} y tu edad es {1}", nombre, edad);

            //Números en coma flotante
            double estatura = 1.7;
            Console.WriteLine("Tu nombre es {0}, tu edad es {1}, tu peso es {2} y estatura es {3}", nombre, edad, peso, estatura);
            Console.ReadKey();
        }
    }
}
