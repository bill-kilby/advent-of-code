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
        private int[,] _map = new int[1000, 1000];

        public int GetTotalBrightness()
        {
            var total = 0;

            foreach (var light in _map)
            {
                total += light;
            }

            return total;
        }

        public int GetTotalLitLights()
        {
            var total = 0;

            foreach (var light in _map)
            {
                if (light > 0) total++;
            }

            return total;
        }

        public void IncreaseBrightness(Vector2Int pos, int amount)
        {
            throw new NotImplementedException();
        }

        public void DecreaseBrightness(Vector2Int pos, int amount)
        {
            throw new NotImplementedException();
        }

        public void Toggle(Vector2Int pos)
        {
            if (_map[pos.X, pos.Y] != 0)
            {
                _map[pos.X, pos.Y] = 0;
            }
            else
            {
                _map[pos.X, pos.Y] = 1;
            }
        }

        public void TurnOff(Vector2Int pos)
        {
            _map[pos.X, pos.Y] = 0;
        }

        public void TurnOn(Vector2Int pos)
        {
            _map[pos.X, pos.Y] = 1;
        }
    }
}
