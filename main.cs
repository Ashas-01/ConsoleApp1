using System;

namespace CalculatorApp
{
    internal class main
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("=== Калькулятор ===");
            Console.WriteLine();

            // Примеры работы
            Console.WriteLine($"5 + 3 = {calc.Add(5, 3)}");
            Console.WriteLine($"10 - 4 = {calc.Subtract(10, 4)}");
            Console.WriteLine($"6 * 7 = {calc.Multiply(6, 7)}");
            Console.WriteLine($"20 / 4 = {calc.Divide(20, 4)}");
            Console.WriteLine($"Факториал 5 = {calc.Factorial(5)}");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}