using System;
using System.Collections.Generic;
namespace deckOfCards_C_
{

    public class Deck
    {
        public List<Card> cards;

    public Deck()
        {
        
        }


        public void CheckDeck()
        {
            
            foreach(var i in this.cards)
            {
                Console.WriteLine($"Name: {i.name} Suit: {i.suit} Value: {i.val}");
            }
        }
        
        public void DeckCreator()
        {
            cards = new List<Card>();
            string[] suit = {"Clubs","Diamonds","Hearts","Spades"};
            string [] val = {"1","2","3","4","5","6","7","8","9","10","11","12","13"};
            string[] name = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            for(int i = 0;i < suit.Length;i++)
            {
                for(int x = 0;x < val.Length;x++)
                {
                    cards.Add(new Card(name[x],suit[i],val[x]));
                }
            }
        }


        public Card Draw_one()
        {
            Card card = this.cards[0];
            this.cards.RemoveAt(0);
            return card;
        }

        public void ResetDeck()
        {   
            this.DeckCreator();
        }


        public void Shuffle()
        {
            
            List<Card> ShuffledCards = new List<Card>();
            int count = this.cards.Count;
            while(count > 0)
            {
                count--;
                Random rand = new Random();
                int number = rand.Next(0,count + 1);
                ShuffledCards.Add(this.cards[number]);
                cards.Remove(this.cards[number]);
            }
            this.cards = ShuffledCards;
        }
    }
}