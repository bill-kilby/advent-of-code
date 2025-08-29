using App.Advents._2015.Day6;
using App.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Advents._2015.Day6
{
    public class LightMap : ILightMap
    {
        private bool[,] _map = new bool[1000, 1000];

        public int GetTotalLitLights()
        {
            var total = 0;

            foreach (var light in _map)
            {
                if (light) total++;
            }

            return total;
        }

        public void Toggle(Vector2Int pos)
        {
            _map[pos.X, pos.Y] = !_map[pos.X, pos.Y];
        }

        public void TurnOff(Vector2Int pos)
        {
            _map[pos.X, pos.Y] = false;
        }

        public void TurnOn(Vector2Int pos)
        {
            _map[pos.X, pos.Y] = true;
        }
    }
}
