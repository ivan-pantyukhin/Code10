using System;

public class GuessTheNumber
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Загадываем число от 1 до 100
        int guess;
        int attempts = 0;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число от 1 до 100.");

        do
        {
            Console.Write("Введите ваше предположение: ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                attempts++;
                if (guess < secretNumber)
                {
                    Console.WriteLine("Слишком мало!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Слишком много!");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число за {attempts} попыток!");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте ещё раз.");
            }
        } while (guess != secretNumber);

        Console.ReadKey(); // Пауза для просмотра результата
    }
}
