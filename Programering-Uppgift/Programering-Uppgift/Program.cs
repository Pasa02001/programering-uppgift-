using System;

namespace Programering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RNumber = random.Next(0, 100);

            int Snummer = Int32.Parse(Console.ReadLine());
            Console.WriteLine(RNumber);

            if (Snummer > RNumber)
                Console.WriteLine("Ditt tal är större");
            if (Snummer < RNumber) 
                Console.WriteLine("Ditt nummer är mindre");
            else 
                Console.WriteLine("Ditt nummer är lika stort");


        }
    }
}
