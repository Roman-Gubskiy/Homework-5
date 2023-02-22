using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task52
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
        Создайте программу, в которой создайте метод, который в качестве параметра принимает слово, 
        а возвращает тоже слово, но с измененным порядком букв в слове на обратный.*/

        static string ReverseWords(string a)
        {
            string strWord = a;
            char[] charsWord = strWord.ToCharArray();
            char[] arrayWord = new char[charsWord.Length];       
            Console.WriteLine("Введенное слово: {0}", strWord); 
            for (int i = 0; i < charsWord.Length; i++)
            {
                arrayWord[i] = strWord[i];
            }
            Console.Write($"Наоборот слово будет: ");
            for (int i = arrayWord.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayWord[i]);
            }
            return "0";
        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите слово");
                string word = (Console.ReadLine());
                ReverseWords(word);
                Console.ReadKey();
            }

            //Решение циклом
            //Console.WriteLine("Введите слово: ");
            //string strWord = (Console.ReadLine());
            //char[] charsWord = strWord.ToCharArray();
            //char[] arrayWord = new char[charsWord.Length];       // размер массива равен количеству символов строки
            //Console.WriteLine("Введенное слово: {0}", strWord);  // ($"Введенное слово: {strWord}")
            //for (int i = 0; i < charsWord.Length; i++)
            //{
            //    arrayWord[i] = strWord[i];
            //}
            //Console.Write($"Наоборот слово будет: ");
            //for (int i = arrayWord.Length-1; i >= 0 ; i--)
            //{                
            //    Console.Write(arrayWord[i]);
            //}
            //Console.ReadKey();
        }
    }
}

