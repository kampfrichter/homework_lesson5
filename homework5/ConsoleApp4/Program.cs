
//(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.
//Под удалением понимается создание нового двумерного массива без строки и столбца

using System;
using System.Collections.Generic;
using System.Data.Common;
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
            int[,] Create2DArray(int rows, int columns, int min, int max)
            {
                int[,] array = new int[rows, columns];

                Random rand = new Random();
                for (int i = 0; i < rows; i++)
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

            // удаление строки и столбца содержащих найменьший элемент
            int[,] RemoveMinElementRowAndCol(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                int minElement = int.MaxValue;
                int minElementRowIndex = -1;
                int minElementColumnIndex = -1;

                // поиск найменьшего элемента и его индексов
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (array[i, j] < minElement)
                        {
                            minElement = array[i, j];
                            minElementRowIndex = i;
                            minElementColumnIndex = j;
                        }
                    }
                }

                // cоздание нового массива размера (row-1)x(col-1)
                int[,] newArray = new int[rows - 1, columns - 1];

                // копирование эл-тов исходного массива в новый массив пропуская строку и столбец с минимальным элементом
                for (int i = 0, newRow = 0; i < rows; i++)
                {
                    if (i == minElementRowIndex)
                    {
                        continue;
                    }

                    for (int j = 0, newColumn = 0; j < columns; j++)
                    {
                        if (j == minElementColumnIndex)
                        {
                            continue;
                        }
                        newArray[newRow, newColumn] = array[i, j];
                        newColumn++;
                    }
                    newRow++;
                }

                return newArray;

            }

            int[,] myArray = Create2DArray(5, 5, 0, 9);

            Print2DArray(myArray);
            Console.WriteLine();

            Print2DArray(RemoveMinElementRowAndCol(myArray));
            Console.ReadLine();

        }
    }
}