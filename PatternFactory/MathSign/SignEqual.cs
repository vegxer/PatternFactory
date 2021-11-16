using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.MathSign
{
    public class SignEqual : Sign
    {
        public override bool Compare(double left, double right)
        {
            return left == right;
        }

        public override Sign Inverse()
        {
            return new SignNotEqual();
        }

        public override string ToString()
        {
            return "=";
        }

        public override object Clone()
        {
            return new SignEqual();
        }
    }
}
