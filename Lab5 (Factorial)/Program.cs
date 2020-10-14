using Microsoft.VisualBasic;
using System;
using System.Threading;

namespace Lab5__Factorial_
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildFrame(CalcFactorial(GetData()));
        }
        static long CalcFactorial(long n)
        {
            if (n == 0) return 1;
            return n * CalcFactorial(n - 1);
        }
        static void BuildFrame(long n)
        {
            bool color = true;
            int width = (n.ToString()).Length;
            while (1 != 0)
            {
                if (color == true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else Console.ResetColor();
                Console.Clear();
                BuildLine(width);
                Console.WriteLine($"||{n}||");
                BuildLine(width);
                Thread.Sleep(500);
                color = !color;
            }
        }
        static void BuildLine(int n)
        {
            Console.Write("||");
            for (int i = 0; i < n; i++) Console.Write("=");
            Console.WriteLine("||");
        }

        static int GetData()
        {
            bool err = false;
            int answerint;
            do
            {
                Console.WriteLine("Введите число, от которого нужно получить факториал.");
                string answerstring = Console.ReadLine();
                if (!int.TryParse(answerstring, out answerint)) err = true;
                if (err == true) Console.WriteLine("Введено недопустимое значение.");
            }
            while (err == true);
            return (answerint);

        }
    }

}
