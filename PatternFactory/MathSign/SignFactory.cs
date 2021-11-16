using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.MathSign
{
    public static class SignFactory
    {
        public static Sign Create(string inequalitySign)
        {
            switch (inequalitySign)
            {
                case "<":
                    return new SignLess();
                case ">":
                    return new SignMore();
                case "<=":
                    return new SignLessOrEqual();
                case ">=":
                    return new SignMoreOrEqual();
                case "=":
                    return new SignEqual();
                case "!=":
                    return new SignNotEqual();
                default:
                    throw new ArgumentException("Неверный ввод знака");
            }
        }
    }
}
