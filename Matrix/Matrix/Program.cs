using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2, n = 3, p = 3, q = 3, i, j;
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, { 1, 2, 1 } };
            int[,] c = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Matrix a:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix b:");
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix c: ");
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
                int[,] d = new int[m, q];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        d[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            d[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                Console.WriteLine("The product of the two matrices is :");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(d[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            //Console.Write();
            }
        }
    }
