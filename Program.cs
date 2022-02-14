using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Масть = s, Ранг = r };

            Console.WriteLine("Начальная колода");
            foreach (var c in startingDeck)
            {
                Console.WriteLine(c);
            }
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);

            Console.WriteLine("===================================");
            Console.WriteLine("Перетасовананя колода");
            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }
        }
        static IEnumerable<string> Suits()
        {
            yield return "Буби";
            yield return "Крести";
            yield return "Черви";
            yield return "Пики";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "Два";
            yield return "Три";
            yield return "ЧОтыре";
            yield return "Пять";
            yield return "Шесть";
            yield return "Семь";
            yield return "Восемь";
            yield return "Девять";
            yield return "Десять";
            yield return "Валет";
            yield return "Дама";
            yield return "Король";
            yield return "Туз";
        }
    }
}
