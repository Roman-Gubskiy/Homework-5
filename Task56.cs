using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task56
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Создайте программу, в которой создайте метод, который будет выполнять увеличение длины 
        массива переданного в качестве аргумента, на 1 элемент. Метод, должен принимает два 
        аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value. В теле 
        метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0, 
        при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого 
        массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 
        1.*/
        static void PartArray(ref int[] array, int value)
        {


            int[] newArray = new int[array.Length+1];

            newArray[0] = value;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i-1];
            }
            array = newArray;
         }
        static void Main(string[] args)
        {
            int[] myArray = { 6, 8, 42, 74, 1, 54, 9, 33, 72, 15, 28, 65, 22, 14, 3 };
            int index = 666;
            PartArray(ref myArray, index);
            Console.WriteLine($"Масив части эелементов: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}, ");
            }
            Console.ReadKey();
        }
    }
}
