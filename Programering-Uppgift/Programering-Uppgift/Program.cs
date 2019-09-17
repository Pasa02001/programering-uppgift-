using System;

namespace Programering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            int försök = 0; // ett intvärde som börgar på 0 för att räkna antal försök senare i koden 

            Console.Write("Gissa ett tal: "); //Här har vi en vanlig text som kommer fram i börgan av koden för att fråga efter ett tal
                Random random = new Random(); // Här får den kommadot att göra ett random tal in i en int har dok inte valt det än
                int RNumber = random.Next(0, 100); // Här används int och gör det till ett tal, detta talet måste då ligga mellan 0 oc 100
            while (true) // Jag vill att man ska kunna spela spelat enda fram till det blir rätt så jag gör en while loop 
            {
                
                int Snummer = Int32.Parse(Console.ReadLine()); //Här kommer spelar kunna skriva in sitt tal, detta talet sparas som en int så att man kan använda det igen 

                försök++; //int talet kommer att öka varge gång loopen har körts. Detta räkanr antal försk det tog tills man klarade spelet

                if (Snummer > RNumber) // I denna if satsen så kommer den kolla ifall talet som är skrivet är större en det datan har genarert ifall inte så går den vidare till nästa if sats
                {
                    Console.WriteLine("Ditt tal måste bli mindre"); // Ifall if satsen genomförs så sta den skriva att talet faktiskt är för stort 
                    Console.Write("Försök igen: "); // säjer till att man ska försöka igen
                }
                if (Snummer < RNumber)// I denna så är det samma prensip och kollar ifalld talet är mindre istället för att kolla ifall det är större
                { 
                    Console.WriteLine("Ditt tal måste bli större"); // Ifall if satsen genomförs så skriver den ut att talet är för litet
                    Console.Write("Försök igen: ");//Säjer att man ska försöka igen
                }
                if (Snummer == RNumber)// ifall talet nu blir lika stort så utförs denna ifsatsen 
                {   
                    Console.WriteLine("Ditt tal är lika stort"); // När ifsatsen kör så kommer den först köra "Ditt tal är lika stort"
                    Console.WriteLine("Det tog " + försök + " försök innan du klarade uppgiften"); // Här skrivs bårde text och int talet som har fått ett värde på hur månag gånger loopen har körts
                    break; //ifall if satsen är genomföd så kommer while loopen stopas här.
                }
            }


        }
    }
}
