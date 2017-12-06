using MicroPlayingCards.Core;
using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.SuitValueCompares
{
    public class SameSuitValueCompare : ISuitValueCompare
    {
        private readonly ISuitValueCompare _suitValueCompare;

        public SameSuitValueCompare(ISuitValueCompare suitValueCompare) => _suitValueCompare = suitValueCompare;

        public IValueCompare Compare(ISuit champion, ISuit challenger)
        {
            if (champion == challenger) return ValueCompare.Equal;
            return _suitValueCompare.Compare(champion, challenger);
        }
    }
}