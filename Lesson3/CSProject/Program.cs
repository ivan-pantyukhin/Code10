namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
        // цикл foreach, методы и алгоритмы массивов

        // 1. Сумма элементов массива
        // int[] numbers = { 5, 2, 7, 3, 2, 9 };
        // int result = 0;

        // foreach (int num in numbers)
        // {
            // result += num;
        // }
        // System.Console.WriteLine(result);


        // 2. Поиск максимального элемента
        // int[] numbers = { 5, 2, 7, 3, 2, 9 };
        // Array.Sort(numbers);
        // System.Console.WriteLine(numbers[0]);

        // Array
        // это то, что с вами писали
        
        // далее мое решение, так же можно делать, оно короче получается


        // сам массив
        int[] numbers = { 5, 2, 7, 3, 2, 9 };


        // 1. Сумма элементов массива
        int sum = numbers.Sum();
        Console.WriteLine($"Сумма элементов: {sum}");


        // 2. Поиск максимального элемента
        int max = numbers.Max();
        Console.WriteLine($"Максимальный элемент: {max}");


        // 3. Обратный порядок массива
        Array.Reverse(numbers);
        Console.WriteLine("Массив в обратном порядке: " + string.Join(", ", numbers));


        // 4. Четные числа в массиве
        Console.WriteLine("Четные числа:");
        foreach (int num in numbers.Where(num => num % 2 == 0))
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();


        // 5. Подсчет отрицательных чисел
        int negativeCount = numbers.Count(num => num < 0);
        Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");


        // 6. Линейный поиск
        int searchValue = 7;
        int searchIndex = Array.IndexOf(numbers, searchValue);
        Console.WriteLine($"Индекс элемента {searchValue}: {searchIndex}");


        // 7. Вывод элементов на нечетных позициях
        Console.WriteLine("Элементы на нечетных позициях:");
        for (int i = 1; i < numbers.Length; i += 2)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();


        // 8. Минимальное и максимальное значения
        int min = numbers.Min();
        max = numbers.Max();
        Console.WriteLine($"Минимальный элемент: {min}, Максимальный элемент: {max}");


        // 9. Сортировка массива (по возрастанию)
        Array.Sort(numbers);
        Console.WriteLine("Отсортированный массив: " + string.Join(", ", numbers));


        // 10. Замена элементов массива
        int[] replacedNumbers = numbers.Select(num => num < 0 ? 0 : num).ToArray();
        Console.WriteLine("Массив с заменой отрицательных на 0: " + string.Join(", ", replacedNumbers));


        // 11. Подмассив с максимальной суммой (пример для N=3)
        int n = 3;
        if (numbers.Length >= n)
        {
            int maxSum = int.MinValue;
            int startIndex = 0;
            for (int i = 0; i <= numbers.Length - n; i++)
            {
                int currentSum = numbers.Skip(i).Take(n).Sum();
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = i;
                }
            }
            Console.WriteLine($"Подмассив с максимальной суммой ({n} элементов): " + string.Join(", ", numbers.Skip(startIndex).Take(n)));
        }
        else
        {
            Console.WriteLine("Длина массива меньше N.");
        }



        // 12. Сортировка и анализ уникальных элементов
        Random random = new Random();
        int[] randomNumbers = Enumerable.Range(0, 10).Select(x => random.Next(1, 11)).ToArray(); // 10 случайных чисел от 1 до 10

        Array.Sort(randomNumbers);
        Console.WriteLine("Отсортированный массив случайных чисел: " + string.Join(", ", randomNumbers));
        int uniqueCount = randomNumbers.Distinct().Count();
        Console.WriteLine($"Количество уникальных элементов: {uniqueCount}");


        // 13. Частотный анализ
        var freq = numbers.GroupBy(x => x)
                         .Select(g => new { Value = g.Key, Count = g.Count() })
                         .OrderByDescending(x => x.Count)
                         .ToList();

        Console.WriteLine("Частотный анализ:");
        if(freq.Count > 0) {
            int maxCount = freq[0].Count;
            Console.WriteLine($"Число(а), встречающееся чаще всего ({maxCount} раз):");
            foreach (var item in freq.Where(x=> x.Count == maxCount))
            {
                Console.Write($"{item.Value} ");
            }
            Console.WriteLine();
        } else {
            Console.WriteLine("Массив пуст.");
        }

        Console.ReadKey();
    }
}

