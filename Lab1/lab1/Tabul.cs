using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.lab1
{
    internal class Tabul
    {
        public double[,] xy_array = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            return 2 * Math.Sqrt(Math.Abs(x * x * x)) * Math.Sin(x * x * x);
        }
        private double f2(double x)
        {
            return (x + 1) * (x + 1) * Math.Cos(x * x * x);
        }
        private double f3(double x)
        {
            return Math.Sqrt(x * x * x * x + 2) + Math.Sin(x * x);
        }

        public void calculate(double xn=-1.25, double xk=67.32, double h=0.3, double a=40) {
            double x = xn;
            double y;
            int i = 0;
            while (x <= xk) 
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if (x > 0 && x < a)
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy_array[i, 0] = x;
                xy_array[i, 1] = y;
                i++;
                x += h;
            }
            n = i;
        }
    }
}
