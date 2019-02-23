using System;

namespace PolyMorphismMeachanics
{
    public class Circle : Shape
    {
        private int _Radius;

        public int Radius
        {
            get
            {
                return _Radius;
            }
            set
            {
                _Radius = value;
            }
        }

        public override int CenterX()
        {
            return Left + Radius;
        }

        public override int CenterY()
        {
            return Top + Radius;
        }

        public override double GetArea()
        {
            return Math.PI*Radius*Radius;
        }

        public Circle(int radius, int top, int left):base(top, left)
        {
            Radius = radius;
        }
    }

}
