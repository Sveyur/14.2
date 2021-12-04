using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Cat = new Cat();
            Dog Dog = new Dog();
            Cat.ShowInfo();
            Console.WriteLine();
            Dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Title { get; set; }
        public abstract string Name { get; set; }
        public abstract string Say { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Я " + Title);
            Console.WriteLine("Меня зовут " + Name);
            Console.WriteLine("Я говорю " + Say);
        }
    }
    class Cat : Animal
    {
        string title = "кот.";
        string name = "Барсик!";
        string say = "\"Мяу!\"";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say
        {
            get
            {
                return say;
            }
            set
            {
                say = value;
            }
        }
        public override string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
    }
    class Dog : Animal
    {
        string title = "собака.";
        string name = "Мухтар!";
        string say = "\"Гав!\"";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say
        {
            get
            {
                return say;
            }
            set
            {
                say = value;
            }
        }
        public override string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
    }
}