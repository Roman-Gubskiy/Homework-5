using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
            Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев. После чего 
            пользователь вводит диапазон (например, 3 и 6 – поиск между 3-м и 6-м месяцем). Необходимо 
            определить месяц, в котором прибыль была максимальна и месяц, в котором прибыль была 
            минимальна с учетом выбранного диапазона.*/

            
            int counter = 1;
            int[] monthsArray = new int[13];
            Console.WriteLine("Заполните сумму прибыли за каждый месяц: ");
            for (int i = 1; i < 13; i++)
            {
                Console.Write($"Месяц {counter}: ");
                int months = int.Parse(Console.ReadLine());
                monthsArray[i] = months;
                counter++;
            }
            Console.WriteLine("Выберите диапазон между месяцами: ");
            Console.Write("Начало диапазона: ");
            int rangeStart = int.Parse(Console.ReadLine());
            Console.Write("Конец диапазона: ");
            int rangeFinish = int.Parse(Console.ReadLine());
            int minValue = monthsArray[rangeStart];
            int maxValue = monthsArray[rangeStart];


            for (int y = rangeStart; y <= rangeFinish; y++)
            {
                if (monthsArray[y] < minValue)
                {
                    minValue = monthsArray[y];
                }
                if (monthsArray[y] > maxValue)
                {
                    maxValue = monthsArray[y];
                }

            }
            for (int r = rangeStart; r <= rangeFinish; r++)
            {
                if (monthsArray[r] == minValue)
                {
                    Console.Write($"Минимальна з/п была {r}-го мес. ");
                    break;
                }

            }
            Console.WriteLine($"{minValue} грн.");
            for (int t = rangeStart; t <= rangeFinish; t++)
            {

                if (monthsArray[t] == maxValue)
                {
                    Console.Write($"Максимальна з/п была {t}-го мес. ");
                    break;
                }
            }                      
            Console.WriteLine($"{maxValue} грн.");

            Console.ReadKey();
        }
    }
}
