using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck playDeck = new Deck();
            Player player1 = new Player("Mister Man");
            playDeck.DisplayDeck();
        }
    }
}
