using DotNetMotors.classes;
using System;

namespace DotNetMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("These are all the things that are cool!");
            bool output1 = ThingsThatAreCool();
            Console.WriteLine(output1);

        }
        static bool ThingsThatAreCool(IIsCool iscool)
        {
            iscool.IsCool = true;
            return true;
        }
    }
}
