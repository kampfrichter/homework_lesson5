
// : Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //создание двумерного массива
            int[,] Create2DArray(int rwos, int columns, int min, int max)
            {
                int[,] array = new int[rwos, columns];

                Random rand = new Random();
                for (int i = 0; i < rwos; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = rand.Next(min, max + 1);
                    }
                }

                return array;
            }

            // вывод массива в консоль
            void Print2DArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            // поиск строки с найменьшей суммой элементов массива
            int RowminSum(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                int smallestSum = int.MaxValue;
                int smallestSumRowIndex = -1;

                for (int i = 0; i < rows; i++)
                {
                    int rowSum = 0;

                    for (int j = 0; j < columns; j++)
                    {
                        rowSum += array[i, j];
                    }

                    if (rowSum < smallestSum)
                    {
                        smallestSum = rowSum;
                        smallestSumRowIndex = i;
                    }
                }

                return smallestSumRowIndex;
            }

            int[,] myArray = Create2DArray(4, 5, 0, 5);

            Print2DArray(myArray);
            Console.WriteLine(("\n" + RowminSum(myArray)));

            Console.ReadLine();

        }
    }



}