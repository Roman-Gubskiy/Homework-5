using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task55
{
    internal class Program
    {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создает метод, который в качестве аргументов принимает: 
            1)целочисленный массив(int [] array), 2)целочисленный индекс(int index), 3)количество 
            элементов (int count), возвращает целочисленный массив элементов(int [] subArray). 
            Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции 
            указанной в аргументе index, размерностью, которая соответствует значению аргумента count.*/

        static int[] PartArray(int[] array, int index, int count) 
        {
            int[] subArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                subArray[i] = array[index];
                index++;
            }
            return subArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] {6, 8, 42, 74, 1, 54, 9, 33, 72, 15, 28, 65, 22, 14, 3};
            int index = 3;
            int count = 5;
            int[] subArray = PartArray(myArray, index, count);
            Console.WriteLine($"Масив части эелементов: ");
            for (int i = 0; i < subArray.Length; i++)                
            {
                Console.Write($"{subArray[i]}, ");
            }
            Console.ReadKey();
        }
    }
}
