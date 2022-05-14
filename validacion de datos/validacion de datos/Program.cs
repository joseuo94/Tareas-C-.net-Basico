using System;

namespace validacion_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor digitar los datos necesarios.");
            Console.WriteLine("Nombre completo:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Email");
            string email = Console.ReadLine();
            Console.WriteLine("Favor digitar su direccion:");
            string direccion = Console.ReadLine();
            Console.WriteLine("favor digitar su edad");
            int edad = int.Parse(Console.ReadLine());
            while(edad<18)
            {
                Console.WriteLine("La edad suministrada debe ser mayo a 18");
                Console.WriteLine("favor digitar su edad");
                edad = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Estara recibiendo un correo con su registro.\nGracias por los datos suministrados");
        }
    }
}
