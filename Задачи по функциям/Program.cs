using System;
using System.Linq;

class Program
{
    // 1. Функция, которая принимает два целых числа и возвращает их сумму
    static int Sum(int a, int b) => a + b;

    // 2. Функция, которая принимает радиус окружности и возвращает ее площадь
    static double CircleArea(double radius) => Math.PI * Math.Pow(radius, 2);

    // 3. Функция, которая принимает строку и возвращает ее длину
    static int StringLength(string str) => str.Length;

    // 4. Функция, которая принимает массив целых чисел и возвращает наибольшее значение в массиве
    static int MaxValue(int[] array) => array.Max();

    // 5. Функция, которая принимает число и возвращает его факториал
    static long Factorial(int n)
    {
        if (n <= 1) return 1;
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // 6. Функция, которая принимает строку и проверяет, является ли она палиндромом
    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    // 7. Функция, которая принимает два массива целых чисел и возвращает новый массив, содержащий элементы обоих массивов
    static int[] MergeArrays(int[] array1, int[] array2) => array1.Concat(array2).ToArray();

    // 8. Функция, которая принимает число и возвращает true, если оно простое, и false в противном случае
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // 9. Функция, которая принимает строку и возвращает ее в обратном порядке
    static string ReverseString(string str) => new string(str.Reverse().ToArray());

    // 10. Функция, которая принимает двумерный массив чисел и возвращает сумму всех элементов
    static int Sum2DArray(int[,] array)
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        // Вывод задач в консоль
        Console.WriteLine("1. Sum(3, 5): " + Sum(3, 5));
        Console.WriteLine("2. CircleArea(5): " + CircleArea(5));
        Console.WriteLine("3. StringLength(\"hello\"): " + StringLength("hello"));
        Console.WriteLine("4. MaxValue(new int[] { 1, 2, 3, 4, 5 }): " + MaxValue(new int[] { 1, 2, 3, 4, 5 }));
        Console.WriteLine("5. Factorial(5): " + Factorial(5));
        Console.WriteLine("6. IsPalindrome(\"radar\"): " + IsPalindrome("radar"));
        Console.WriteLine("7. MergeArrays(new int[] { 1, 2 }, new int[] { 3, 4 }): " + string.Join(", ", MergeArrays(new int[] { 1, 2 }, new int[] { 3, 4 })));
        Console.WriteLine("8. IsPrime(7): " + IsPrime(7));
        Console.WriteLine("9. ReverseString(\"world\"): " + ReverseString("world"));
        Console.WriteLine("10. Sum2DArray(new int[,] { { 1, 2 }, { 3, 4 } }): " + Sum2DArray(new int[,] { { 1, 2 }, { 3, 4 } }));

        Console.ReadLine(); 
    }
}
