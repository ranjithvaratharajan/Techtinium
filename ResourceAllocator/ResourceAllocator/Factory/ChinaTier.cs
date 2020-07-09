using System.Collections.Generic;
using ResourceAllocator.Model;

namespace ResourceAllocator.Factory
{
    public class ChinaTier : TierFactory
    {
        public override Region GetTiers()
        {
            var factory = new List<Tier>
            {
                new LTier(110, 10),
                new XLTier(200, 20),
                new TwoXLTier(-1, 40),
                new FourXLTier(670, 80),
                new EightXLTier(1180, 160),
                new TenXLTier(-1, 320)
            };
            factory.Sort((x, y) => x.RatePerUnit.CompareTo(y.RatePerUnit));
            return new Region
            {
                Name = "China",
                Tiers = factory
            };
        }
    }
}