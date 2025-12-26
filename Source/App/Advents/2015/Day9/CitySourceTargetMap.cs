using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day9
{
    public class CitySourceTargetMap
    {
        private Dictionary<string, List<CityTarget>> map = new();

        public void AddTargetToCity(string source, string target, int cost)
        {
            if (map.TryGetValue(source, out var targets))
            {
                targets.Add(new CityTarget(target, cost));
            }
            else
            {
                map.Add(source, new List<CityTarget>());
                map[source].Add(new CityTarget(target, cost));
            }
        }

        public List<CityTarget>? GetCityTargets(string source) => map.GetValueOrDefault(source);

        public string[] GetPossibleCities()
        {
            var sourceCities = map.Keys;
            var destinationCities = map.Values
                .SelectMany(x => x)
                .Select(x => x.City);

            return sourceCities
                .Union(destinationCities)
                .Distinct()
                .ToArray();
        }
    }

    public class CityTarget
    {
        public string City { get; }
        public int Cost { get; }
        public CityTarget(string city, int cost)
        {
            City = city;
            Cost = cost;
        }
    }
}
