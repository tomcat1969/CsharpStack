using System;
using System.Collections.Generic;
namespace BlackJack
{
    public class Player
    {
        public string Name;
        public List<Card> Hand = new List<Card>();
        public int score;
        public bool bust = false;


        public Card draw(Deck deck)
        {
            Card myCard = deck.DealCard();
            this.Hand.Add(myCard);
            Console.WriteLine($"{this.Name} draw a Card...");
            this.CalculateScore();
            this.checkIfBust();
            this.showCards();
            return myCard;
        }

        public Player(string name)
        {
            this.Name = name;
            
        }

        public void showCards() {
            this.CalculateScore();
            Console.WriteLine($"********** {this.Name} has Cards on hand *** current score : {this.score} ************");
            int count = 0;
            foreach (Card ele in this.Hand)
            {   if(count % 4 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{ele,-19}");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine($"************************************************************************");
        }

        public void  CalculateScore()
        {
            int how_many_Ace = 0;
            int score_min = 0;
            foreach(Card ele in this.Hand)
            {
                if(ele.Val == 1)
                {
                    how_many_Ace++;
                }
                score_min += ele.Val;
            }
      
            for (int i = 0; i < how_many_Ace; i++)
            {
                if(score_min + 10 <= 21)
                {
                    score_min += 10;
                }
            }

            this.score = score_min;  
            
        }

        public void autoReact(Deck deck)
        {
            if(this.score < 16)
            {
                this.draw(deck);
                Console.WriteLine($"{this.Name} choose to hit!");
            }
            else
            {
                Console.WriteLine($"{this.Name} choose to stand !");
            }
            this.checkIfBust(); 
        }
        public void checkIfBust()
        {
            if(this.score > 21)
            {
                this.bust = true;
                Console.WriteLine($"my god! {this.Name} is bust !");
            }
        }
    }
}
