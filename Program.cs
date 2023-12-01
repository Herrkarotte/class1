using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class Program
    {

        static void PrintA(in int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        static void SumA(in int[][] arr, ref int[] sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum[i] += arr[i][j];
                }
            }
        }
        static void MaxA(in int[][] arr, out int[] maxres)
        {
            int max = -9999;
            maxres = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {   max = -9999;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }
                maxres[i] = max;
            }
        }
        static void MinA(in int[][] arr, out int[] minres)
        {
            int min = 9999;
            minres = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                min = 9999;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                    }
                }
                minres[i] = min;
            }
        }
        static void Main(string[] args)
        {
            int N = 0;
            do
            {
                try
                {
                    Console.Write("Enter number of rows: ");
                    N = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    N = 0;
                }
            } while (N <= 0);
            int[] Sumres = new int[N];
            int[] Minres = new int[N];
            int[] Maxres = new int[N];
            int[][] arr = new int[N][];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"row #{i+1}: ");
                string input = Console.ReadLine();
                string[] val = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                arr[i] = new int[val.Length];
                for (int j = 0; j < val.Length; j++)
                {
                    int value = 0;
                    try
                    {
                        value = Convert.ToInt32(val[j]);
                    }
                    catch (FormatException)
                    {
                        value = 0;
                    }
                    finally
                    {
                        arr[i][j] = value;
                    }
                }
            }
            Console.WriteLine();
            PrintA(in arr);
            Console.WriteLine();
            SumA(in arr, ref Sumres);
            Console.WriteLine("Sum Result:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"row: {i + 1} sum= {Sumres[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Max Result:");
            MaxA(in arr, out Maxres);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"row: {i + 1} max= {Maxres[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Min Result:");
            MinA(in arr, out Minres);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"row: {i + 1} min= {Minres[i]}");
            }
            Console.WriteLine();
        }
    }
}
