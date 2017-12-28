using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class KingClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public KingClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.King)) return Score.KingClubHigh;
            return _next.Scoring(hand);
        }
    }
}