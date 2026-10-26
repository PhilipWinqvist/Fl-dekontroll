
using System;

class Program
{
    static void Main()
    {
        // Loopen som kör programmet tills användaren väljer att avsluta.
        bool korProgram = true;

        while (korProgram)
        {
            Console.WriteLine("\n@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@@@ ~~ Huvudmeny ~~ @@@");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("\n1. Ungdom eller pensionär");
            Console.WriteLine("2. Upprepa tio gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj ett alternativ: ");

            string val = Console.ReadLine() ?? "";

            if (val == "1")
            {
                // uppgift 1
                Console.WriteLine(" ~~ Biobiljetter ~~");

                int antalPersoner = 0;

                while (antalPersoner < 1 || antalPersoner > 25)
                {
                    Console.Write("Hur många ska gå på bio? ");

                    if (int.TryParse(Console.ReadLine(), out antalPersoner))
                    {
                        if (antalPersoner < 1)
                        {
                            Console.WriteLine("Du måste ange minst en person.");
                        }
                        else if (antalPersoner > 25)
                        {
                            Console.WriteLine("Du kan inte mata in fler än 25 personer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Skriv ett giltigt antal i siffror.");
                        antalPersoner = 0;
                    }
                }

                int totalKostnad = 0;

                for (int i = 1; i <= antalPersoner; i++)
                {
                    int alder = -1;

                    while (alder < 0 || alder > 120)
                    {
                        Console.Write("Ange åldern för person " + i + ": ");

                        if (int.TryParse(Console.ReadLine(), out alder))
                        {
                            if (alder < 0)
                            {
                                Console.WriteLine("Åldern kan inte vara under 0 år.");
                            }
                            else if (alder > 120)
                            {
                                Console.WriteLine("Det går inte att ange en ålder över 120 år.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ange åldern med siffror.");
                            alder = -1;
                        }
                    }

                    int biljettPris;

                    if (alder < 20)
                    {
                        biljettPris = 80;
                        Console.WriteLine("Ungdom: 80 kr");
                    }
                    else if (alder > 64)
                    {
                        biljettPris = 90;
                        Console.WriteLine("Pensionär: 90 kr");
                    }
                    else
                    {
                        biljettPris = 120;
                        Console.WriteLine("Vuxen: 120 kr");
                    }

                    totalKostnad = totalKostnad + biljettPris;
                }

                Console.WriteLine("~~ Sammanfattning ~~");
                Console.WriteLine("\nAntal personer: " + antalPersoner);
                Console.WriteLine("Totalkostnad: " + totalKostnad + " kr");
            }
            else if (val == "2")
            {
                // uppgift 2
                Console.WriteLine("~~ upprepa tio gånger ~~");
                Console.Write("\nSkriv något: ");

                string text = Console.ReadLine() ?? "";

                
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i + ". " + text);
                }
            }
            else if (val == "3")
            {
                // uppgift 3
                Console.WriteLine("~~ Det tredje ordet ~~");

                string[] ord = new string[0];

                
                while (ord.Length < 3)
                {
                    Console.Write("Skriv en mening: ");

                    string mening = Console.ReadLine() ?? "";

                    // Jag delar upp meningen och hoppar över extra mellanslag.
                    ord = mening.Split(
                        ' ',
                        StringSplitOptions.RemoveEmptyEntries
                    );

                    if (ord.Length < 3)
                    {
                        Console.WriteLine("Du behöver skriva minst tre ord.");
                    }
                }

                
                Console.WriteLine("Det tredje ordet är: " + ord[2]);
            }
            else if (val == "0")
            {
                Console.WriteLine("Programmet avslutas. Ha det bra!");

                // Avsluta
                korProgram = false;
            }
            else
            {
                // Felmeddelande
                Console.WriteLine("Det valet finns inte. Försök igen.");
            }
        }
    }
}
