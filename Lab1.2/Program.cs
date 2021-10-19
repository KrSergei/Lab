using System;

namespace Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pub = new Publisher();
            var person1 = new Person(1, pub);
            var person2 = new Person(2, pub);

            pub.SendReward();
            Console.ReadKey();
        }
    }
}
