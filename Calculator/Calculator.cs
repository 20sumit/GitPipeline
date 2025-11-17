using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class CalculatorService
    {
        public static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => a - b;
        public static int Mul(int a, int b) => a * b;
        public static double Div(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return (double)a / b;
        }
    }
}
