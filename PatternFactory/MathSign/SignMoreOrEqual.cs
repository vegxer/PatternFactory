using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.MathSign
{
    public class SignMoreOrEqual : Sign
    {
        public override bool Compare(double num1, double num2)
        {
            return num1 >= num2;
        }

        public override Sign Inverse()
        {
            return new SignLessOrEqual();
        }

        public override string ToString()
        {
            return ">=";
        }

        public override object Clone()
        {
            return new SignMoreOrEqual();
        }
    }
}
