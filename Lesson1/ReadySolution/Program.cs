namespace ReadySolution;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Практика А

        // Создайте программу, которая объявляет различные переменные разных типов данных 
        // (целочисленный, вещественный, строковый и логический) и выводит их значения на экран.  

        int age = 20; 
        Console.WriteLine($"Age: {age}");

        double pi = 3.14;
        Console.WriteLine($"Pi: {pi}");

        string name = "John";
        Console.WriteLine($"Name: {name}");
        
        bool isMale = false;
        Console.WriteLine($"IsMale: {isMale}");

        // Напишите программу, которая принимает два числа от пользователя и выполняет арифметические операции (сложение, вычитание, умножение, деление) 
        // над ними, выводя результат каждой операции на экран.
        
        Console.WriteLine("Введите первое число:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        Console.WriteLine($"Сумма: {sum}");

        int diff = number1 - number2;
        Console.WriteLine($"Разность: {diff}");

        // Умножение *
        // Деление /

        // Напишите программу, которая принимает строку от пользователя, содержащую число, и конвертирует его в целое число. 
        // Затем увеличьте это число на 5 и выведите результат.
        
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        int total = number + 5;
        Console.WriteLine($"Total: {total}");
    }
}
