using System;

namespace tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TAREA: Calcular area de 5 figuras geometricas solicitando los valores al usuario.
            Console.WriteLine("Ingrese el valor de la base: ");
            double base1 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el valor de la base2: ");
            double base2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del radio: ");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la diagonal mayor: ");
            double diagonalMayor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la diagonal menor: ");
            double diagonalMenor = double.Parse(Console.ReadLine());

            double aTriangulo = (base1 * altura) / 2;
            double aRectangulo = base1 * altura;
            double aTrapecio = ((base1 + base2) * altura) / 2;
            double aCirculo = 3.14 * (radio * radio);
            double aRombo = (diagonalMayor * diagonalMenor) / 2;

            Console.WriteLine("El area del triangulo es: " + aTriangulo);
            Console.WriteLine("El area del rectangulo es: " + aRectangulo);
            Console.WriteLine("El area del trapecio es: " + aTrapecio);
            Console.WriteLine("El area del circulo es: " + aCirculo);
            Console.WriteLine("El area del rombo es: " + aRombo);
        }
    }
}
