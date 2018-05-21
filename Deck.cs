using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards;
        
        
        public Card Deal()
        {
            if (cards.Count > 0)
            {
                Card topCard = cards[0];
                cards.Remove(topCard);
                return topCard;
            }
            else 
            {
                Console.WriteLine("No more cards; reshuffling the deck!");
                Reset();
                Shuffle();
                return Deal();
            }
        }
        public void DisplayDeck()
        {
            foreach (var card in cards)
            {
                Console.WriteLine("{0} of {1}", card.stringVal, card.suit);
            }
            Console.WriteLine("Remaining cards in deck: {0}!", cards.Count);
        }
         public List<Card> Reset()
        {
            cards = new List<Card>();
            string[] suits = new string[4] {"Clubs", "Spades", "Hearts", "Diamonds"};
            foreach (string suit in suits)
            {
                for(int i = 1; i <= 13; i++)
                {
                    Card uniqueCard = new Card(suit, i);
                    cards.Add(uniqueCard);
                }
            }
            return cards;
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int idx=0; idx < cards.Count-1; idx++)
            {
                int randIdx = rand.Next(idx+1, cards.Count-1);
                Card temp = cards[idx];
                cards[idx] = cards[randIdx];
                cards[randIdx] = temp;
            }
        }
        
        public Deck()
        {
            Reset();
            Shuffle();
        }
    }
}