using System;
namespace deckOfCards_C_
{

    public class Card
    {
        public string name;
        public string suit;
        public string val;

    public Card(string n, string s, string v)
        {
            name = n;
            suit = s;
            val = v;
        }



        public void CheckCard()
        {
            Console.WriteLine($"Name: {this.name} Suit: {this.suit} Value: {this.val}");
        }
    }





}