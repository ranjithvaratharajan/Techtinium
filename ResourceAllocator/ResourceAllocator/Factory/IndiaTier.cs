using System.Collections.Generic;
using ResourceAllocator.Model;

namespace ResourceAllocator.Factory
{
    public class IndiaTier : TierFactory
    {
        public override Region GetTiers()
        {
            var factory = new List<Tier>
            {
                new LTier(140, 10),
                new XLTier(-1, 20),
                new TwoXLTier(413, 40),
                new FourXLTier(890, 80),
                new EightXLTier(1300, 160),
                new TenXLTier(2970, 320)
            };
            factory.Sort((x, y) => x.RatePerUnit.CompareTo(y.RatePerUnit));
            return new Region
            {
                Name = "India",
                Tiers = factory
            };
        }
    }
}