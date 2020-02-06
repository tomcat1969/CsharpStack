using System;
using System.Collections.Generic;
namespace BlackJack
{
    public class Deck
    {
        

        private static Random r = new Random();
        private const int NumberOfCards = 52;
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0;





        public Deck()
        {
            string[] faces = {"Ace", "2", "3", "4", "5", "6",
                         "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            for (var i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(faces[i % 13], suits[i / 13],i % 13 + 1);
            }
            for (var i = 0; i < deck.Length; i++)
            {
                if (deck[i].Val > 10)
                {
                    deck[i].Val = 10;
                }
            }
            this.Shuffle();

        }

        public void Shuffle()
        {
            currentCard = 0; //reinitialize
            for (var i = 0; i < deck.Length; i++)
            {
                var pickOne = r.Next(NumberOfCards);
                Card temp = deck[i];
                deck[i] = deck[pickOne];
                deck[pickOne] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }

        public void showDeck()
        {
            Console.WriteLine("************** Cards On the Deck****************");
            for (int i = 0; i < NumberOfCards; i++)
            {   if(i % 4 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{ this.deck[i],-19}");
            }
            Console.WriteLine();
            Console.WriteLine("************************************************");
        }
    }
}
