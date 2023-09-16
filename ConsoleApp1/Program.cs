using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_25_09
{
    internal class Program_ex_1
    {
        static void Main(string[] args)
        { // Завдання 1
            Console.WriteLine("Завдання 1");
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            Console.WriteLine();

            // Завдання 2
            Console.WriteLine("Завдання 2");
            int[] numbers = new int[5];
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int product = 1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введіть число: ");
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    sum += numbers[i];
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                    product *= numbers[i];
                }
                else
                {
                    Console.WriteLine("Неправильний ввід. Будь ласка, введіть число.");
                    i--;
                }
            }

            Console.WriteLine($"Сума чисел: {sum}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Мінімум: {min}");
            Console.WriteLine($"Добуток чисел: {product}");
            Console.WriteLine();

            // Завдання 3
            Console.WriteLine("Завдання 3");
            Console.Write("Введіть шестизначне число: ");
            string input = Console.ReadLine();

            if (input.Length == 6 && int.TryParse(input, out int number))
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversedNumber = new string(charArray);

                Console.WriteLine($"Результат: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("Введене число не є шестизначним або не є цілим числом.");
            }
            Console.WriteLine();

            // Завдання 4
            Console.WriteLine("Завдання 4");
            Console.Write("Введіть початкове число діапазону: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введіть кінцеве число діапазону: ");
            int end = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.Write("Числа Фібоначчі в заданому діапазоні: ");

            while (a <= end)
            {
                if (a >= start)
                {
                    Console.Write($"{a} ");
                }

                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();

            // Завдання 5
            Console.WriteLine("Завдання 5");
            Console.Write("Введіть число A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введіть число B (більше A): ");
            int B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
    }
    


