using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task58
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
        Создайте програму в которой создайте метод у которого будет 3 перегрузки. Программа должна 
        конвертировать введенное пользователем значение в метрах в другие единицы измерения 
        В 1-й перегрузке метод должен конвертировать метры в сантиметры.
        Во 2-й перегрузке метод должен конвертировать метры в сантиметры и миллиметры.
        В 3-й перегрузке метод должен конвертировать метры в сантиметры, миллиметры и километры. 
        Организовать вывод полученных значений на консоль в методе Main().*/

        /// <summary>
        /// Конвертировать введенное пользователем значение в метрах в другие единицы измерения 
        /// </summary>
        /// <param name="a">метры числом 'int'</param>
        /// <param name="cm">сантиметры 'cm'</param>
        static void lengthConverter(int a, string b)
        {
            if (b == "cm")
            {
                int sum = a * 100;
                Console.WriteLine($"{a}m. = {sum}cm.");
            }
            else
            {
                Console.WriteLine($"Вы некоректно ввели cm - {b}!");
            }

        }
        /// <summary>
        /// Конвертировать введенное пользователем значение в метрах в другие единицы измерения 
        /// </summary>
        /// <param name="a">метры числом 'int'</param>
        /// <param name="cm">сантиметры 'cm'</param>
        /// <param name="mm">милиметры 'mm'</param>
        static void lengthConverter(int a, string cm, string mm)
        {
            if (cm == "cm" && mm == "mm")
            {
                int sum1 = a * 100;
                int sum2 = a * 1000;
                Console.WriteLine($"{a}m. = {sum1}cm.");
                Console.WriteLine($"{a}m. = {sum2}mm.");
            }
            if (cm != "cm")
            {
                Console.WriteLine($"1 Вы некоректно ввели cm - {cm}! ");
            }
            if (mm != "mm")
            {
                Console.WriteLine($"2 Вы некоректно ввели mm - {mm}! ");
            }
            
        }
        /// <summary>
        /// Конвертировать введенное пользователем значение в метрах в другие единицы измерения 
        /// </summary>
        /// <param name="a">метры числом 'int'</param>
        /// <param name="cm">сантиметры 'cm'</param>
        /// <param name="mm">милиметры 'mm'</param>
        /// <param name="km">километры 'km'</param>
        static void lengthConverter(int a, string cm, string mm, string km)
        {
            if (cm == "cm" && mm == "mm" && km == "km")
            {
                int sum1 = a * 100;
                int sum2 = a * 1000;
                double sum3 = a * 0.001;
                Console.WriteLine($"{a}m. = {sum1}cm.");
                Console.WriteLine($"{a}m. = {sum2}mm.");
                Console.WriteLine($"{a}m. = {sum3}km.");
            }
            if (cm != "cm")
            {
                Console.WriteLine($"1 Вы некоректно ввели cm - {cm}! ");
            }
            if (mm != "mm")
            {
                Console.WriteLine($"2 Вы некоректно ввели mm - {mm}! ");
            }
            if ((mm != "km"))
            {
                Console.WriteLine($"2 Вы некоректно ввели km - {km}! ");
            }
        }

        static void Main(string[] args)
        {
            int a = 2;// метры 
            lengthConverter(a, "cm", "mm", "km"); //трехразрядный метод
            Console.ReadKey();
        }
    }
}
