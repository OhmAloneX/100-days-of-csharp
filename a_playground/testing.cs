using System;

namespace Playground
{
    class Testing
    {
        static void Main(string[] args)
        {
            int age = 20;
            double height = 172.44132434242343D;
            char middle = 'S';
            bool my_bool = true;
            string name = "M-jay";

            Console.WriteLine($"Hi, Im {name} {middle}. Vergonio, I'm {age} years of age. My height is {height:F2} and If you ask that I am currently studying my answer is {my_bool}! ");
        }
    }
}