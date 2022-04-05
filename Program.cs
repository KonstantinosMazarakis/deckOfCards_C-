using System;

namespace deckOfCards_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card v = new Card("2","spades","2");
            // v.ChackCard();
            Deck deck = new Deck();
            deck.DeckCreator();
            deck.Draw_one();
            deck.ResetDeck();
            deck.Shuffle();
            deck.CheckDeck();
            Player Kostas = new Player("Kostas");
            Kostas.PlayerDraw(deck);
            Kostas.PlayerDraw(deck);
            Kostas.PlayerDraw(deck);
            Kostas.CheckPlayer();
            Kostas.Discard(1);
            Kostas.CheckPlayer();
        }
    }
}
