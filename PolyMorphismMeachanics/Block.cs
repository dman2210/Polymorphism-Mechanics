using System;

namespace PolyMorphismMeachanics
{
    public class Block : Rectangle, IVolume
    {
        private int _Length;

        public int Length
        {
            get
            {
                return _Length;
            }
            set
            {
                _Length = value;
            }
        }

        public double GetVolume()
        {
            return Width * Height * Length;
        }

        public Block(int width, int height, int length,int top, int left) : base(width, height, top, left)
        {
            Length = length;
        }
    }

}
