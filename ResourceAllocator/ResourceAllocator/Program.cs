using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ResourceAllocator.Factory;
using ResourceAllocator.Model;

namespace ResourceAllocator
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var factories = new List<TierFactory>
            {
                new NewYorkTier(),
                new IndiaTier(),
                new ChinaTier()
            };

            Console.Write("Enter the required capacity:");
            var capacity = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Enter the required hour:");
            var hour = int.Parse(Console.ReadLine() ?? string.Empty);

            foreach (var factory in factories)
            {
                var _capacity = capacity;
                var _cost = 0.0;
                var _result = new Result();
                var _machines = new List<Machine>();

                foreach (var tier in factory.GetTiers().Tiers)
                {
                    var _machine = new Machine();
                    var _qty = 0;
                    while (_capacity>=0 && _capacity - tier.Quantity >=0 && Math.Abs(tier.Rate - (-1)) > 0)
                    {
                        _capacity -= tier.Quantity;
                        _cost += tier.Rate;
                        _qty++;
                    }

                    if (_qty != 0)
                    {
                        _machine.Quantity = _qty;
                        _machine.Name = tier.Name;
                        _machines.Add(_machine);
                    }
                }

                _result.Region = factory.GetTiers().Name;
                _result.TotalCost = _cost * hour;
                _result.Machines = _machines;

                Console.WriteLine(JsonConvert.SerializeObject(_result));
            }

            Console.ReadKey();

        }
    }
}
