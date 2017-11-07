using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_kalkulaator_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See on kalkulaator, millega saab liita, lahutada, korrutada, jagada ja astendada omavahel arve. Väljumiseks sisestage 'exit'");
            Console.WriteLine("Komakoha jaoks kasutage punkti '.'\n");
            do 
            {
                try 
                {
                    Beginning: //kui programmis on goto Beginning;, siis programm tuleb siia, et algusest peale alustada.
                    Console.Write("Mitme arvuga soovite tehet teha: ");
                    var firstInp = Console.ReadLine();
                    if (firstInp == "exit")
                        goto End;
                    int numAmnt = int.Parse(firstInp); //muudab int'iks
                    double[] numList = new double[numAmnt];//loob uue array
                    for (int i = 0; i < numAmnt; i++)
                    {
                        Console.Write($"\nSisestage {i + 1}. arv: ");
                        var secInp = Console.ReadLine(); // var kasutades teeb arvuti kindlaks, kas kasutaja sisestas string, int, double vms. vajalik, et exit sisestades ei tuleks error.
                        if (secInp == "exit")
                            goto End; //kui kasutaja sisestab exit, siis programm liigub label End juurde, et programm sulgeda
                        else
                            numList[i] = double.Parse(secInp);
                    }
                    Console.Write("\nKas soovite arve liita (+), lahutada (-), korrutada (*), jagada (/) või astendada (^): ");
                    string thirdInp = Console.ReadLine();
                    if (thirdInp == "exit") 
                        goto End;
                    char opSign = char.Parse(thirdInp);
                    switch (opSign) 
                    {
                        case '+':
                            double sum = 0;
                            foreach (double i in numList) //liidab kõik arrays olevad liikmed omavahel kokku
                                sum += i;
                            Console.WriteLine($"Vastus on {sum}.\n");
                            break;
                        case '-': //lahutab kõik array liikmed omavahel
                            double sub = numList[0];
                            for (int i = 1; i < numAmnt; i++)
                                sub = sub - numList[i];
                            Console.WriteLine($"Vastus on {sub}.\n");
                            break;
                        case '*': //korrutab kõik array liikmed omavahel
                            double mult = 1;
                            foreach (double i in numList)
                                mult *= i;
                            Console.WriteLine($"Vastus on {mult}.\n");
                            break;
                        case '/': //jagab kõik array liikmed omavahel
                            double div = numList[0];
                            for (int i = 1; i < numAmnt; i++)
                            {
                                if (numList[i] == 0)
                                {
                                    Console.WriteLine("Nulliga ei saa jagada!\n");
                                    goto Beginning;
                                }
                                div = div / numList[i];
                           }

                            Console.WriteLine($"Vastus on {div}.\n");
                            break;
                        case '^'://astendab kõik array liikmed omavahel
                            double pow = numList[0];
                            for (int i = 1; i < numAmnt; i++)
                            {
                                if (numList[i] == 0)
                                    pow = 1;
                                pow = Math.Pow(pow, numList[i]);
                            }
                            Console.WriteLine($"Vastus on {pow}.\n");
                            break;

                    }
                }
                catch (Exception) //Kui programmis tekib error, siis näitab kasutajale allolevat teksti.
                {     
                    Console.WriteLine("Kasutage ainult arve ja väljumiseks 'exit'.\n");
                }
            }
            while (true); //Programm töötab nii kaua, kuni kasutaja sisestab "exit".
            End: //kui programmis on "goto End;", siis ta tuleb siia, et programm sulgeda.
            Console.ReadKey();
        }
    }
}
