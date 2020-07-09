using System.Collections.Generic;
using ResourceAllocator.Model;

namespace ResourceAllocator.Factory
{
    public abstract class TierFactory
    {
        public abstract Region GetTiers();
    }
}