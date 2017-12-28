using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class AceClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public AceClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.Ace)) return Score.AceClubHigh;
            return _next.Scoring(hand);
        }
    }
}