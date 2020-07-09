using System.Collections.Generic;

namespace ResourceAllocator.Model
{
    public class Result
    {
        public string Region { get; set; }
        public double TotalCost { get; set; }
        public List<Machine> Machines { get; set; }
    }

    public class Machine
    {
        public string Name { get; set; }

        public int Quantity { get; set; } = 0;
    }
}