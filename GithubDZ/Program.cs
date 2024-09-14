using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив с некоторыми значениями
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Вызываем метод для вычисления суммы
            int sum = CalculateSum(numbers);

            // Выводим результат
            Console.WriteLine("Сумма элементов массива: " + sum);
        }

        static int CalculateSum(int[] arr)
        {
            // Инициализируем переменную для суммы
            int sum = 0;

            // Проходим по всем элементам массива
            for (int i = 0; i < arr.Length; i++)
            {
                // Добавляем текущий элемент к сумме
                sum += arr[i];
            }

            // Возвращаем итоговую сумму
            return sum;
        }
    }
}
