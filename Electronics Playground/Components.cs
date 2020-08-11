using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Playground
{
    public class Components
    {
        public struct Bit
        {
            public Bit(bool state)
            {
                bitState = state ? 1 : 0;
            }

            public static implicit operator Bit(bool val)
            {
                Bit x = new Bit(val);
                return x;
            }
            
            public static implicit operator Bit(int val)
            {
                Bit x = new Bit();
                if (val >-1 && val <2){x.bitState = val;} else { x.bitState = 0; }
                return x;
            }

            private int bitState { get; set; }

            public override string ToString() => $"{bitState}";
        }
    }
}
