using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutable_Immutable.Basic
{
    class ImmutableRectangle
    {
        public int Height { get; }
        public int Length { get; }

        public ImmutableRectangle(int height, int length)
        {
            this.Height = height;
            this.Length = length;
        }

        public ImmutableRectangle Grow(int height, int length) => 
            new ImmutableRectangle(Height + height, Length + length); // Always returns a new instance of ImmutableRectangle, so preserving original rectangle (just like string)

    }
}
