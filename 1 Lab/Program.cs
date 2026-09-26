using System;

namespace LabWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задача 1");
            Task1();

            Console.WriteLine();
            Console.WriteLine("Задача 2");
            Task2();

            Console.WriteLine();
            Console.WriteLine("Задача 3");
            Task3();

        }
        
        static void Task1()
        {
            Console.Write("Введите целое число n: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Введите целое число m: ");
            int m = int.Parse(Console.ReadLine()!);

            int n1 = n, m1 = m;
            int result1 = n1++ * m1;            
            Console.WriteLine($"1) n++ * m = {result1}   (после вычисления: n={n1}, m={m1})");

            int n2 = n, m2 = m;
            bool result2 = n2++ < m2;               
            Console.WriteLine($"2) n++ < m = {result2}   (после вычисления: n={n2}, m={m2})");

            int n3 = n, m3 = m;
            bool result3 = --m3 > n3;                
            Console.WriteLine($"3) --m > n = {result3}   (после вычисления: n={n3}, m={m3})");

            Console.Write("Введите вещественное число x: ");
            double x = double.Parse(Console.ReadLine()!);
            
            if (x + 4 < 0)
            {
                Console.WriteLine("4) Выражение нельзя вычислить: под корнем (x + 4) отрицательное число.");
                Console.WriteLine("Требуется, чтобы x >= -4.");
            }
            else
            {
                double result4 = Math.Pow(2, -x) * Math.Sqrt(x + 4) * Math.Sqrt(Math.Abs(x));
                Console.WriteLine($"4) 2^(-x) * sqrt(x+4) * sqrt(|x|) = {result4}");
            }
        }
        
        static void Task2()
        {
            Console.Write("Введите координату X1: ");
            double x1 = double.Parse(Console.ReadLine()!);

            Console.Write("Введите координату Y1: ");
            double y1 = double.Parse(Console.ReadLine()!);

            bool inside =
                (-x1 / 7.0 + y1 / 5.0 <= 1) &&  
                ( x1 / 3.0 + y1 / 5.0 <= 1) && 
                ( x1 / 3.0 - y1 / 5.0 <= 1) &&  
                (-x1 / 7.0 - y1 / 5.0 <= 1);   

            Console.WriteLine($"Точка ({x1}; {y1}) принадлежит заштрихованной области: {inside}");
        }
        
        static void Task3()
        {
            double a = 1000;
            double b = 0.0001;

            float af = (float)a;
            float bf = (float)b;
            float cFloat = (float)Math.Pow(af + bf, 2);

            double cDouble = Math.Pow(a + b, 2);

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"float:  c = (a+b)^2 = {cFloat:F10}");
            Console.WriteLine($"double: c = (a+b)^2 = {cDouble:F10}");
        }
    }
}