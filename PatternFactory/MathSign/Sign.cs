using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.MathSign
{
    public abstract class Sign : ICloneable
    {
        public abstract bool Compare(double left, double right);
        public abstract Sign Inverse();
        public abstract override string ToString();
        public abstract object Clone();
    }
}
