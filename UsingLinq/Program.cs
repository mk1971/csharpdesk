using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var samplesLinq = new SamplesLinq();
            samplesLinq.UsingIEnumerable(Enumerable.Range(1, 50));
            Console.WriteLine("");
            samplesLinq.UsingProjection(Enumerable.Range(1, 50));
            Console.WriteLine("");
            samplesLinq.UsingOrderBy(new[] { "A", "C", "B", "E", "Q" });
            Console.WriteLine("");
            samplesLinq.UsingFacilitators(new[] { "A", "B", "A", "C", "A", "D" });
            Console.WriteLine("");
            samplesLinq.UsingAggregates(Enumerable.Range(1, 50));
            Console.WriteLine("");
            samplesLinq.UsingDictionary(new Dictionary<string, string>() { { "1", "B" }, { "2", "A" }, { "3", "B" }, { "4", "A" }, });
            Console.WriteLine("");
            samplesLinq.UsingDictionary(
                new Dictionary<string, string>() { { "1", "B" }, { "2", "A" }, { "3", "B" }, { "4", "A" }, },
                new Dictionary<string, string>() { { "5", "B" }, { "6", "A" }, { "7", "B" }, { "8", "A" }, });
        }

        public class SamplesLinq
        {
            public void UsingIEnumerable(IEnumerable<int> data)
            {
                var method = // IEnumerable<string>
                     data.Where(x => x % 2 == 0)
                     .Select(x => x.ToString());
                Console.WriteLine(string.Join(",", method));

                var query = // IEnumerable<string>
                    from d in data
                    where d % 2 == 0
                    select d.ToString();
                Console.WriteLine(string.Join(",", query));
            }

            public void UsingProjection(IEnumerable<int> data)
            {
                var projection =
                    from d in data
                    select new
                    {
                        Even = (d % 2 == 0),
                        Odd = !(d % 2 == 0),
                        Value = d,
                    };
                Console.WriteLine(string.Join(",", projection));
            }

            public void UsingOrderBy(IEnumerable<string> letters)
            {
                var sortAsc =
                    from d in letters
                    orderby d ascending
                    select d;
                Console.WriteLine(string.Join(",", sortAsc));

                var sortDesc =
                    letters.OrderByDescending(x => x);
                Console.WriteLine(string.Join(",", sortDesc));
            }

            public void UsingFacilitators(IEnumerable<string> values)
            {
                var distinct = values.Distinct();
                Console.WriteLine(string.Join(",", distinct));
                var first = values.First();
                Console.WriteLine(string.Join(",", first));
                var firstOr = values.FirstOrDefault();
                Console.WriteLine(string.Join(",", firstOr));
                var last = values.Last();
                Console.WriteLine(string.Join(",", last));
                var page = values.Skip(2).Take(2);
                Console.WriteLine(string.Join(",", page));
            }

            public void UsingAggregates(IEnumerable<int> numbers)
            {
                var any = numbers.Any(x => x % 2 == 0);
                Console.WriteLine(string.Join(",", any));
                var count = numbers.Count(x => x % 2 == 0);
                Console.WriteLine(string.Join(",", count));
                var sum = numbers.Sum();
                Console.WriteLine(string.Join(",", sum));
                var max = numbers.Max();
                Console.WriteLine(string.Join(",", max));
                var min = numbers.Min();
                Console.WriteLine(string.Join(",", min));
                var avg = numbers.Average();
                Console.WriteLine(string.Join(",", avg));
            }

            public void UsingDictionary(Dictionary<string, string> dictionary)
            {
                var group = // IEnumerable<string, IEnumerable<string>>
                    from d1 in dictionary
                    group d1 by d1.Value into g
                    select new
                    {
                        Key = g.Key,
                        Members = g,
                    };
                Console.WriteLine(string.Join(",", group));
            }

            public void UsingDictionary(Dictionary<string, string> dictionary1, Dictionary<string, string> dictionary2)
            {
                var join =
                    from d1 in dictionary1
                    join d2 in dictionary2 on d1.Value equals d2.Value
                    select new
                    {
                        Key1 = d1.Key,
                        Key2 = d2.Key,
                        Value = d1.Value
                    };
                Console.WriteLine(string.Join(",", join));
            }
        }
    }
}
