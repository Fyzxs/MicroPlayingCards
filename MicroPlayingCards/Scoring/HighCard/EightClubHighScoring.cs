using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class EightClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public EightClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.Eight)) return Score.EightClubHigh;
            return _next.Scoring(hand);
        }
    }
}