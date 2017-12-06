namespace MicroPlayingCards.ValueCompares
{
    public class ValueCompare : IValueCompare
    {
        public static readonly IValueCompare Equal = new ValueCompare(true, false);
        public static readonly IValueCompare Greater = new ValueCompare(false, false);
        public static readonly IValueCompare Lesser = new ValueCompare(false, true);

        private readonly bool _equal;
        private readonly bool _lesser;

        private ValueCompare(bool equal, bool lesser)
        {
            _equal = equal;
            _lesser = lesser;
        }

        public bool IsEqual() => _equal;
        public bool IsLesser() => _lesser;
        public bool IsGreater() => !(IsLesser() || IsEqual());
    }
}