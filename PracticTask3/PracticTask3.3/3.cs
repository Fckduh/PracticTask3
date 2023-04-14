using System;

namespace PracticTask3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] bacteria = new int[8, 8];
            int[,] nothing = new int[8, 8];
            Random random = new Random();
            for (int i = 0; i < bacteria.GetLength(0); i++)
            {
                for (int j = 0; j < bacteria.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == bacteria.GetLength(0) - 1 || j == bacteria.GetLength(1) - 1)
                    {
                        continue;
                    }
                        bacteria[i, j] = random.Next(0, 2);
                    Console.Write($"{bacteria[i, j]} ");
                }
                Console.WriteLine();
            }
            bool live = true;
            int age = 1;
            while (live)
            {
                Console.WriteLine($"Поколение номер {age}");

                for (int i = 0; i < bacteria.GetLength(0); i++)
                {
                    for (int j = 0; j < bacteria.GetLength(1); j++)
                    {
                        if (i == 0 || j == 0 || i == bacteria.GetLength(0) - 1 || j == bacteria.GetLength(1) - 1)
                        {
                            continue;
                        }

                        if (i - 1 >= 0 && i + 1 < bacteria.GetLength(0) && j - 1 >= 0 && j + 1 < bacteria.GetLength(1))
                        {

                            if (bacteria[i, j + 1] + bacteria[i, j - 1] + bacteria[i + 1, j] + bacteria[i - 1, j] + bacteria[i + 1, j + 1] + bacteria[i - 1, j + 1] + bacteria[i - 1, j - 1] + bacteria[i + 1, j - 1] > 2)
                            {
                                bacteria[i, j] = 0;
                            }
                            else if (bacteria[i, j + 1] + bacteria[i, j - 1] + bacteria[i + 1, j] + bacteria[i - 1, j] + bacteria[i + 1, j + 1] + bacteria[i - 1, j + 1] + bacteria[i - 1, j - 1] + bacteria[i + 1, j - 1] < 2)
                            {
                                bacteria[i, j] = 0;
                            }
                            else
                            {
                                nothing[i, j] = 1;
                            }
                        }
                        Console.Write($"{nothing[i, j]} ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < nothing.GetLength(0); i++)
                {
                    for (int j = 0; j < bacteria.GetLength(1); j++)
                    {
                        bacteria[i, j] = nothing[i, j];
                    }
                }
                age += 1;
                string a = Console.ReadLine();
                if (a == "exit")
                    live = false;
            }
        }
    }
}
