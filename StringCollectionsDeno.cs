using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace StringCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection sl = new StringCollection();
            sl.Add("Likitha");
            sl.Add("Jai");
            sl.Add("Tush");
            sl.Add("Aish");
            sl.Add("Hema");
            sl.Add("Ramya");
            StringEnumerator se = sl.GetEnumerator();
            while (se.MoveNext())
            {
                Console.WriteLine(se.Current);
            }
            Console.WriteLine("count = {0}", sl.Count);
            Console.WriteLine("count is: {0}", sl.Count);
            Console.WriteLine("Is it synchrozied  :{0}", sl.IsSynchronized);
            Console.WriteLine("Readonly :{0}", sl.IsReadOnly);
            Console.WriteLine("-----------------------using Remove method-----------------");
            String[] s1 = new String[] { "Likki", "Micky", "Lucky", "Chicky"};
            sl.Remove("apples");
            Console.WriteLine("After removing---------------");
            foreach (var v in sl)
            {
                Console.WriteLine(v);
            }
            String[] s2 = new String[] { "Likki", "Micky", "Lucky", "Chicky" };
            sl.AddRange(s2);
            foreach (Object obj in sl)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.ReadLine();
        }
    }
}
