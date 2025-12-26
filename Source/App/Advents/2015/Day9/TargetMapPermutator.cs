using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day9
{
    public class TargetMapPermutator
    {
        public List<string[]> GetRoutes(CitySourceTargetMap map, string source, string destination)
        {
            var cities = map.GetPossibleCities();

            var routes = Permute(cities);

            return routes
                .Where(x => x.Length != 1)
                .Where(x => x.First().Equals(source))
                .Where(x => x.Last().Equals(destination))
                .ToList();

        }

        public List<string[]> Permute(string[] cities)
        {
            throw new NotImplementedException();
        }

    }
}
