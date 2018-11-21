using System;
using System.Collections.Generic;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("George");
            Console.WriteLine($"Hello World! from {student}");
            Console.Read();
        }
    }
}
