using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно");

            return a / b;
        }

        public long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал определён только для неотрицательных чисел");

            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public int BadMethod(int a, int b, int c, int d, int e)
{
    // Куча code smells + плохие практики
    int x = 0;
    int y = 0;
    int z = 0;
    int result = 0;

    if (a > 0)
    {
        if (b > 0)
        {
            if (c > 0)
            {
                if (d > 0)
                {
                    if (e > 0)
                    {
                        x = a + b;
                        y = c + d;
                        z = e * 2;
                        result = x + y + z;
                    }
                    else
                    {
                        result = a * b * c * d * e;
                    }
                }
                else
                {
                    result = a - b - c - d - e;
                }
            }
            else
            {
                result = a * a * a;
            }
        }
        else
        {
            result = b * b;
        }
    }
    else
    {
        result = -1;
    }

    // Дублирование кода
    if (result > 100)
    {
        Console.WriteLine("Большое число");
        Console.WriteLine("Большое число");
        Console.WriteLine("Большое число");
    }

    // Плохие имена + магические числа
    int temp1 = result * 42;
    int temp2 = temp1 / 7;
    int temp3 = temp2 + 13;

    // Пустой catch (очень плохо)
    try
    {
        int crash = 10 / a;
    }
    catch
    {
    }

    // Ещё одно дублирование
    if (temp3 > 50)
    {
        Console.WriteLine("Большое число");
        Console.WriteLine("Большое число");
    }

    return temp3;
}
    }
}
