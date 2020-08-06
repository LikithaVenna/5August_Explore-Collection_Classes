using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary ld = new ListDictionary();
            ld.Add("Lucky", "Jakkula");
            ld.Add("Micky", "Jakkula");
            ld.Add("Likki", "Venna");
            foreach (DictionaryEntry item in ld)
            {
                Console.WriteLine("{0}=>{1}", item.Key, item.Value);
            }
            Console.WriteLine("count = {0}", ld.Count);
            Console.WriteLine("Is synchrozied:{0}", ld.IsSynchronized);
            Console.WriteLine(" fixed size:{0}", ld.IsFixedSize);
            Console.WriteLine("is readonly :{0}", ld.IsReadOnly);
            Console.WriteLine("-----------------Only keys------------");
            ICollection ic = ld.Keys;
            foreach (var s in ic)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------------Only values--------------");
            ICollection ic1 = ld.Values;
            foreach (var s in ic)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------get Enumerator-------------");
            IDictionaryEnumerator en = ld.GetEnumerator();

            while (en.MoveNext())
            {
                Console.WriteLine(en.Key + " --> " + en.Value);
            }
            Console.WriteLine("----------------contains the key-------------------");
            Console.WriteLine(ld.Contains("Likki"));
            Console.WriteLine("-------------copyTo Method------------------------------");
            Console.WriteLine(ld["Micky"]);
            ld["Likitha"] = "Raj";
            foreach (DictionaryEntry de in ld)
            {
                Console.WriteLine($"{de.Key}=>{de.Value}");
            }
            Console.ReadLine();
        }
    }
}
