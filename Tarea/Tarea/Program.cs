using System;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prota;
            string villano;
            string edad;
            string cont;
            string poderprot;
            string reino1;
            string reino2;
            



            Console.WriteLine("Cual es el nombre del protagonista de esta historia?");
            prota = Console.ReadLine();

            Console.WriteLine("Cual es el nombre del villano?");
            villano = Console.ReadLine();

            Console.WriteLine("Cual es la edad del protagonista?");
            edad = Console.ReadLine();

            Console.WriteLine("Cual es el continente del protagonista?");
            cont = Console.ReadLine();

            Console.WriteLine("cual es el poder del protagonista?");
            poderprot = Console.ReadLine();

            Console.WriteLine("cual es el el nombre del reino humano?");
            reino1 = Console.ReadLine();

            Console.WriteLine("cual es el el nombre del reino elfo?");
            reino2 = Console.ReadLine();



            Console.WriteLine("En un continente muy lejano llamado " + cont + ",  el cual esta dividido en tres reinos los cuales son " + reino1 + ", " + reino2 + ". ");
            Console.WriteLine("nacio un niño llamado " + prota + " , quien no es mas que un rey reencarnado, quien de alguna manera aun conserva los recuerdos de su vida pasada");
            Console.WriteLine("el enemigo del continente es conoccido como " + villano + " y su objetivo es crear una guerra entre " + reino1 + ", " + reino2 + " ");
            Console.WriteLine("pero " + prota + " con ayuda de sus compañeros y el poder llamado " + poderprot + " el cual obtuvo cuando a penas tenia " + edad + " años de edad ");
            Console.WriteLine("" + prota + " podra salvar todo su contiente por el que tanto ha luchado.");
        }
    }
}
