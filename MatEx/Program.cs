using System;
using System.Windows.Markup;

namespace MatEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            m = int.Parse(Console.ReadLine()!);
            n = int.Parse(Console.ReadLine()!);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine()!.Split(' ');
                for (int j=0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            int num = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == num)
                    {
                        Console.Write("Position: ");
                        Console.WriteLine($"{i},{j}");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j < n-1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i < m-1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }

                    }

                }
            }
            Console.WriteLine();
        }
    }
}