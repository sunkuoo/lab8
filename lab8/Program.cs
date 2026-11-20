using System;
namespace lab8
{
    public class Program
    {
        public static int SumEven(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            int sum = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                    sum += n;
            }
            return sum;
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите целые числа через пробел (пустая строка — выход):");
                string line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                    break;

                string[] parts = line.Split(new[] { ' ', ',', ';' },
                                            StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[parts.Length];
                bool ok = true;

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out numbers[i]))
                    {
                        Console.WriteLine($"Ошибка: \"{parts[i]}\" не является целым числом.\n");
                        ok = false;
                        break;
                    }
                }
                if (ok)
                    Console.WriteLine($"Сумма чётных чисел: {SumEven(numbers)}\n");
            }
        }
    }
}