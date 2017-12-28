using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class NineClubHighScoring : IScoring
    {
        private readonly IScoring _next;
        public NineClubHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Clubs.Nine)) return Score.NineClubHigh;
            return _next.Scoring(hand);
        }
    }
}