using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class JackClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public JackClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.Jack)) return Score.JackClubHigh;
            return _next.Scoring(hand);
        }
    }
}