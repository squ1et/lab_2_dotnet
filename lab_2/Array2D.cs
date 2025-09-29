using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Array2D
    {
        private int[,] A;  
        private int rows = 10;
        private int cols = 7;

        public int Rows => rows;
        public int Cols => cols;


        public Array2D()
        {
            A = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    A[i, j] = rnd.Next(1, 100);
                }
            }
        }

        public int this[int i, int j]
        {
            get { return A[i, j]; }
            set { A[i, j] = value; }
        }

        public int SumOddIndexes()
        {
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (((i + 1) % 2 != 0) && ((j + 1) % 2 != 0))
                    {
                        sum += A[i, j];
                    }
                }
            }

            return sum;
        }

        public string[] ToStringArray()
        {
            string[] lines = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < cols; j++)
                {
                    line += A[i, j].ToString().PadLeft(4);
                }
                lines[i] = line;
            }
            return lines;
        }
    }
}
