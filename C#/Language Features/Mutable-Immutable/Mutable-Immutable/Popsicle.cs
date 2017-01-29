using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutable_Immutable
{
    public sealed class Popsicle
    {
        public bool Frozen { get; private set; }

        private int value;

        public int Value
        {
            get { return value; }
            set
            {
                if (Frozen)
                {
                    throw new Exception("Couldn't keep it in!");
                }
                this.value = value;
            }
        }

        public void Freeze()
        {
            Frozen = true;
        }

    }
}
