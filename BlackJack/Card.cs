using System;
namespace BlackJack
{
    public class Card
    {
        private string StringVal { get; }
        private string Suit { get; }
        public int Val;


        public Card(string stringVal,string suit,int val)
        {
            this.StringVal = stringVal;
            this.Suit = suit;
            this.Val = val;
        }

        public override string ToString()
        {
            return $"{StringVal} of {Suit}";
        }
    }
}
