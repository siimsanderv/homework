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
            Console.WriteLine("See on kalkulaator, millega saab liita, lahutada, korrutada, jagada ja astendada omavahel 2 arvu. Väljumiseks sisestage 'exit'");
            Console.WriteLine("Komakoha jaoks kasutage punkti '.'\n");
            do //Programm töötab loopina, ehk ei lähe kinni pärast esimest arvutust
            {
                try //Kontrollib, kas programmi töötamise ajal (näiteks, kui kasutaja sisestab midagi) tekib mõni error.
                    // JUURDE ÕPITUD try-catch
                {
                    Console.Write("Sisestage esimene arv: ");
                    string firstInp = Console.ReadLine(); // Kasutaja sisestab arvu või "exit".
                    if (firstInp == "exit") // Kontrollib, kas sisestus on "exit", kui jah, siis programm läheb kinni.
                        break;
                    double firstNum = double.Parse(firstInp); // Muudab sisestuse stringist ujukomaarvuks
                    Console.Write("Sisestage teine arv: "); 
                    string secondInp = Console.ReadLine(); // Kasutaja sisestab arvu või "exit".
                    if (secondInp == "exit") // Kontrollib, kas sisestus on "exit", kui jah, siis programm läheb kinni.
                        break;
                    double secondNum = double.Parse(secondInp); // Muudab sisestuse stringist ujukomaarvuks.
                    Console.Write("Kas soovite arve liita (+), lahutada (-), korrutada (*), jagada (/) või astendada (^): ");
                    string thirdInp = Console.ReadLine(); // Kasutaja sisestab märgi või "exit".
                    if (thirdInp == "exit")  // Kontrollib, kas sisestus on "exit", kui jah, siis programm läheb kinni.
                        break;
                    char opSign = char.Parse(thirdInp); // Muudab sisestuse stringist chariks.
                    switch (opSign) // Kontrollib, mis märgi kasutaja sisestas.
                                    // JUURDE ÕPITUD switch ja case
                    {
                        case '+': // Kui kasutaja sisestas "+", siis programm liidab eelnevalt sisestatud arvud ja näitab tulemust.
                            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}\n");
                            break;
                        case '-': // Kui kasutaja sisestas "-", siis programm lahutab eelnevalt sisestatud arvud ja näitab tulemust.
                            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}\n");
                            break;
                        case '*': // Kui kasutaja sisestas "*", siis programm korrutab eelnevalt sisestatud arvud ja näitab tulemust.
                            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}\n");
                            break;
                        case '/': // Kui kasutaja sisestas "/", siis programm jagab eelnevalt sisestatud arvud ja näitab tulemust.
                            if (double.Parse(secondInp) == 0)
                            {
                                Console.WriteLine("Nulliga ei saa jagada!\n");
                            }
                            else
                                Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}\n");
                            break;
                        case '^': // Kui kasutaja sisestas "^", siis programm astendab eelnevalt sisestatud esimese arvu teise arvuga ja näitab tulemust.
                            if (double.Parse(secondInp) == 0)
                                Console.WriteLine($"{firstNum} ^ {secondNum} = 1\n"); 
                            else
                                Console.WriteLine($"{firstNum} ^ {secondNum} = {Math.Pow(firstNum, secondNum)}\n"); // JUURDE ÕPITUD Math.Pow()
                            break;
                    }
                }
                catch(Exception ex) //Kui programmis tekib error, siis näitab kasutajale allolevat teksti.
                {
                    Console.WriteLine($"{ex}\n");
                    Console.WriteLine("Kasutage ainult arve ja väljumiseks 'exit'.\n");
                }
            }
            while (true); //Programm töötab nii kaua, kuni kasutaja sisestab "exit".
        }   
    }
}
