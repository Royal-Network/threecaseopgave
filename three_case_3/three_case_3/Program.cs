using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace three_case_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //min variabler
           string password, bruger;
            //start af mit program
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Velkommen");
            //her start mit main af mit program menu
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Tryk på en af tasterne [P],[F],[D],[Q]");
            Console.SetCursorPosition(2, 6);
            // hvis du taster P kommer du ind i Password programmet hvis du taster F kommer du ind i Fodbold programet hvis du taster D kommer du ind i Dans programmet og hvis du taster Q slukker du programet
            Console.WriteLine("[P] Password [F] Fodbold [D] Dans [Q] Quit");
            Console.SetCursorPosition(2, 8);
            Console.Write("Indtast dit valg:  ");

            Cho = Console.ReadKey(true);

            if (Cho.key == ConsoleKey.P)
            {
                Console.Clear();

                ConsoleKeyInfo tast;
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("tryk på [O]/[L]");
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("[O] Opret en ny bruger/password [L]Login");
                Console.SetCursorPosition(2, 6);
                Console.WriteLine("Indtast dit valg: ");

                tast = Console.ReadKey(true);

                if (tast.Key == ConsoleKey.O)
                {
                    Console.Clear();

                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("Vælge Brugernavn");
                    bruger = Console.ReadLine();
                    do
                    {
                        Console.SetCursorPosition(2, 3);
                        Console.WriteLine("Vælge Password");


                    }

                }
            }




        }
    }
}
