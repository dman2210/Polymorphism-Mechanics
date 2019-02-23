using System;
namespace PolyMorphismMeachanics
{
    public abstract class Shape
    {
        private int _Left;
        private int _Top;

        public int Left
        {
            get
            {
                return _Left;
            }
            set
            {
                _Left = value;
            }
        }


        public int Top
        {
            get
            {
                return _Top;
            }
            set
            {
                _Top = value;
            }
        }
        public abstract int CenterX();
        public abstract int CenterY();
        public abstract double GetArea();

        public Shape(int top, int left)
        {
            Top = top;
            Left = left;
        }
    }

}
