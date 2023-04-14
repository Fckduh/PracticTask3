using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write(("Введите кол-во столбцов: "));
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[rows, cols];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mass[i, j] = random.Next(10);
                    Console.Write($" {mass[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
