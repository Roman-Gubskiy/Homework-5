using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте два строковых массива с именами A и B (размерностью 
            4 элемента). Массив A заполняется в цикле пользователем. Получить результирующий массив B, 
            обратный к исходному массиву A (элементы массива B идут в обратном порядке по отношению к 
            массиву A).*/

            int counter = 0;
            int[] A = new int[4], B = new int[4];
            Console.WriteLine("Заполните массив 'A': ");
            for (int i = 0; i <= 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                A[i] = num;
            }
            for (int i = A.Length - 1; i >= 0; i--)
            {               
                B[counter] = A[i];
                counter++;
            }
            Console.WriteLine("Вывод в обратном порядке массива 'В': ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine($"{B[i]} ");
            }
            Console.ReadKey();
        }
    }
}
