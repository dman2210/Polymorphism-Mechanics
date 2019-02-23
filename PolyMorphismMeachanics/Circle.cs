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
            return Math.PI * Radius * Radius;
        }

        public Circle(int radius, int top, int left) : base(top, left)
        {
            Radius = radius;
        }

        public Circle() { }

        public static Circle operator +(Circle c1, Circle c2)
        {
            Circle newCirc = new Circle(c1.Radius + c2.Radius, c1.Top, c1.Left);
            return newCirc;
        }

        public static bool operator >(Circle c1, Circle c2)
        {
            if (c1.Radius > c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Circle c1, Circle c2)
        {
            if (c1.Radius < c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String operator +(Circle s1, Triangle s2)
        {
            if(s1 == null&&s2 == null)
            {
                return "unhappy kid";
            }
            else if(s1==null&&s2 != null)
            {
                return "cone";
            }
            else if(s1 != null && s2 == null)
            {
                return "ice cream";
            }
            else
            {
                return "ice cream cone";
            }
        }
    }
}
