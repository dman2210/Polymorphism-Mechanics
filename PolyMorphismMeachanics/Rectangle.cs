﻿using System;

namespace PolyMorphismMeachanics
{
    public class Rectangle : Shape
    {
        private int _Width;
        private int _Height;

        public int Width
        {
            get
            {
                return _Width;
            }
            set
            {
                _Width = value;
            }
        }

        public int Height
        {
            get
            {
                return _Height;
            }
            set
            {
                _Height = value;
            }
        }

        public override int CenterX()
        {
            return Left + (1 / 2 * Width);
        }

        public override int CenterY()
        {
            return Top + (1 / 2 * Height);
        }

        public override double GetArea()
        {
            return (Width * Height);
        }

        public Rectangle(int width, int height, int top, int left):base(top, left)
        {
            Width = width;
            Height = height;
        }
    }

}
