using System;

namespace Inlamningsuppgift
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                //Rebecka Klausen, rebkla-1, L0002B
                // Här frågar jag efter input: pris på vara/varor (price) och hur mycket kunden har betalat (payment//
                Console.Write("Ange pris: ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Hur mycket kunden har betalat: ");
                int payment = int.Parse(Console.ReadLine());

                // Här räknar jag ut vad differensen blir när kunden har betalat
                int diff = (payment - price);                

                //Här avänder jag mig av if-statement för att ta reda på om kunden har betalat in för mycket, för lite eller betalat jämt ut.
                if (diff==0)
                {
                    Console.WriteLine("Toppen, du har betalat med jämna pengar");
                    Console.ReadLine();
                } if (diff < 0)
                {
                    Console.WriteLine($"Tyvärr räcker pengarna inte till, du saknar {diff} kronor");
                    Console.ReadLine();
                }
                if (diff>0)
                {
                    Console.WriteLine($"Kunden får tillbaka: " + diff + " kronor");
                    if (diff/500>0)
                    {
                        Console.WriteLine("500-lappar: "+ diff/500);
                    }
                    diff = diff % 500;
                    if (diff / 100 > 0)
                    {
                        Console.WriteLine("100-lappar: " + diff / 100);
                    }
                    diff = diff % 100;
                    if (diff / 50 > 0)
                    {
                        Console.WriteLine("50-lappar: " + diff / 50);
                    }
                    diff = diff % 50;
                    if (diff / 20 > 0)
                    {
                        Console.WriteLine("20-lappar: " + diff / 20);
                    }
                    diff = diff % 20;
                    if (diff / 10 > 0)
                    {
                        Console.WriteLine("10-kronor: " + diff / 10);
                    }
                    diff = diff % 10;
                    if (diff / 50 > 0)
                    {
                        Console.WriteLine("5-kronor: " + diff / 5);
                    }
                    diff = diff % 5;
                    if (diff / 2 > 0)
                    {
                        Console.WriteLine("2-kronor: " + diff / 2);
                    }
                    diff = diff % 2;
                    if (diff / 1 > 0)
                    {
                        Console.WriteLine("1-kronor: " + diff / 1);
                    }
                    diff = diff % 1;
                }

 
            }
             
        }
    }
}
