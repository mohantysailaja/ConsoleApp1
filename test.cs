// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace Practice
{
    class Subjects
    {
        public string brand = "Audi";
        public Subjects()
        {
            brand = "Audi";
        }
        public static void Main(string[] args)
        {
            Subjects veh = new Subjects();
            Console.WriteLine(veh.brand);
        }
    }
}
