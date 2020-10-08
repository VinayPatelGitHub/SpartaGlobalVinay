using System;
using System.Collections.Generic;
using System.Text;

namespace Safari_Park
{
    public abstract class Shape
    {
        public abstract int CalculateArea();
        public override string ToString()
        {
            return "This is a shape";
        }

    }

    public sealed class Rectangel : Shape
    {
        private int _width;
        private int _height;

        public Rectangel(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public override int CalculateArea()
        {
            return _width *_height;
        }
    }


}
