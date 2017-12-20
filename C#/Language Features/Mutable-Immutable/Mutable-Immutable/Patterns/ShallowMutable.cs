using System.Text;

namespace Mutable_Immutable
{
    class ShallowMutable.Patterns
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
