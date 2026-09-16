using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаём массив из 10 случайных чисел в диапазоне [1, 100]
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101); // 101 не включается, диапазон [1, 100]
            }

            // 2. Выводим массив в одну строку
            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            // 3. Считаем сумму и произведение
            long sum = 0;
            double product = 1;
            foreach (int n in numbers)
            {
                sum += n;
                product *= n;
            }

            // 4. Считаем количество чётных
            int evenCount = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0) evenCount++;
            }

            // 5. Среднее арифметическое и количество чисел больше среднего
            double average = (double)sum / numbers.Length;
            int aboveAverage = 0;
            foreach (int n in numbers)
            {
                if (n > average) aboveAverage++;
            }

            // 6. Вывод результатов
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:F1}): {aboveAverage}");
        }
    }
}
