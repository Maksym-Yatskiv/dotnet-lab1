using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_labs.lab3
{
    public class CalculationTask2
    {
        public int A { set; get; }
        public int B { set; get; }

        public CalculationTask2()
        {
            A = 0;
            B = 0;
        }

        public CalculationTask2(int a, int b)
        {
            A = a;
            B = b;
        }
        public int Calculate()
        {
            if (A > B)
                throw new ArgumentException("A should be less than or equal to B");
            
            if (A == B) return 0;

            int sum = 0;
            for (int x = this.A; x <= this.B; x++)
            {
                int mod8 = ((x % 8) + 8) % 8;
                if (x % 11 == 0 && mod8 == 5)
                {
                    sum += x;
                }
            }

            return sum;
        }
    }
}
