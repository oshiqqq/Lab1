using System;
using System.Linq;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 4, 7, 7, 1, 8, 9, 3, 62 };
            Console.WriteLine("Начальный Массив:");
            Console.WriteLine(string.Join(" ", ints));
            Func.BubbleSort(ints);
            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine(string.Join(" ", ints));
 
            Console.Write("Введите строку для проверки на палиндром: ");
            string inputString = Console.ReadLine();
            Console.WriteLine($"Является ли строка палиндромом: {Func.IsPalindrome(inputString)}");

            Console.WriteLine($"Факториал числа 5: {Func.Factorial(5)}");
            Console.WriteLine($"Число 13 простое: {Func.IsPrimeNumber(13)}");
            Console.WriteLine($"Число Фибоначчи на позиции 8: {Func.Fibonacci(8)}");
            Console.WriteLine($"Текущее число: 321 \nРезультат: {Func.ReverseDigits(321)}");
            Console.WriteLine($"Текущее число: 3214 \nРезультат: {Func.IntToRoman(3214)}");
            Console.WriteLine("Cтрока: Всем привет с вами я! \nПодстрока: привет с");
            Console.WriteLine($"Результат: {Func.FindSubstring("Всем привет с вами я!", "привет с")}");


        }
    }

    public static class Func
    {
        public static int[] BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static bool IsPalindrome(string str)
        {
            str = new string(str.Where(c => Char.IsLetter(c)).ToArray()).ToLower();
            int length = str.Length;
            if (length <= 1) return false;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Ошибка: Входное число должно быть не меньше 0.");
                return 0;
            }
            else if (number == 0) return 1;

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int a = 0; // 0 1 1 2 3 5 8 13
            int b = 1; // 1 1 2 3 5 8 13 21
            int fib = 0; //1 1 2 3 5 8 13 21 
            for (int i = 2; i <= n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }
            return fib;
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int ReverseDigits(int x)
        {
            long result = 0;
            bool isNegative = x < 0;
            x = Math.Abs(x);

            while (x != 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }

            if (isNegative)
            {
                result = -result;
            }

            // Проверка на переполнение 32-битного целого числа
            if (result > int.MaxValue || result < int.MinValue)
            {
                return 0;
            }

            return (int)result;
        }
        public static string IntToRoman(int num)
        {
            if (num < 1 || num > 3999)
            {
                throw new ArgumentOutOfRangeException(nameof(num), "Число должно быть в диапазоне от 1 до 3999.");
            }

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            //3214 MMMCCXIV
            //3214/1000 =  3  - MMMM
            //214 / 100 = 2 - СС 
            //14 / 10 = 1 - X 
            // 4 = 4 - IV
            return thousands[num / 1000] +
                   hundreds[(num % 1000) / 100] +
                   tens[(num % 100) / 10] +
                   ones[num % 10];
        }
        public static bool FindSubstring(string text, string pattern)
        {
            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return true;
            }
            return false;
        }


    }
}
