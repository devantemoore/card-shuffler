using System;
using System.Collections.Generic;

namespace CardShuffler
{
    public class PlayingCard
    {
        public PlayingCard(Rank rank)
        {
            Rank = rank;
        }
        public PlayingCard(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
        public Suit? Suit { get; set; }
        public Rank Rank { get; set; }
        public static IList<PlayingCard> LoadDeck()
        {
            var deck = new List<PlayingCard>();
            foreach(var _suit in Enum.GetValues<Suit>())
            {
                foreach(var _rank in Enum.GetValues<Rank>())
                {
                    if (_rank == Rank.BigJoker || _rank == Rank.LittleJoker) continue;
                    deck.Add(new PlayingCard(_suit, _rank));
                }
            }
            deck.AddRange(new[] { new PlayingCard(Rank.LittleJoker), new PlayingCard(Rank.BigJoker) });
            return deck;
        }
    }
    public enum Rank
    {
        BigJoker,
        LittleJoker,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five,
        Four,
        Three,
        Two,
        Ace
    }
    public enum Suit
    {
        Spade,
        Diamond,
        Club,
        Heart
    }
}
