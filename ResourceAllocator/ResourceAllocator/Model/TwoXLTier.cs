namespace ResourceAllocator.Model
{
    public class TwoXLTier : Tier
    {
        private readonly string _name;
        private int _quantity;
        private double _rate;
        private double _ratePerUnit;

        public TwoXLTier(double rate, int quantity)
        {
            _name = "2XL";
            _rate = rate;
            _quantity = quantity;
            _ratePerUnit = rate / quantity;
        }

        public override string Name => _name;

        public override int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public override double Rate
        {
            get => _rate;
            set => _rate = value;
        }

        public override double RatePerUnit
        {
            get => _ratePerUnit;
            set => _ratePerUnit = value;
        }
    }
}