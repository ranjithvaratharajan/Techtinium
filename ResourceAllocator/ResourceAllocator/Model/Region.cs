using System.Collections.Generic;

namespace ResourceAllocator.Model
{
    public class Region
    {
        public string Name { get; set; }
        public List<Tier> Tiers { get; set; }
    }
}