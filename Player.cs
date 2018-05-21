using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player 
    {
        public Player(string playerName)
        {
            name = playerName;
        }
        public string name;
        public List<Card> hand = new List<Card>();
        public Card DrawCard(Deck playDeck)
        {
            Card drawCard = playDeck.Deal();
            hand.Add(drawCard);
            return drawCard;
        }
        public Card DiscardCard(int idx)
        {
            if (hand.Count > 0 && idx < hand.Count)
            {
                Card discCard = hand[idx];
                hand.RemoveAt(idx);
                return discCard; 
            }
            else
            {
                Console.WriteLine("That isn't possible right now.");
                return null;
            }
        }
        public void DisplayPlayerHand()
        {
            foreach (Card card in hand)
            {
                Console.WriteLine("{0} of {1}!", card.stringVal, card.suit);
            }
            Console.WriteLine("Total cards in hand: {0}!", hand.Count);
        }
    }
}