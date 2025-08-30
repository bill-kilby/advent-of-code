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
            throw new NotImplementedException();
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

        public void HardToggle(Vector2Int pos)
        {
            throw new NotImplementedException();
        }

        public void IncreaseToggle(Vector2Int pos)
        {
            throw new NotImplementedException();
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
