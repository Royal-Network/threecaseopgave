using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace three_case_3
{
    internal class ProgramBase
    {
        public static void Main(string[] args)
        {
            bool backtop = true;
            while (backtop)

            {
                //min variabler
                string password, bruger;
                //consolekeyinfo gør så du ikke behøver at skal trykke på den samme tast flere gang
                ConsoleKeyInfo Cho;

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

                if (Cho.Key == ConsoleKey.P)
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
                        Console.WriteLine("Vælge Brugernavn:   ");
                        bruger = Console.ReadLine();
                        do
                        {
                            Console.SetCursorPosition(2, 3);
                            Console.WriteLine("Vælge Password:   ");
                            Console.SetCursorPosition(2, 4);
                            Console.WriteLine("Husk at Password skal havde både stor og små bogstaver i sig");
                            Console.SetCursorPosition(2, 5);
                            Console.WriteLine("Huske password ikke må slutte på bogstaver");
                            Console.SetCursorPosition(2, 6);
                            Console.WriteLine("password skal også have Speciale tegn i sig");
                            Console.SetCursorPosition(2, 7);
                            Console.WriteLine("Der må ikke være tal i starten eller i slutning af password");
                            Console.SetCursorPosition(2, 8);
                            Console.WriteLine("Må ikke indeholde mellemrum");
                            Console.SetCursorPosition(15, 3);
                            password = Console.ReadLine();
                            Passmust mr_jasper = new Passmust(password, "");

                            var display = mr_jasper.passwordmust(password,
                                "");
                            Console.WriteLine(display);
                            //hvis passwordet opfylder ovennævnte krav,så brugernavnet og passwordet bliver skrevet ind i min .txt fil med alle data'er.
                            string[] lines1 = System.IO.File.ReadAllLines("C:\\Users\\renhan\\Desktop\\Code.pass.txt");
                            string[] lines = new string[] { "1a", "2b", "3c" };

                            foreach (var line in lines1)
                            {
                                if (password != line)
                                {

                                }
                            }

                            if (password.Length >= 12 && password != display && password != lines1[lines1.Length - 1])
                            {
                                using (StreamWriter sw = new StreamWriter(File.Create("C:\\Users\\renhan\\Desktop\\Code.pass.txt")))
                                {
                                    sw.WriteLine(bruger);
                                    sw.WriteLine(password);
                                    sw.Close();
                                }
                                Console.Clear();
                                Console.WriteLine("Your password and username is created successfully!!!");
                                Console.ReadKey();
                            }
                            if (password == display)
                            {
                                Console.WriteLine("fejl");
                                Console.ReadKey();
                            }
                            //else
                            //{
                            //    Console.WriteLine("fejl");
                            //    Console.ReadKey();
                            //}

                        }
                        while (password == "");

                    }
                }

            }
        }
    }

    internal class Passmust
    {
        private string password;
        private string v;

        public Passmust(string password, string v)
        {
            this.password = password;
            this.v = v;
        }
    }
}
