using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        { 
            // All aces are 11 points. In real life, one can choose whether it is 1 or 11
            // When user draws a card, house always draws one as-well. In real life, house can decide based on some rules...  

            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();
            string[] Suit = new string[] { "S", "D", "H", "C" }; //list of card suits
            Random rnd = new Random();
            int[] playerRank = new int[10]; //empty list of player's cards, which gets value of 1-13 at line 30
            int[] dealerRank = new int[10]; //empty list of dealer's cards, which gets value of 1-13 at line 31
            string[] playerCardRank = new string[10]; //list that contains actual rank of player's cards (2-10,j,q,k,a)
            string[] dealerCardRank = new string[10]; //list that contains actual rank of dealer's cards (2-10,j,q,k,a)

            int index = 0;
            int playerSum = 0; //sum of player's card values
            int dealerSum = 0; //sum of dealer's card values
            int playerCardVal = 0; //actual value of player's card (2-10; j,q,k=10;a=1 or 10)
            int dealerCardVal = 0; //actualy value of dealer's card (2-10; j,q,k=10;a=1 or 10)
            for (int i = 0; i < 2; i++)
            {
                playerRank[i] = rnd.Next(1, 14);
                dealerRank[i] = rnd.Next(1, 14);
                if (playerRank[i] == 1)
                {
                    playerCardRank[i] = "A";
                    playerCardVal = 11;
                }
                else if (playerRank[i] < 10)
                {
                    playerCardVal = playerRank[i];
                    playerCardRank[i] = $"{playerRank[i]}";
                }
                else if (playerRank[i] >= 10)
                {
                    playerCardVal = 10;
                    switch(playerRank[i])
                    {
                        case 10:
                            {
                                playerCardRank[i] = "10";
                                break;
                            }
                        case 11:
                            {
                                playerCardRank[i] = "J";
                                break;
                            }
                        case 12:
                            {
                                playerCardRank[i] = "Q";
                                break;
                            }
                        case 13:
                            {
                                playerCardRank[i] = "K";
                                break;
                            }
                    }
                }
                if (dealerRank[i]==1)
                {
                    dealerCardRank[i] = "A";
                    dealerCardVal = 11;
                }
                else if (dealerRank[i] < 10)
                {
                    dealerCardVal = dealerRank[i];
                    dealerCardRank[i] = $"{dealerRank[i]}";
                }
                else if (dealerRank[i] >= 10)
                {
                    dealerCardVal = 10;
                    switch (dealerRank[i])
                    { 
                        case 10:
                        {
                            dealerCardRank[i] = "10";
                            break;
                        }
                        case 11:
                            {
                                dealerCardRank[i] = "J";
                                break;
                            }
                        case 12:
                            {
                                dealerCardRank[i] = "Q";
                                break;
                            }
                        case 13:
                            {
                                dealerCardRank[i] = "K";
                                break;
                            }
                    }
                }
                playerSum += playerCardVal;
                dealerSum += dealerCardVal;
            }
            

            Console.WriteLine($"You have been dealt: {playerCardRank[0]}{Suit[rnd.Next(0,4)]},{playerCardRank[1]}{Suit[rnd.Next(0, 4)]}");
            Console.WriteLine($"House has been dealt: {dealerCardRank[0]}{Suit[rnd.Next(0, 4)]},[?]");
            while(true)
            {
                if (playerSum == 21)
                {
                    Console.WriteLine($"You have {playerSum} points vs. house {dealerSum} points");
                    Console.WriteLine("You win!");
                    break;
                }
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");
                Console.Write("I choose: ");
                string answer = Console.ReadLine();
                if(answer == "1")
                {
                    playerRank[index] = rnd.Next(1, 14);
                    dealerRank[index] = rnd.Next(1, 14);
                    if (playerRank[index] == 1)
                    {
                        playerCardRank[index] = "A";
                        playerCardVal = 11;
                    }
                    else if (playerRank[index] < 10)
                    {
                        playerCardVal = playerRank[index];
                        playerCardRank[index] = $"{playerRank[index]}";
                    }
                    else if (playerRank[index] >= 10)
                    {
                        playerCardVal = 10;
                        switch (playerRank[index])
                        {
                            case 10:
                                {
                                    playerCardRank[index] = "10";
                                    break;
                                }
                            case 11:
                                {
                                    playerCardRank[index] = "J";
                                    break;
                                }
                            case 12:
                                {
                                    playerCardRank[index] = "Q";
                                    break;
                                }
                            case 13:
                                {
                                    playerCardRank[index] = "K";
                                    break;
                                }
                        }
                    }
                    if (dealerRank[index] == 1)
                    {
                        dealerCardVal = 11;
                    }
                    else if (dealerRank[index] < 10)
                    {
                        dealerCardVal = dealerRank[index];
                    }
                    else if (dealerRank[index] >= 10)
                    {
                        dealerCardVal = 10;
                    }
                    playerSum += playerCardVal;
                    dealerSum += dealerCardVal;
                    Console.WriteLine($"You have been dealt: {playerCardRank[index]}{Suit[rnd.Next(0,4)]}");
                    Console.WriteLine("House has been dealt: [?]");
                    Console.WriteLine();
                    if (playerSum == 21)
                    {
                    Console.WriteLine($"You have {playerSum} points vs. house {dealerSum} points");
                    Console.WriteLine("You win!");
                    break;
                    }
                    else if(playerSum>21)
                    {
                        Console.WriteLine($"You have {playerSum} points vs. house {dealerSum} points");
                        Console.WriteLine("House wins!");
                        break;
                    }

                }
                else if(answer == "2")
                {
                    Console.WriteLine($"You have {playerSum} points vs. house {dealerSum} points");
                    if(dealerSum > playerSum && dealerSum <= 21 || playerSum > 21)
                    {
                        Console.WriteLine("House wins!");
                        break;
                    }
                    else if(playerSum > dealerSum && playerSum <= 21 || dealerSum > 21)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                    else if(playerSum == dealerSum)
                    {
                        Console.WriteLine("Tie!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                index++;
            }
            Console.ReadKey();
        }
    }
}
