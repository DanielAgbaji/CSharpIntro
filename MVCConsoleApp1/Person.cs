using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsoleApp1
{
    class Person
    {
        public string _firstName;
        public string _lastName;
        public byte _age;
        public byte _weight;
        public float _height;


        public Person(string firstName, string lastName, byte age, byte weight, float height)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weight = weight;
            _height = height;
        }

         public Person(){}

        public void Eat(Person person)
        {
            Console.WriteLine("Enter Person First Name");
            person._firstName = Console.ReadLine();
            Console.WriteLine("Enter Person last Name");
            person._lastName = Console.ReadLine();
            Console.WriteLine("Enter Person age Name");
            person._age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Person height Name");
            person._height = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Person weight Name");
            person._weight = Convert.ToByte(Console.ReadLine());

            string newPerson = person._firstName +" ";

            newPerson += person._lastName + " ";
            newPerson += person._age + " ";
            newPerson += person._height + " ";
            newPerson += person._weight + " ";

            Console.WriteLine("Welcome {0}", newPerson);
            Console.ReadLine();
        }

        public static void Walk()
        {

        }
    }
}
