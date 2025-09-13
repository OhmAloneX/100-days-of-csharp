using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use Person class
            Person p = new Person();
            p.FirstName = "M-jay";
            p.LastName = "Vergonio";
            p.Introduce();

            // Use MathHelper class
            MathHelper math = new MathHelper();
            int result = math.Add(10, 10);
            Console.WriteLine("Sum: " + result);
        }
    }
}
