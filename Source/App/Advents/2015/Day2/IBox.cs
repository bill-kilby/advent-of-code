using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day2
{
    public interface IBox
    {
        public int GetAreaOfSmallestSide();

        public int GetSurfaceArea();

        public int GetVolume();

        public int GetSmallestPerimeter();
    }
}
