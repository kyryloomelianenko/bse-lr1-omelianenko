using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");

        // Запит першого числа
        Console.Write("Введіть перше число: ");
        int a = int.Parse(Console.ReadLine());

        // Запит другого числа
        Console.Write("Введіть друге число: ");
        int b = int.Parse(Console.ReadLine());

        // Обчислення суми
        int sum = a + b;

        // Виведення результату
        Console.WriteLine($"Результат: {a} + {b} = {sum}");
    }
}
