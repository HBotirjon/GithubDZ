using System;
using System.Linq;

namespace GithubDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = CalculateSum(numbers);
            Console.WriteLine($"Сумма элементов массива: {sum}");
        }
        static int CalculateSum(int[] arr)
        {
            return arr.Sum();
        }
    }
}
