using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_kalkulaator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See on kalkulaator, millega saab liita, lahutada, korrutada ja jagada omavahel 2 arvu. Väljumiseks sisestage 'exit'");
            Console.WriteLine("Komakoha jaoks kasutage '.'");
            try
            {
                do
                {
                    Console.Write("\nSisestage esimene arv: ");
                    string firstInp = Console.ReadLine();
                    if (firstInp == "exit")
                        break;
                    double firstNum = double.Parse(firstInp);
                    Console.Write("Sisestage teine arv: ");
                    string secondInp = Console.ReadLine();
                    if (secondInp == "exit")
                        break;
                    double secondNum = double.Parse(secondInp);
                    Console.Write("Kas soovite arve liita (+), lahutada (-), korrutada (*) või jagada (/): ");
                    string thirdInp = Console.ReadLine();
                    if (thirdInp == "exit")
                        break;
                    char opSign = char.Parse(thirdInp);
                    switch (opSign)
                    {
                        case '+':
                            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}\n");
                            break;
                        case '-':
                            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}\n");
                            break;
                        case '*':
                            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}\n");
                            break;
                        case '/':
                            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}\n");
                            break;
                    }
                }
                while (true);
            }
            catch(Exception)
            {
                Console.WriteLine("Kasutage ainult arve ja väljumiseks 'exit'.");
            }
        }   
    }
}
