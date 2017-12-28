using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class SevenClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public SevenClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.Seven)) return Score.SevenClubHigh;
            return _next.Scoring(hand);
        }
    }
}