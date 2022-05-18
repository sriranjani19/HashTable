
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable

{
    public class MyHashTable
    {

        public static void Node()
        {
            // Creates and initializes a new Hashtable.
            var myHT = new Hashtable();
            myHT.Add("1a", "Paranoids are not");
            myHT.Add("1b", "Paranoid");
            myHT.Add("1c", "Because they are");
            myHT.Add("2a", "Paranoid");
            myHT.Add("2b", "but because they keep");
            myHT.Add("2c", "putting themselves");
            myHT.Add("3a", "delibarately into paranoid");
            myHT.Add("3b", "avoidable");
            myHT.Add("3c", "situation");

            // Displays the Hashtable.
            Console.WriteLine("The Hashtable initially contains the following:");
            PrintKeysAndValues(myHT);

            // Removes the element with the key "3b".
            myHT.Remove("3b");

            // Displays the current state of the Hashtable.
            Console.WriteLine("After removing \"avoidable\":");
            PrintKeysAndValues(myHT);
        }

        public static void PrintKeysAndValues(Hashtable myHT)
        {
            foreach (DictionaryEntry de in myHT)
                Console.WriteLine($"    {de.Key}:    {de.Value}");
            Console.WriteLine();
        }
    }
}