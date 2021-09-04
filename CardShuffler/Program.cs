using System;

namespace CardShuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = PlayingCard.LoadDeck();
            var deck2 = CardShuffler<PlayingCard>.Shuffle(deck);
            var deck3 = CardShuffler<PlayingCard>.Shuffle(deck2);
            var deck4 = CardShuffler<PlayingCard>.Shuffle(deck3);
            foreach(var card in deck4)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
    }
}
