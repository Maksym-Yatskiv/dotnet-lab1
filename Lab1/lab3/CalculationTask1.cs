using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_labs.lab3
{
    public class CalculationTask1
    {
        public int A { set; get; }
        public int B { set; get; }
        public int C { set; get; }

        public CalculationTask1()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        public CalculationTask1(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public int Calculate()
        {
            int result = 0;
            if (A % 7 == 0)
                result += A * A * A;
            if (B % 7 == 0)
                result += B * B * B;
            if (C % 7 == 0)
                result += C * C * C;

            return result;
        }
    }
}
