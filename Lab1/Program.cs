using System;

/// Создание immutable типа данных

namespace Lab1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Vasya", "Pupkin");
            Console.WriteLine(p1.FirstName + " " + p1.SecondName);
            p1 = p1.ChangeValue("Petay", "Petrov");
            Console.WriteLine(p1.FirstName + " " + p1.SecondName);
            Console.ReadKey();
        }
    }

    internal class Person
    {
        private readonly string _firstName;
        private readonly string _secondName;
        public string FirstName { get { return _firstName; } }
        public string SecondName { get { return _secondName; } }

        public Person(string firsName, string secondName)
        {
            _firstName = firsName;
            _secondName = secondName;
        }

        public Person ChangeValue(string firsName, string secondName)
        {
            return new Person(firsName, secondName);
        }
    }
}
