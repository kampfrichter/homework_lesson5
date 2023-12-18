// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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

            // меняет местами первую и последнюю строку
            void ChengeFirstLastRow(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);

                for (int i = 0; i < columns; i++)
                {
                    int temp = array[0, i];
                    array[0, i] = array[rows - 1, i];
                    array[rows - 1, i] = temp;
                }
            }


            int[,] myArray = Create2DArray(6, 3, 0, 9);
            Print2DArray(myArray);
            Console.WriteLine();

            ChengeFirstLastRow(myArray);
            Print2DArray(myArray);

        }
    }
}
