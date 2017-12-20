using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutable_Immutable.Basic
{
    class MutableRectangle
    {
        public int Height { get; set; }
        public int Length { get; set; }

        public void Grow(int height, int length)
        {
            this.Height += height;
            this.Length += length;
        }

        public override string ToString()
        {
            return $"Height : {Height} Length : {Length}";
        }
    }
}
