namespace MicroPlayingCards.ValueCompares {
    public interface IValueCompare
    {
        bool IsEqual();
        bool IsLesser();
        bool IsGreater();
    }
}