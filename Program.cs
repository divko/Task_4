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

            //            Что нужно сделать
            //Выведите на экран матрицу заданного размера и заполните её случайными числами.Детальный алгоритм работы приложения:

            //Сначала пользователю предлагается ввести количество строк в будущей матрице.
            //Затем — ввести количество столбцов в будущей матрице.
            //Когда данные будут получены, нужно создать в памяти матрицу заданного размера.
            //Используя Random, заполнить матрицу случайными целыми числами.
            //Вывести полученную матрицу на экран.
            //Вывести сумму всех элементов этой матрицы на экран отдельной строкой.
            //Рекомендация
            //Для работы с матрицами используйте вложенные циклы.

            //Что оценивается
            //Программа выводит на экран случайно созданную матрицу предварительно заданного размера, а также сумму всех элементов в ней.
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[row, col];

            Random r = new Random();
            int nvSum=0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = r.Next(100);
                    Console.Write($"{arr2d[i, j]} ");
                    nvSum = nvSum + arr2d[i,j];
                }
                Console.WriteLine();
            }

           Console.WriteLine($"Сумма всех элементов = " +  nvSum);
            Console.ReadKey();

            #endregion
        }
    }
}
