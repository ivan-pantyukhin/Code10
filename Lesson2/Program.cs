using System;

public class Arrays
{
    public static void Main(string[] args)
    {
        // Практика А

        // 1. Объявление массива целых чисел длины 5
        int[] intArray = new int[5];

        // 2. Инициализация массива из трех строк
        string[] stringArray = { "Строка 1", "Строка 2", "Строка 3" };


        // Практика B

        // 3. Доступ к элементам массива
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Второй элемент: " + numbers[1]); // Вывод второго элемента (индекс 1)
        numbers[2] = 100; // Изменение третьего элемента (индекс 2)
        Console.WriteLine("Третий элемент после изменения: " + numbers[2]);

        // 4. Длина массива
        Console.WriteLine("Длина массива numbers: " + numbers.Length);


        // Практика C

        // 5. Объявление и инициализация пустого массива длины 4
        int[] emptyArray = new int[4]; // Инициализация нулями


        // 6. Создание массива с помощью оператора new (аналогично пункту 1, new в C# используется при объявлении)
        int[] newArray = new int[5];
        newArray[0] = 1;
        newArray[1] = 2;
        newArray[2] = 3;
        newArray[3] = 4;
        newArray[4] = 5;


        // 7. Инициализация массива символов
        char[] charArray = { 'A', 'B', 'C' };


        // 8. Заполнение массива данными вручную (аналогично пункту 6)
        int[] manualArray = new int[5];
        manualArray[0] = 10;
        manualArray[1] = 20;
        manualArray[2] = 30;
        manualArray[3] = 40;
        manualArray[4] = 50;


        Console.ReadKey(); // Задержка консоли для просмотра результатов
    }
}
