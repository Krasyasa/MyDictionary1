using System;

namespace MyDictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryClass<string, int> dictionaryClass = new DictionaryClass<string, int> { };
            dictionaryClass.Add("Ahmet", 16);
            dictionaryClass.Add("Mehmet", 30);

            for (int i = 0; i < dictionaryClass.keys.Length; i++)
            {
                Console.WriteLine(dictionaryClass.keys[i].ToString() + " : " + dictionaryClass.values[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
