using System;

public class SimpleCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Введите второе число:");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                double sum = num1 + num2;
                Console.WriteLine($"Сумма: {sum}");
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
        Console.ReadKey(); // Пауза для просмотра результата
    }
}
