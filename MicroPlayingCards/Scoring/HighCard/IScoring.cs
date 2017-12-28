using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard
{
    public interface IScoring
    {
        IScore Scoring(IHand hand);
    }
}