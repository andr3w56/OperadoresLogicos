using System;

                                        
public class Program
{
        public static void Main()
        {
                string NombreCompleto = "Andrew Fernando González Castillo";
                string FechaDeNacimiento = "28/07";
                byte Edad = 18;
                string Peso = "65kg";
                double Estatura = 1.67;
                char Genero = 'M';
		bool ifCarrera = true;
		Console.Write("Nombre Completo: {0}\nFecha De Nacimiento: {1}\nEdad = {2}\nPeso: {3}\nEstatura = {4}\nGénero: {5}\n", NombreCompleto, FechaDeNacimiento, Edad, Peso, Estatura, Genero);

		if (ifCarrera)
		{
			Console.Write("¿Es de TICS?: Si");
		}
		Console.ReadKey();
		

        }
} 
