using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 2;
            int cols = 3;
            int[,] A = new int[2, 3] { { 4, 5, 8 }, { 7, 3, 6 } };
            int[,] B = new int[2, 3] { { 2, 9, 5 }, { 6, 5, 6 } };
            int[,] C = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    C[i, j] = A[i, j] +B[i, j];
                }
            }
            Console.WriteLine("Ответ:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{C[i,j]}\t");
                }
                Console.WriteLine();
                }
            Console.ReadKey();
        }
    }
}
