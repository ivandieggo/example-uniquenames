using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var list = new List<String>(names1);
            var list2 = new List<String>(names2);
            foreach (string i in list2.Where(c => !list.Contains(c)))
            {
                list.Add(i);
            }
            var distinct = list.Distinct().ToList();

            return distinct.ToArray();
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", Program.UniqueNames(names1, names2)));
            Console.ReadKey();
        }
    }
}
