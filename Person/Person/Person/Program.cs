using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person chris = new Person();
            Console.Write("請輸入你的名字: ");
            chris.Title = Console.ReadLine();
            chris.Display();
            Console.ReadKey();
        }

    }
}
