using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class NineDiamondHighScoring : IScoring
    {
        private readonly IScoring _next;
        public NineDiamondHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Diamonds.Nine)) return Score.NineDiamondHigh;
            return _next.Scoring(hand);
        }
    }
}