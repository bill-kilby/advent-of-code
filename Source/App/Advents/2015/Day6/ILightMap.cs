using App.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day6
{
    public interface ILightMap
    {
        public int GetTotalLitLights();

        public int GetTotalBrightness();

        public void HardToggle(Vector2Int pos);
        public void IncreaseToggle(Vector2Int pos);

        public void TurnOn(Vector2Int pos);

        public void TurnOff(Vector2Int pos);
    }
}
