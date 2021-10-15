using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash hash = new Hash();
            while (true)
            {
                int keyInput = Convert.ToInt32(Console.ReadLine());
                string valueInput = Console.ReadLine();
                hash.input(keyInput, valueInput);
                hash.outputAll();
                int indexInput = Convert.ToInt32(Console.ReadLine());
                hash.output(indexInput);
            }
        }
    }
    class Hash
    {
        List<int> keys = new List<int>();
        List<string> values = new List<string>();
        public void outputAll()
        {
            for (int i = 0; i <= keys.Count - 1; i++)
            {
                Console.WriteLine(keys[i] + ": " + values[i]);
            }
        }
        public void output(int index)
        {
            int i = keys.IndexOf(index);
            Console.WriteLine(keys[i] + ": " + values[i]);
        }
        public void input(int key, string value)
        {
            if (!keys.Contains(key))
            {
                keys.Add(key);
                values.Add(value);
            }
            else Console.WriteLine("Key exists, choose another");
        }
    }
}
