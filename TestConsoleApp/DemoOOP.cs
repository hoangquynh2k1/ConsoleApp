using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    public class DemoOOP
    {
        interface IMamual
        {
            public void GiveBirth();
        }

        interface IWingedAnimal
        {
            public void Fly();
        }

        class Bat : IMamual, IWingedAnimal
        {

            public void GiveBirth()
            {
                Console.WriteLine("Bat can give direct birth");
            }
            public void Fly()
            {
                Console.WriteLine("Bat can fly");
            }
        }

        class Human
        {
            private string name;
            private DateTime dateOfBirth;

            public Human(string name, DateTime dateOfBirth)
            {
                this.name = name;
                this.dateOfBirth = dateOfBirth;
            }

            public void Speak()
            {
                Console.WriteLine("Hello! My name is "+ name + ", my birtday is"+  dateOfBirth);
            }

            public void Run()
            {
                Console.WriteLine(name + " run");
            }
        }

        class Student : Human
        {
            protected double gpa;
            public Student(string name, DateTime dateOfBirth, double gpa)
                : base(name, dateOfBirth)
            {
                this.gpa = gpa;
            }
        }

        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Animal speak");
            }
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Woof!");
            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Meow!");
            }
        }

        class Cow : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Moo!");
            }
        }

        class Calc
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }
    }
}
