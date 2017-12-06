using MicroPlayingCards.Core;
using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.SuitValueCompares
{
    public interface ISuitValueCompare
    {
        IValueCompare Compare(ISuit champion, ISuit challenger);
    }
}