using System;

namespace calculator_if_and_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //calculadora con IF

            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("1) Addition\n2) Subtraction\n3) Multiplication\n4) Division ");
            int Option = int.Parse(Console.ReadLine());
            int TotalAd, TotalSub, TotalMul, TotalDiv;
            if (Option == 1)
            {
                TotalAd = x + y;
                Console.WriteLine("The result of adding these values is: {0}", TotalAd);
            }
            else if (Option == 2) 
            {    
                TotalSub = x - y;
                Console.WriteLine("The result of substracting these values is: {0}", TotalSub);
            }
            else if (Option == 3)
            {
                TotalMul = x * y;
                Console.WriteLine("The result of multiplying these values is: {0}", TotalMul);
            }
            else if (Option == 4)
            {
                TotalDiv = x / y;
                Console.WriteLine("The result of dividing these values is: {0}", TotalDiv);
            }
        }
    }
}
