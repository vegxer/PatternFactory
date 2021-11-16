using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternFactory.MathSign;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Sign sign = SignFactory.Create("<");
            Console.WriteLine(sign.Compare(1, 2));

            Console.ReadKey();
        }
    }
}
