using System;

class Program
{
    static void Main(string[] args)
    {
        //        Виклик функції для обчислення ребра куба за об'ємом
        Console.WriteLine("Н№1 Введіть об'єм куба:");
        double volume = Convert.ToDouble(Console.ReadLine());
        double edge = CalculateCubeEdge(volume);
        Console.WriteLine($"Ребро куба: {edge}");

        //  Перевірка чи є сума цифр двозначного числа непарною
        Console.WriteLine("Введіть двозначне число:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isSumOdd = IsSumOfDigitsOdd(number);
        Console.WriteLine($"Сума цифр непарна: {isSumOdd}");

        //  Знаходження невідомої дати
        Console.WriteLine("Введіть кількість днів, які пройшли:");
        int days = Convert.ToInt32(Console.ReadLine());
        DateTime unknownDate = FindUnknownDate(days);
        Console.WriteLine($"Невідома дата: {unknownDate}");

        // Виклик функції піднесення у квадрат суми двох цілих чисел
        Console.WriteLine("Введіть перше ціле число:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть друге ціле число:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = SquareOfSum(num1, num2);
        Console.WriteLine($"Квадрат суми: {result}");

        // Виклик функції для знаходження значення b за допомогою квадратного рівняння
        double a = 2; // Значення a (ввести своє значення)
        double b = SolveForB(a);
        Console.WriteLine("Значення b: " + b);
    }

    // Функція для обчислення ребра куба за об'ємом
    static double CalculateCubeEdge(double volume)
    {
        return Math.Pow(volume, 1.0 / 3.0);
    }

    // Функція для перевірки чи є сума цифр двозначного числа непарною
    static bool IsSumOfDigitsOdd(int number)
    {
        int sum = (number / 10) + (number % 10);
        return sum % 2 != 0;
    }

    // Функція для знаходження невідомої дати
    static DateTime FindUnknownDate(int days)
    {
        DateTime currentDate = DateTime.Now;
        return currentDate.AddDays(-days);
    }

    // Функція піднесення у квадрат суми двох цілих чисел
    static int SquareOfSum(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum * sum;
    }

    // Функція для знаходження значення b за допомогою квадратного рівняння
    static double SolveForB(double a)
    {
        double b;
        double delta = Math.Pow(a, 2) - 4 * 5 * a;

        // Розглядаємо тільки рішення, яке може бути реальним
        if (delta >= 0)
        {
            double root1 = (a + Math.Sqrt(delta)) / 2;
            double root2 = (a - Math.Sqrt(delta)) / 2;

            // Вибираємо реальне значення b
            b = (root1 >= 0) ? root1 : root2;
        }
        else
        {
            throw new Exception("Не існує реального розв'язку для b");
        }

        return b;
    }
}
