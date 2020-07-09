using System.Collections.Generic;
using ResourceAllocator.Model;

namespace ResourceAllocator.Factory
{
    public class NewYorkTier: TierFactory
    {
        public override Region GetTiers()
        {
            var factory = new List<Tier>
            {
                new LTier(120, 10), 
                new XLTier(230, 20),
                new TwoXLTier(450, 40),
                new FourXLTier(774, 80),
                new EightXLTier(1400, 160),
                new TenXLTier(2820, 320)
            };
            factory.Sort((x, y) => x.RatePerUnit.CompareTo(y.RatePerUnit));
            return new Region
            {
                Name = "New York",
                Tiers = factory
            };
        }
    }
}