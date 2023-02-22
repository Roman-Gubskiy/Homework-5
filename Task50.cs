using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран 
            все элементы массива в обратном порядке.*/

            //int[] myArray = { 13, 77, 87, 21, 88 }; упрощенный способ
            int[] myArray = new int[5] { 13, 77, 87, 21, 88 };
            for (int i = myArray.Length -1; i >= 0; i--)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.ReadKey();
        }
    }
}
