using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static Random rnd = new Random();
        static List<string> words = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Arvuti on valinud ühe sõna, arva see tähthaaval ära vähem kui 5 eksimusega");
            Console.WriteLine("Väljumiseks sisesta \"exit\"");
            Words();
            HangmanPlay();
        }

        static void Words()
        {
            words.AddRange(new string[] { "ILVES", "HUNT", "KALA", "KARU", "AHV" });
        }

        static void HangmanPlay()
        {
            string word = words[rnd.Next(words.Count)].ToUpper(); //loob stringi ja lisab sinna loomade listist ühe suvalise looma
            char[] letters = word.ToCharArray(); //loob array, mis koosneb looma stringi tähtedest
            char[] board = new string('_', word.Length).ToCharArray(); //loob char array, mis koosneb nii palju "_"'dest, kui neid on looma nimes
            int wrongTries = 0;

            string letterChoice = "";
            while (letterChoice != "EXIT" && wrongTries < 5) //programm töötab kuni inimene ei soovi väljuda ja arvatud tähtede arv on alla 5
            {
                string boardStr = new string(board);
                if (boardStr == word) //suleb programmi, kui inimene arvab sõna õigesti
                {
                    Console.WriteLine("Arvasid sõna õigesti!");
                    break;
                }
                DisplayBoard(board);
                Console.Write("Paku: ");

                letterChoice = Console.ReadLine().Trim().ToUpper(); //eemaldab kasutaja pakutust tähest whitespace ja muudab väikesed tähed suurteks
                if (letterChoice != "EXIT" && wrongTries < 5) //kui kasutaja ei sisesta exit või arvamiste arv on alla 5, siis lisab õige arvamise korral tähe oma kohale "_" asemele
                {
                    char letter = letterChoice.ToCharArray()[0];
                    letterChoice = letterChoice.Substring(0, 1);
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (letters[i] == letter)
                        {
                            board[i] = letter;
                        }
                        else if (letters[i] != letter)
                            wrongTries++;
                        Console.WriteLine(wrongTries);
                    }
                }

            }
            if (letterChoice != "EXIT")
            {
                DisplayBoard(board);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void DisplayBoard(char[] board)
        {
            string boardStr = new string(board);
            Console.WriteLine("");
            Console.WriteLine(boardStr);
            Console.WriteLine("");
        }

    }
}
