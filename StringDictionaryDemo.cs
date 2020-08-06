using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDictionary d = new StringDictionary();
            d.Add("Good", "Morning");
            d.Add("hello", "Noon");
            d.Add("hi", "Afternoon");
            d.Add("bad", "Evening");
            d.Add("chill", "Night");
            foreach (DictionaryEntry dic in d)
            {
                Console.WriteLine($"{dic.Key}=>{dic.Value}");
            }
            Console.WriteLine("-----------------Only values-------------------");
            foreach (string val in d.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("------------------Only Keys--------------------");
            foreach (string val in d.Keys)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("count ={0}", d.Count);
            Console.WriteLine("It it synchronzed:{0}", d.IsSynchronized);
            IEnumerator ie = d.GetEnumerator();
            DictionaryEntry de;
            while (ie.MoveNext())
            {
                de = (DictionaryEntry)ie.Current;
                Console.WriteLine($"{de.Key}=>{de.Value}");
            }
        }
    }
}
