using System;
namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            int s = 0;
            while (num > 0)
            {
                s = s + num % 10;
                num = num / 10;
            }
            Console.WriteLine(s);
        }
    }
}