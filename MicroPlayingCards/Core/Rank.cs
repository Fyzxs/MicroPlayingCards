using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.Core
{

    public interface IRank
    {
        IValueCompare Compare(IRank other);
        IValueCompare Compare(int other);
    }

    public class Rank : IRank
    {
        private readonly int _rank;
        public static readonly IRank Two = new Rank(2);
        public static readonly IRank Three = new Rank(3);
        public static readonly IRank Four = new Rank(4);
        public static readonly IRank Five = new Rank(5);
        public static readonly IRank Six = new Rank(6);
        public static readonly IRank Seven = new Rank(7);
        public static readonly IRank Eight = new Rank(8);
        public static readonly IRank Nine = new Rank(9);
        public static readonly IRank Ten = new Rank(10);
        public static readonly IRank Jack = new Rank(11);
        public static readonly IRank Queen = new Rank(12);
        public static readonly IRank King = new Rank(13);
        public static readonly IRank Ace = new Rank(14);

        private Rank(int rank) => _rank = rank;

        public IValueCompare Compare(IRank other) => new NegateValueCompare(other.Compare(_rank));

        public IValueCompare Compare(int other)
        {
            //Todo: Chain
            if (_rank < other) return ValueCompare.Lesser;
            if (_rank > other) return ValueCompare.Greater;
            return ValueCompare.Equal;
        }
    }
}