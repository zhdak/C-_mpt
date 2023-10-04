using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");
            Console.Write("Введите номер операции: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 9.");
                continue;
            }

            double num1, num2;
            switch (choice)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;

                case 2:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;

                case 3:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;

                case 4:
                    Console.Write("Введите первое число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 == 0)
                        Console.WriteLine("Деление на ноль недопустимо.");
                    else
                        Console.WriteLine($"Результат: {num1 / num2}");
                    break;

                case 5:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    int exponent = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {Math.Pow(num1, exponent)}");
                    break;

                case 6:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    if (num1 < 0)
                        Console.WriteLine("Нельзя извлечь квадратный корень из отрицательного числа.");
                    else
                        Console.WriteLine($"Результат: {Math.Sqrt(num1)}");
                    break;

                case 7:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"1% от числа: {num1 * 0.01}");
                    break;

                case 8:
                    Console.Write("Введите число: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Факториал числа: {Factorial(num1)}");
                    break;

                case 9:
                    Console.WriteLine("Выход из программы.");
                    break;

                default:
                    Console.WriteLine("Некорректный выбор операции. Пожалуйста, введите число от 1 до 9.");
                    break;
            }
        } while (choice != 9);
    }

    static double Factorial(double n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }
}
