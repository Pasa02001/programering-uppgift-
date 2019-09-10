using System;

namespace Programering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Gissa ett tal: ");
                Random random = new Random();
                int RNumber = random.Next(0, 100);
            while (true)
            {
                int Snummer = Int32.Parse(Console.ReadLine());

       

                if (Snummer > RNumber)
                    Console.WriteLine("Ditt tal måste bli mindre");
                if (Snummer < RNumber)
                    Console.WriteLine("Ditt tal måste bli större");
                    
                if (Snummer == RNumber)
                    Console.WriteLine("Ditt tal är lika stort");

                if (Snummer != RNumber)
                    Console.Write("Testa igen: ");

                if (Snummer == RNumber)
                    break;
            }


        }
    }
}
