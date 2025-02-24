namespace readysolution;

class Program
{
    static void Main(string[] args)
    {
        // практика А
        //  Объявление переменных Создайте программу на псевдоязыке, которая объявляет различные переменные разных 
//типов данных (целочисленный, вещественный, строковый и логический) и выводит их значения на экран.
int age = 20;
Console.WriteLine($"Age: {age}");
double pi = 3.14;
Console.WriteLine($"pi: {pi}");
string name = "John";
Console.WriteLine($"name: {name}");
bool isMale = false;
Console.WriteLine($"isMale: {isMale}");
Console.ReadKey();

//Напишите программу, которая принимает два числа от пользователя и выполняет арифметические операции (сложение, 
//вычитание, умножение, деление) над ними, выводя результат каждой операции на экран.
 Console.WriteLine("Введите 1 число");
 int numeber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввелите 2 число");
 int numeber2 =Convert.ToInt32(Console.ReadLine());
 int sum = numeber1 + numeber2;
 Console.WriteLine($"sum: {sum}");
 int diff = numeber1 - numeber2;
  Console.WriteLine($"diff: {diff}");
  int mult = numeber1*numeber2;
  Console.WriteLine($"mult: {mult}");
  int division = numeber1/numeber2;
  Console.WriteLine($"division: {division}");
    }
}
