using System;

namespace PolyMorphismMeachanics
{
    public class Cylinder : Circle, IVolume
    {
        private int _Height;

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

        public double GetVolume()
        {
            return Height * Math.PI * (Radius ^ 2);
        }

        public Cylinder(int radius, int height, int top, int left) : base(radius, top, left)
        {
            Height = height;
        }
    }

}
