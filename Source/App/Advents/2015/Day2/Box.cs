using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Advents._2015.Day2
{
    public class Box : IBox
    {
        private int _width;
        private int _length;
        private int _height;

        private int _widthLengthArea;
        private int _widthHeightArea;
        private int _lengthHeightArea;

        private int _widthLengthPerimeter;
        private int _widthHeightPerimeter;
        private int _lengthHeightPerimeter;

        public Box(int width, int length, int height)
        {
            _width = width;
            _length = length;
            _height = height;

            _widthLengthArea = width * length;
            _widthHeightArea = width * height;
            _lengthHeightArea = length * height;

            _widthLengthPerimeter = (2 *  width) + (2 * length);
            _widthHeightPerimeter = (2 * width) + (2 * height);
            _lengthHeightPerimeter = (2 * length) + (2 * height);
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

        public int GetVolume()
        {
            return _width * _length * _height;
        }

        public int GetSmallestPerimeter()
        {
            var hMin = Math.Min(_widthHeightPerimeter, _lengthHeightPerimeter);
            return Math.Min(_widthLengthPerimeter, hMin);
        }
    }
}
