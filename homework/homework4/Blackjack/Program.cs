using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    class Program
    {

        // All aces are 11 points. In real life, one can choose whether it is 1 or 11
        // When user draws a card, house always draws one as-well. In real life, house can decide based on some rules...  

        static Deck deck;
        static List<Card> userHand;
        static List<Card> dealerHand;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            deck = new Deck(); //genereerib uue kaardipaki
            deck.Shuffle(); //segab kaardipaki
            DealHand(); //alustab mängu
            Console.ReadKey();
        }

        static void DealHand()
        {
            Console.WriteLine();

            userHand = new List<Card>();
            userHand.Add(deck.DrawACard()); //Annab mängijale esimesed
            userHand.Add(deck.DrawACard()); //2 kaarti

            foreach (Card card in userHand) //kui mängija kaartide hulgas on äss, siis saab väärtuseks 11
            {
                if (card.Face == Face.Ace)
                {
                    card.Value = 11;
                    break;
                }
            }
            Console.WriteLine($"You have been dealt: {userHand[0].Face} {userHand[0].Suit}, {userHand[1].Face} {userHand[1].Suit}");

            dealerHand = new List<Card>();
            dealerHand.Add(deck.DrawACard()); //Annab diilerile esimesed
            dealerHand.Add(deck.DrawACard()); //2 kaarti

            foreach (Card card in dealerHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value = 11;
                    break;
                }
            }

            Console.WriteLine($"House has been dealt: {dealerHand[0].Face} {dealerHand[0].Suit}, [?]\n");



            if (userHand[0].Value + userHand[1].Value == 21) //kui mängija kaartide väärtus on esimese 2 kaardiga 21, siis ta on võitnud
            {
                Console.WriteLine("Blackjack, You Win!\n");
                return;
            }

            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish\n");
                Console.Write("I choose: ");
                int userChoice = int.Parse(Console.ReadLine());
                while (userChoice != 2 && userChoice != 1) //kui kasutaja sisestab vale sisendi, siis hoiatab sellest ja küsib uuesti sisendit
                {
                    Console.WriteLine("Illegal key. Please choose a valid option: [1 - Hit | 2 - Stand]");
                    userChoice = char.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                switch (userChoice)
                {
                    case 1: //kasutaja tahab jätkata ja talle ning diilerile jagatakse veel 1 kaart
                        userHand.Add(deck.DrawACard());
                        Console.WriteLine($"\nYou have been dealt: {userHand[userHand.Count - 1].Face} {userHand[userHand.Count - 1].Suit}");
                        int totalCardsValue = 0;
                        foreach (Card card in userHand)
                        {
                            totalCardsValue += card.Value;
                        }
                        dealerHand.Add(deck.DrawACard());
                        Console.WriteLine($"Dealer has been dealt: [?]\n");
                        if (totalCardsValue > 21)
                        {
                            Console.Write("You have busted!\n");
                            return;
                        }
                        else if (totalCardsValue == 21)
                        {
                            Console.WriteLine("You hit 21!");
                            continue;
                        }
                        else
                        {
                            continue;
                        }

                    case 2:
                        int playerCardsValue = 0;
                        int dealerCardsValue = 0;
                        foreach (Card card in userHand) //arvutab kokku mängija kaartide väärtuse
                        {
                            playerCardsValue += card.Value;
                        }
                        foreach (Card card in dealerHand) //arvutab kokku diileri kaartide väärtuse
                        {
                            dealerCardsValue += card.Value;
                        }
                        Console.WriteLine($"\nYou have {playerCardsValue} points vs. house {dealerCardsValue} points.");
                        if(dealerCardsValue > 21)
                            Console.WriteLine("You win!");
                        else if(playerCardsValue > dealerCardsValue)
                            Console.WriteLine("You win!");
                        else if(playerCardsValue < dealerCardsValue)
                            Console.WriteLine("House wins!");
                        else if(playerCardsValue == dealerCardsValue)
                            Console.WriteLine("Tie!");
                        return;

                    default:
                        break;
                }

                Console.ReadLine();
            }
            while (true);
        }
    }
}
