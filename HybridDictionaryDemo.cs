using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Collections.Specialized;

namespace HybridDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HybridDictionary hd = new HybridDictionary();
            hd.Add("Likitha", "Raj");
            hd.Add("Jaya", "Krishna");
            hd.Add("Tushara", "Vunnava");
            hd.Add("Hema", "Sree");
            foreach (DictionaryEntry dic in hd)
            {
                Console.WriteLine($"{dic.Key}=>{dic.Value}");
            }
            Console.WriteLine("-------------using GetEnumerator------------------");
            IDictionaryEnumerator ide = hd.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine("{0}={1}", ide.Key, ide.Value);
            }
            Console.WriteLine("Is it Synchrozied :{0}", hd.IsSynchronized);
            Console.WriteLine("Readonly or not :{0}", hd.IsReadOnly);
            Console.WriteLine("fixed size:{0}", hd.IsFixedSize);
            Console.WriteLine("Count = {0}", hd.Count);
            Console.WriteLine("-----------------To get all Keys------------");
            ICollection i = hd.Keys;
            foreach (var k in i)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("-----------------To get all values------------");
            ICollection ic = hd.Values;
            foreach (var s in ic)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------Equals------------");
            HybridDictionary h = new HybridDictionary();
            h.Add("rama", "raj");
            h.Add("jaya", "krishna");
            h.Add("tushara", "vunnava");
            h.Add("aishu", "velchuri");
            Console.WriteLine(h.Equals(h));
        }
    }
}
