using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class QueenClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public QueenClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.Queen)) return Score.QueenClubHigh;
            return _next.Scoring(hand);
        }
    }
}