namespace MicroPlayingCards.Core {
    public interface IHand
    {
        IScore HandScore();
        bool HasCard(ICard card);
    }
}