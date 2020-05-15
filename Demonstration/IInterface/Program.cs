using System;

namespace IInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CupOfCoffee cf = new CupOfCoffee(true);
            cf.AddSugar();

        }
    }
}
