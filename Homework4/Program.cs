using System;
using System.Linq;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Задача №1

            //Пользователь вводит одно число (A).
            //Вывести все числа от 1 до 1000, которые делятся на A. 

            /*Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i < 1000; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine($"Числа которые делятся на А: {i} ");
                }
            }*/
            #endregion


            #region Задача №2

            //Пользователь вводит одно число(A).
            //Найдите количество положительных целых чисел, квадрат которых меньше A.

            /*Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                if (a > Math.Pow(i, 2))
                {
                    Console.WriteLine($"Числа квадрат которых больше А: {i}");
                }
            }*/
            #endregion


            #region Задача №4

            /*Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = a; i < b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum: {sum}");*/
            #endregion


            #region Задача №5

            //Пользователь вводит два числа.
            //Найти их наибольший общий делитель используя алгоритм Евклида.

            /*Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            while (b != 0 && a != 0)
                if (a > b)
                {
                    a %= b;
                }
                else b %= a;
                   
            Console.WriteLine(a + b);*/

            //Это вариант 2 не уверен, что правильно)
            /*Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            while (b != 0 && a != 0)
                if (a > b)
                {
                    a -= b;
                }
                else b -= a;

            Console.WriteLine(a + b);*/
            #endregion


            #region Задача №7

            //Пользователь вводит одно число произвольной длины (5-8 цифр).
            //Найти количество нечетных цифр этого числа.

            /*Console.Write("Введите первое число: ");
            int num = int.Parse(Console.ReadLine());

            int numProverka, kolNeChetnih = 0, num1;
            num1 = num;
            while (true)
            {
                if (num == 0) break;
                numProverka = num % 10;
                num /= 10;
                if (numProverka % 2 != 0)
                {
                    kolNeChetnih++;
                }
            }
            Console.WriteLine($"Количество не четных цифр в числе {num1} равно { kolNeChetnih} !");*/
            #endregion


            #region Задача №8

            //Пользователь вводит одно число.
            //Найти число, которое является зеркальным отображением последовательности цифр заданного числа
            /*Console.WriteLine("Введите число: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Обратный вывод числа: ");
            for (; value != 0;)
            {
                Console.Write(value % 10 + " ");
                value /= 10;
            }*/
            #endregion


            #region Задача №9
            //Пользователь вводит целое положительное  число (N).
            //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.

            /*Console.Write("Введите первое число: ");
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;
            
            for (int i = 1; n >= i; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;

                }
            }
            for (int i = 1;  n >= i; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum += i;
                   
                }
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine(evenSum);
            }
            else Console.WriteLine("Сумма нечетных больше суммы чётных, ошибка!!!");*/
            #endregion


        }
    }
}
