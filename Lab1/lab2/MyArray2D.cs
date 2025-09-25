using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dotnet_labs.lab2
{
    internal class MyArray2D
    {
        private double[,] array;
        private int rows = 4;
        private int cols = 4;
        public int Rows
        {
            get { return rows; }
            set
            {
                if (value < 1 || value > 7)
                    throw new ArgumentOutOfRangeException("Кількість рядків має бути в межах від 1 до 7");
                rows = value;
            }
        }
        public int Cols 
        { 
            get { return cols; } 
            set
            {
                if (value < 1 || value > 7)
                    throw new ArgumentOutOfRangeException("Кількість рядків має бути в межах від 1 до 7");
                cols = value;
            } 
        }

        public MyArray2D()
        {
            array = new double[Rows, Cols];
            GenerateValues();
        }

        public MyArray2D(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new double[Rows, Cols];
            GenerateValues();
        }

        public double this[int indexRow, int indexCol]
        {
            get
            {
                if (indexRow < 0 || indexRow > Rows || indexCol < 0 || indexCol > Cols)
                    throw new IndexOutOfRangeException("Індекс поза межами");
                return array[indexRow, indexCol];
            }
            set
            {
                if (indexRow < 0 || indexRow > Rows || indexCol < 0 || indexCol > Cols)
                    throw new IndexOutOfRangeException("Індекс поза межами");
                array[indexRow, indexCol] = value;
            }
        }

        public void GenerateValues()
        {
            for (int j = 0; j < Cols; j++)
                this[0, j] = 2 * j + 3;

            if (Rows > 1)
            {
                for (int j = 0; j < Cols; j++)
                    this[1, j] = j + 3.0 / (2 + j);

                for (int i = 2; i < Rows; i++)
                    for (int j = 0; j < Cols; j++)
                        this[i, j] = this[i - 2, j] + this[i - 1, j];
            }
        }
    }
}
