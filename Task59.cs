using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task59
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Имеются 2 целых числа A и В (каждое из них в отдельной строке). Необходимо вывести все числа от 
        A до B включительно. Если A < B, числа выводятся по возрастанию, в обратном случае — по
        убыванию. Использовать рекурсию.*/

        static void RecursionNum(int num1, int num2)
        {
            if (num1 <= num2)
            {
                Console.WriteLine(num1);
                num1++;
                if (num1 < num2)                   
                RecursionNum(num1,num2);                
            }
            if (num1 > num2)
            {
                num1--;
                Console.WriteLine(num1);                
                if (num1 != num2)                    
                RecursionNum(num1, num2);            
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Числа от А до И в зависимости от '>' / '<'.");
            RecursionNum(30,10);
            Console.ReadKey();
        }
    }
}
