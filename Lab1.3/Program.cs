using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1._3
{
    class Program
    {
        private static void Print(IEnumerable<string> quveryString)
        {
            foreach (string s in quveryString)
            {
                Console.Write(s + " | ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            /*
              First task
             */
            List<string> names = new List<string>() { "John", "Ada", "Dick", "Ronald", "Donald", "Mary", "Cortny", "Jack", "Chester", "Anna" };
            Console.WriteLine("**************** \n   Task one  \n****************\n");
            IEnumerable<string> queryOne = names.Select(m => m).Skip(3);
            Print(queryOne);

            /*
              Second task
             */
            Console.WriteLine("\n**************** \n   Task two   \n****************\n");
            IEnumerable<string> queryTwo = names.Where(m => m.Length > names.IndexOf(m));
            Print(queryTwo);

            /*
              Third task
             */

            Console.WriteLine("\n**************** \n   Task three  \n****************\n");
            string sentence = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

            var qveryThree = Regex.Split(sentence, @"\W").Where(x => x != "").GroupBy(w => w.Length).OrderByDescending(w => w.Key);
            int numberGroupWords = 0;
            foreach (IGrouping<int, string> words in qveryThree)
            {
                numberGroupWords++;
                Console.WriteLine($"Группа {numberGroupWords}. Длина {words.Key}. Количество {words.Count()}");
                foreach (var item in words)
                {
                    Console.WriteLine(item);
                }
            }

            /*
              Fourth task
             */
            Console.WriteLine("\n**************** \n   Task four   \n****************\n");
            string sentenceTwo = "This dog eats too much vegetables after lunch";

            Dictionary<string, string> _dictionaryEngRus = new Dictionary<string, string>();

            _dictionaryEngRus.Add("dog", "собака");
            _dictionaryEngRus.Add("this", "эта");
            _dictionaryEngRus.Add("eats", "ест");
            _dictionaryEngRus.Add("too", "слишком");
            _dictionaryEngRus.Add("much", "много");
            _dictionaryEngRus.Add("vegetables", "овощей");
            _dictionaryEngRus.Add("after", "после");
            _dictionaryEngRus.Add("lunch", "обеда");

            var qveryFour= sentenceTwo.ToLower().Split(' ')
                                    .Select(s => _dictionaryEngRus.Keys.Contains(s) 
                                    ? _dictionaryEngRus.FirstOrDefault(f => f.Key == s).Value : s);
  
            int _range = 3;

            for (int i = 0; i < qveryFour.Count(); i += _range)
            {
                var finalSentence = (String.Join(" ", qveryFour.Skip(i).Take(_range)).ToUpper());
                Console.WriteLine($"{finalSentence} ");
            }
            Console.ReadKey();
        }
    }
}
