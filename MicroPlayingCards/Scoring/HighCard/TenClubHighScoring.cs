using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class TenClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public TenClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.Ten)) return Score.TenClubHigh;
            return _next.Scoring(hand);
        }
    }
}