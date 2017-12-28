namespace MicroPlayingCards.Core {
    public class Deck : IDeck
    {
        public struct Spades
        {
            public static readonly ICard Ace = new Card(Suit.Spade, Rank.Ace);
            public static readonly ICard King = new Card(Suit.Spade, Rank.King);
            public static readonly ICard Queen = new Card(Suit.Spade, Rank.Queen);
            public static readonly ICard Jack = new Card(Suit.Spade, Rank.Jack);
            public static readonly ICard Ten = new Card(Suit.Spade, Rank.Ten);
            public static readonly ICard Nine = new Card(Suit.Spade, Rank.Nine);
            public static readonly ICard Eight = new Card(Suit.Spade, Rank.Eight);
            public static readonly ICard Seven = new Card(Suit.Spade, Rank.Seven);
            public static readonly ICard Six = new Card(Suit.Spade, Rank.Six);
            public static readonly ICard Five = new Card(Suit.Spade, Rank.Five);
            public static readonly ICard Four = new Card(Suit.Spade, Rank.Four);
            public static readonly ICard Three = new Card(Suit.Spade, Rank.Three);
            public static readonly ICard Two = new Card(Suit.Spade, Rank.Two);
        }

        public struct Hearts
        {
            public static readonly ICard Ace = new Card(Suit.Heart, Rank.Ace);
            public static readonly ICard King = new Card(Suit.Heart, Rank.King);
            public static readonly ICard Queen = new Card(Suit.Heart, Rank.Queen);
            public static readonly ICard Jack = new Card(Suit.Heart, Rank.Jack);
            public static readonly ICard Ten = new Card(Suit.Heart, Rank.Ten);
            public static readonly ICard Nine = new Card(Suit.Heart, Rank.Nine);
            public static readonly ICard Eight = new Card(Suit.Heart, Rank.Eight);
            public static readonly ICard Seven = new Card(Suit.Heart, Rank.Seven);
            public static readonly ICard Six = new Card(Suit.Heart, Rank.Six);
            public static readonly ICard Five = new Card(Suit.Heart, Rank.Five);
            public static readonly ICard Four = new Card(Suit.Heart, Rank.Four);
            public static readonly ICard Three = new Card(Suit.Heart, Rank.Three);
            public static readonly ICard Two = new Card(Suit.Heart, Rank.Two);
        }

        public struct Clubs
        {
            public static readonly ICard Ace = new Card(Suit.Club, Rank.Ace);
            public static readonly ICard King = new Card(Suit.Club, Rank.King);
            public static readonly ICard Queen = new Card(Suit.Club, Rank.Queen);
            public static readonly ICard Jack = new Card(Suit.Club, Rank.Jack);
            public static readonly ICard Ten = new Card(Suit.Club, Rank.Ten);
            public static readonly ICard Nine = new Card(Suit.Club, Rank.Nine);
            public static readonly ICard Eight = new Card(Suit.Club, Rank.Eight);
            public static readonly ICard Seven = new Card(Suit.Club, Rank.Seven);
            public static readonly ICard Six = new Card(Suit.Club, Rank.Six);
            public static readonly ICard Five = new Card(Suit.Club, Rank.Five);
            public static readonly ICard Four = new Card(Suit.Club, Rank.Four);
            public static readonly ICard Three = new Card(Suit.Club, Rank.Three);
            public static readonly ICard Two = new Card(Suit.Club, Rank.Two);
        }

        public struct Diamonds
        {
            public static readonly ICard Ace = new Card(Suit.Diamond, Rank.Ace);
            public static readonly ICard King = new Card(Suit.Diamond, Rank.King);
            public static readonly ICard Queen = new Card(Suit.Diamond, Rank.Queen);
            public static readonly ICard Jack = new Card(Suit.Diamond, Rank.Jack);
            public static readonly ICard Ten = new Card(Suit.Diamond, Rank.Ten);
            public static readonly ICard Nine = new Card(Suit.Diamond, Rank.Nine);
            public static readonly ICard Eight = new Card(Suit.Diamond, Rank.Eight);
            public static readonly ICard Seven = new Card(Suit.Diamond, Rank.Seven);
            public static readonly ICard Six = new Card(Suit.Diamond, Rank.Six);
            public static readonly ICard Five = new Card(Suit.Diamond, Rank.Five);
            public static readonly ICard Four = new Card(Suit.Diamond, Rank.Four);
            public static readonly ICard Three = new Card(Suit.Diamond, Rank.Three);
            public static readonly ICard Two = new Card(Suit.Diamond, Rank.Two);
        }
    }
}