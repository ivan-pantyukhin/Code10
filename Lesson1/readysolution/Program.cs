using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int number2 = 0;

        // Практика А

        // Объявление переменных разных типов данных и вывод их значений
        int age = 20;
        Console.WriteLine($"Age: {age}");

        double pi = 3.14;
        Console.WriteLine($"Pi: {pi}");

        string name = "John";
        Console.WriteLine($"Name: {name}");

        bool isMale = false;
        Console.WriteLine($"Is Male: {isMale}");


        // Арифметические операции с двумя числами
        Console.WriteLine("Введите первое число:");

    ;

        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            Console.WriteLine("Введите второе число:");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Некорректный ввод второго числа.");
            }
            else
            {
                int sum = number1 + number2;
                Console.WriteLine($"Сумма: {sum}");

                int diff = number1 - number2;
                Console.WriteLine($"Разность: {diff}");

                int mult = number1 * number2;
                Console.WriteLine($"Произведение: {mult}");

                if (number2 != 0) //Проверка на деление на ноль
                {
                    double division = (double)number1 / number2; // Преобразование в double для точного результата
                    Console.WriteLine($"Частное: {division}");
                }
                else
                {
                    Console.WriteLine("Деление на ноль невозможно!");
                }
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод первого числа.");
        }


        // Условие с проверкой на дождь
        Console.WriteLine("На улице идет дождь? (да/нет)");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
        string answer = Console.ReadLine().ToLower(); // Преобразование в нижний регистр для большей точности
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        if (answer == "да")
        {
            Console.WriteLine("Не забудьте зонт!");
        }
        else
        {
            Console.WriteLine("Можно без зонта!");
        }


        // Цикл for
        Console.WriteLine("Цикл for:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i); // 0 1 2 3 4
        }


        // Сравнение двух чисел
        Console.WriteLine("Введите первое число для сравнения:");
        if (int.TryParse(Console.ReadLine(), out number1))
        {
            Console.WriteLine("Введите второе число для сравнения:");
            if (int.TryParse(Console.ReadLine(), out number2))
            {
                if (number1 < number2)
                {
                    Console.WriteLine($"Меньшее число: {number1}");
                    Console.WriteLine($"Большее число: {number2}");
                }
                else if (number1 > number2)
                {
                    Console.WriteLine($"Меньшее число: {number2}");
                    Console.WriteLine($"Большее число: {number1}");
                }
                else
                {
                    Console.WriteLine("Числа равны");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод второго числа.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод первого числа.");
        }


        // Практика В
        Master(); //Вызов функции master

        Console.ReadKey(); //Задержка консоли для просмотра результатов

        void Master()
        {
            Console.WriteLine("Введите ваше имя: ");
            Console.WriteLine("Здравствуйте, " + Console.ReadLine() + "! Введите год вашего рождения:");

            if (int.TryParse(Console.ReadLine(), out int birthYear))
            {
                int age = DateTime.Now.Year - birthYear;
                Console.WriteLine($"{age} - Ваш возраст");
            }
            else
            {
                Console.WriteLine("Некорректный ввод года рождения.");
            }
        }
    }
}