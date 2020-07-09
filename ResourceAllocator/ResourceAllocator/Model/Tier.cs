namespace ResourceAllocator.Model
{
    public abstract class Tier
    {
        public abstract string Name { get; }
        public abstract int Quantity { get; set; }
        public abstract double Rate { get; set; }
        public abstract double RatePerUnit { get; set; }
    }
}