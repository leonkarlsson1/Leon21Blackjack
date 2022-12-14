using System;
namespace BlackJack_21
{
    class program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            string senasteVinnaren = "Ingen vinnare ännu";

            Console.WriteLine("Välkommen till backJack");

            string menyVal = "0";
            while (menyVal != "4")
            {

                Console.WriteLine("Välj ett av de 4 alternativen");
                Console.WriteLine("1. Spela Backjack(21)");
                Console.WriteLine("2. Senatse vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta spelet");
                menyVal = Console.ReadLine();

                Console.WriteLine();

                switch (menyVal)
                {

                    case "1":
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        Console.WriteLine("Två kort per spelare kommer dras");
                        datornsPoäng += slump.Next(1, 11);
                        datornsPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);


                        string kortVal = "";
                        while (kortVal != "Nej" && spelarensPoäng <= 21)
                        {
                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                            Console.WriteLine("Vill du ta ett till kort (Ja/Nej)");
                            kortVal = Console.ReadLine();

                            switch (kortVal)
                            {
                                case "Ja":
                                    int nyPoäng = slump.Next(1, 11);
                                    spelarensPoäng += nyPoäng;
                                    Console.WriteLine($"ditt kort är värt {nyPoäng} poäng");
                                    Console.WriteLine($"totalpoäng är {spelarensPoäng}");
                                    break;

                                case "Nej":
                                    break;

                                default:
                                    Console.WriteLine("Detta valet finns inte");
                                    break;
                            }

                        }


                        if (spelarensPoäng > 21)
                        {
                            Console.WriteLine("Du fick mer än 21 och bustade");
                            break;
                        }


                        while (datornsPoäng < spelarensPoäng && datornsPoäng <= 21)
                        {
                            int datornsNyaPoäng = slump.Next(1, 12);
                            datornsPoäng += datornsNyaPoäng;
                            Console.WriteLine($"datorns kort är värt{datornsNyaPoäng}");
                        }

                        Console.WriteLine($"din poäng: {spelarensPoäng}");
                        Console.WriteLine($"datorns poäng: {datornsPoäng}");


                        if (datornsPoäng > 21)
                        {
                            Console.WriteLine("Grattis du Vann");
                            Console.WriteLine("Skriv in ditt namn");
                            senasteVinnaren = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Datorn vann");
                        }

                        break;


                    case "2":
                        Console.WriteLine($"Senaste vinnaren: {senasteVinnaren}");
                        break;


                   
                    case "3":
                        string text = "Ditt mål är att tvinga datorn att få mer än 21 poäng.";
                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text2 = "Du får poäng genom att dra kort, varje kort har 1-10 poäng.";
                        foreach (char e in text2)
                        {
                            Console.Write(e);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text3 = "Om du får mer än 21 poäng har du förlorat.";
                        foreach (char f in text3)
                        {
                            Console.Write(f);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text4 = "Både du och datorn får två kort i början. Du ska dra kort till du är nöjd eller får över 21.";
                        foreach (char g in text4)
                        {
                            Console.Write(g);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text5 = "När du är färdig drar datorn kort till den har mer poäng än dig eller över 21 poäng.";
                        foreach (char h in text5)
                        {
                            Console.Write(h);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");
                        string text6 = "Ditt mål är att tvinga datorn att få mer än 21 poäng.";
                        foreach (char i in text6)
                        {
                            Console.Write(i);
                            Thread.Sleep(20);
                        }
                        break;

                        break;


                    case "4":
                        break;

                    default:
                        Console.WriteLine("Detta valet finns inte");
                        break;
                }


                Console.WriteLine();
            }



        }
    }
}