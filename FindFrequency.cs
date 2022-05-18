

   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;   
namespace MyHashTable
{
    public class HashTable
    {


        public static void MyMapNode()
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "TO BE");
            HT.Add(2, "NOT TO BE");
            foreach (object i in HT.Keys)
                Console.WriteLine(i);
            foreach (object J in HT.Values)
                Console.WriteLine(J);
            foreach (DictionaryEntry di in HT)
                Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
            Console.ReadKey();

        }

        internal void Add(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void Remove(string v)
        {
            throw new NotImplementedException();
        }
    }
}