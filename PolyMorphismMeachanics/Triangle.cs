using System;

namespace PolyMorphismMeachanics
{
    public class Triangle : Shape
    {
        private int _Base;
        private int _Height;

        public int Base
        {
            get
            {
                return _Base;
            }
            set
            {
                _Base = value;
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
            return Left + (Base * 1 / 2);
        }

        public override int CenterY()
        {
            return Top + (Height * 1 / 2);
        }

        public override double GetArea()
        {
            return (Base * 1 / 2 * Height);
        }
        public Triangle() { }

        public Triangle(int daBase,int height, int top, int left ):base(top, left)
        {
            Height = height;
            Base = daBase;
        }
    }

}
