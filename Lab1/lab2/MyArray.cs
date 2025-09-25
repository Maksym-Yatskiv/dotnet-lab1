using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace dotnet_labs.lab2
{
    internal class MyArray
    {
        private double[] array;
        public int Length { get; set; } = 20;

        public MyArray()
        {
            array = new double[Length];
            Random rand = new();
            for(int i = 0; i < Length; i++)
            {
                this[i] = rand.Next(100, 200);
            }
        }
        public MyArray(double[] array)
        {
            this.array = array;
        }
        public MyArray(int length)
        {
            Length = length;
            array = new double[Length];
            Random rand = new();
            for (int i = 0; i < Length; i++)
            {
                this[i] = rand.Next(100, 200);
            }
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                    throw new IndexOutOfRangeException("Індекс поза межами");
                return array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                    throw new IndexOutOfRangeException("Індекс поза межами");

                if (value < 100 || value > 200)
                    throw new ArgumentOutOfRangeException("Значення  масиву має бути в межах від 100 до 200");

                array[index] = value;
            }
        }

        public double FindOddSum()
        {
            double sum = 0;
            for(int i = 1; i < Length + 1; i++)
            {
                if(i % 2 != 0)
                    sum += array[i - 1];
            }
            return sum;
        }

    }
}
