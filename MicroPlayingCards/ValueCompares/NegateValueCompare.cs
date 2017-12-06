namespace MicroPlayingCards.ValueCompares {
    public class NegateValueCompare : IValueCompare
    {
        private readonly IValueCompare _origin;

        public NegateValueCompare(IValueCompare origin) => _origin = origin;

        public bool IsEqual() => _origin.IsEqual();

        public bool IsLesser() => !_origin.IsLesser();
        public bool IsGreater() => !_origin.IsGreater();
    }
}