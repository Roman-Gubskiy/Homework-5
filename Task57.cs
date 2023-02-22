using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.                                       
            Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его 
            случайными элементами. Выведете на консоль полученный массив. Найдите суммы элементов 
            каждой строки, произведения элементов каждого столбца, и максимальный элемент главной 
            диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).*/

            uint[,] myArray = new uint[10,10];
            Random random = new Random();
            uint lineSum = 0, productOfNumbers = 1, diagonal = 0;

            //Заполнение массива рандомными числами от 0 -100
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    myArray[y,x] = (uint)random.Next(1,10);
                }
            }
            //Вывод массва в таблице
            Console.WriteLine($"Таблица массива {myArray.GetLength(0)}x{myArray.GetLength(1)}");
            Console.WriteLine();
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write($"{myArray[y, x]} \t");
                }
                Console.WriteLine();
            }
            //Сумма строк таблицы - массива 
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    lineSum += myArray[y,x];                    
                }
                Console.WriteLine();
                Console.Write($"Сумма строки {y+1}: ");
                Console.WriteLine($"{lineSum}");
                lineSum = 0;
            }
            //Произведения столбцов таблицы - массива 
            for (int y = 0; y < myArray.GetLength(1); y++)
            {                
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    productOfNumbers *= myArray[i, y];
                    
                }
                Console.WriteLine();
                Console.Write($"Произведения столбца {y + 1}: ");
                Console.WriteLine($"{productOfNumbers}");
                productOfNumbers = 1;
            }
            Console.WriteLine();
            for (int r = 0; r < myArray.GetLength(1); r++)
            {
                diagonal = myArray[r, r];
                if (diagonal > myArray[r, r])
                {
                    diagonal = myArray[r, r];
                }
            }
            Console.WriteLine($"Наибольший элемент главной диагонали: {diagonal}");
            Console.ReadKey();
        }
    }
}
