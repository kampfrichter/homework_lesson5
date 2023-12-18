// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
using System.Collections.Generic;
using System.Linq;
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

            Print2DArray(Create2DArray(5, 5, 10, 99));

            // возвращает элемент массива по номеру строки и столбца
            
            void ReturnsAnElement(int[,] array) 
            {
                Console.WriteLine("\nвведите индекс строки");
                int rowNum = int.Parse(Console.ReadLine());
                Console.WriteLine("\nвведите индекс столбца");
                int colNum = int.Parse(Console.ReadLine());

                if (rowNum < array.GetLength(0) && colNum < array.GetLength(1)) 
                {
                    
                    Console.WriteLine("\nискомый элемент: \n" + array[rowNum,colNum]);
                }

                else 
                {
                    Console.WriteLine("\nв массиве нет элемента с такими индексами");
                }
            }

            ReturnsAnElement(Create2DArray(5, 5, 10, 99));

        }
    }
}
