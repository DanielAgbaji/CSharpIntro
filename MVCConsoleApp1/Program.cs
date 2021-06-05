using System;
using System.ComponentModel.DataAnnotations;

namespace MVCConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age = 10;
            Person person = new Person();
            person.Eat(person);
            Console.ReadLine();
        }
    }
}
