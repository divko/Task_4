using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1.Случайная матрица

            // Console.Write("Введите количество строк: ");
            // int row = int.Parse(Console.ReadLine());
            // Console.Write("Введите количество столбцов: ");
            // int col = int.Parse(Console.ReadLine());

            // int[,] arr2d = new int[row, col];

            // Random r = new Random();
            // int nvSum=0;

            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < col; j++)
            //     {
            //         arr2d[i, j] = r.Next(100);
            //         Console.Write($"{arr2d[i, j]} ");
            //         nvSum = nvSum + arr2d[i,j];
            //     }
            //     Console.WriteLine();
            // }

            //Console.WriteLine($"Сумма всех элементов = " +  nvSum);
            // Console.ReadKey();

            #endregion
            #region Задание 2.Сложение матриц


            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arrA2d = new int[row, col];
            int[,] arrB2d = new int[row, col];
            int[,] arrC2d = new int[row, col];
            Random r = new Random();
            Console.WriteLine();
            Console.WriteLine("Полученная матрица");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arrA2d[i, j] = r.Next(100);
                    arrB2d[i, j] = r.Next(100);
                    arrC2d[i, j] = (arrA2d[i, j] + arrB2d[i, j]);
                    Console.Write($"{arrC2d[i, j]} ");
                }
                Console.WriteLine();
                }
            Console.ReadLine();

            Console.WriteLine("Первая матрица");
            for (int i = 0; i < row; i++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arrA2d[i, j]} ");
                }
                Console.WriteLine();   
            }
            Console.WriteLine();
            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < row; i++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arrB2d[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сумма матриц");
            for (int i = 0; i < row; i++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arrC2d[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            #endregion
        }
    }
}
