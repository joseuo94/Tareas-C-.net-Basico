using System;

namespace menu_calculo_gemetrico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor seleccionar la figura geometrica que desea calcular el area");
            Console.WriteLine("1) Triangulo.\n2) Reactangulo.\n3) Trapecio.\n4) Circulo.\n5) Rombo.");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)

            {

                case 1:
                    Console.WriteLine("Ingrese el valor de la base: ");
                    double ba1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    double AreaTria = (ba1 * altura) / 2;
                    Console.WriteLine("El area del triangulo es: " + AreaTria);
                    break;


                case 2:
                    Console.WriteLine("intrese el valor de la base:");
                    ba1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el valor de la altura");
                    altura = double.Parse(Console.ReadLine());
                    double arearectangulo = ba1 * altura;
                    Console.WriteLine("El area del rectangulo es:" + arearectangulo);
                    break;

                case 3:
                    Console.WriteLine("ingrese el valor de la base");
                    ba1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el valor de la segunda base");
                    double ba2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el valor de la altura");
                    altura = double.Parse(Console.ReadLine());
                    double areatrap = ((ba1 + ba2) * altura) / 2;
                    Console.WriteLine("El area del trapecio es: " + areatrap);
                    break;

                case 4:
                    Console.WriteLine("Favor digite el Radio:");
                    double radio = double.Parse(Console.ReadLine());
                    double areacirculo = 3.14 * (radio * radio);
                    Console.WriteLine("El area del circulo es:" + areacirculo);
                    break;

                case 5:
                    Console.WriteLine("Favor digitar el valor de la Diagonal superior");
                    double diagsup = double.Parse(Console.ReadLine());
                    Console.WriteLine("Favordigitar el valio de la diagonal inferior:");
                    double diaginf = double.Parse(Console.ReadLine());
                    double arearombo = (diagsup * diaginf) / 2;
                    Console.WriteLine("El area del rombo es:" + arearombo);
                    break;

                default:
                    Console.WriteLine("el valor suministrado no fue valido");
                    break;

            }
        }
    }
}
