using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day2
{
    public class Box : IBox
    {
        private int _widthLengthArea;
        private int _widthHeightArea;
        private int _lengthHeightArea;

        public Box(int width, int length, int height)
        {
            _widthLengthArea = width * length;
            _widthHeightArea = length * height;
            _lengthHeightArea = length * height;
        }

        public int GetAreaOfSmallestSide()
        {
            var hMin = Math.Min(_widthHeightArea, _lengthHeightArea);
            return Math.Min(_widthLengthArea, hMin);
        }

        public int GetSurfaceArea()
        {
            return (2 * _widthLengthArea) + (2 * _widthHeightArea) + (2 * _lengthHeightArea);
        }
    }
}
