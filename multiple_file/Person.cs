using System;

namespace Playground
{
    class Person
    {
        public string FirstName = "";
        public string LastName = "";

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {FirstName} {LastName}");
        }
    }
}
