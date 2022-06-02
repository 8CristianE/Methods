using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite sport?");
            var sport = Console.ReadLine();

            Console.WriteLine("What is your favorite programming language");
            var planguage = Console.ReadLine();

            Console.WriteLine($"Hello {name}, I can see your favorite color is {color}" +
                $" and your favorite sport is {sport}. Your favorite programming lanuage" +
                $" is {planguage}!!!");

            Console.WriteLine(Add(10, 2));
            Console.WriteLine(Multiply(5, 5));
            Console.WriteLine(Addd(3, 7, 5, 6));
        }
        public static int Add(int num1, int num2)

        {
            return num1 + num2;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Addd(params int[] nums)
        {
            var sum = 0;

            foreach(var num in nums)
            {
                sum += num;
            }
            return sum;
        }
    }

}

