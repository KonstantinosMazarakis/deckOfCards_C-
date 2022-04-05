using System;
using System.Collections.Generic;
namespace deckOfCards_C_
{

    public class Player
    {
        public string name;
        public List<Card> hand;


    public Player(string n)
        {
            name = n;
            hand = new List<Card>();
        }



        public void CheckPlayer()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine("HAND: ");
            foreach(var i in this.hand)
            { 
            Console.WriteLine($"Name: {i.name} Suit: {i.suit} Value: {i.val}");
            }
            Console.WriteLine("--------------");
        }


        public Card PlayerDraw(Deck deck)
        {
            Card card = deck.Draw_one();
            hand.Add(card);
            return card;
        }


        public Card Discard(int num)
        {
            if(num > this.hand.Count)
            {
                Console.WriteLine("You dont have that many cards in hand");
                return null;
            }else
            {
                Card card = this.hand[num]; 
                this.hand.RemoveAt(num);
                return card;
            }
        }


    }





}