using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой создайте массив размера N элементов (размер массива задет 
            пользователь), заполнить его произвольными целыми значениями. Вывести на экран: 
            наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов, 
            среднее арифметическое всех элементов, вывести все нечетные значения.*/

            Console.WriteLine("Задайте размер Вашего массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] myArray = new int[N];
            Random random = new Random();
            int maxValue = 0, minValue = 100, sum = 0;            
            for (int i = 0; i < N; i++)
            {
                myArray[i] = random.Next(0, 100);
            }
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine(myArray[i]); // Весь массив
            //}
            for (int i = 0; i < N; i++)
            {
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
                sum += myArray[i];
            }
            Console.WriteLine($"Наименьшее значение массива: {minValue}");
            Console.WriteLine($"Наибольшее значение массива: {maxValue}");
            Console.WriteLine($"Общая сумма массива: {sum}");
            Console.WriteLine($"Среднее арифметическое всех элементов: {sum / N}");
            Console.ReadKey();
        }
    }
}
