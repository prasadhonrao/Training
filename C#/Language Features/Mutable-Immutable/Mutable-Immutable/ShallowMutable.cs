using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutable_Immutable
{
    class ShallowMutable
    {
        public int Value { get; }

        public StringBuilder Builder { get;  }
        public ShallowMutable(int value, StringBuilder builder) // StrinbBuilder is mutable
        {
            this.Value = value;
            this.Builder = builder;
        }

    }
}
