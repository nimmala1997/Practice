using System;
namespace Practice.Example
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"My name is {Name}. I am {Age} years old");
        }

        public void SayHello(string friend)
        {
            Console.WriteLine($"{Name} says hello to {friend}");
        }
    }
}

