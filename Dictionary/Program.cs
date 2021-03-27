using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> List = new MyDictionary<string, string>();

            List.Add("1", "Masa");
            List.Add("2", "Kalem");
            List.Add("3", "Silgi");

            Console.WriteLine(List.GetValuesByKeys("1"));
            Console.WriteLine(List.GetValuesByKeys("2"));
            Console.WriteLine(List.GetValuesByKeys("3"));

        }
    }
}
