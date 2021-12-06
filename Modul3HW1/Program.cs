using System;

namespace Modul3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int count = 10;
            var list = new MyList<string>();
            var stringArray = new string[count];

            for (var i = 0; i < count; i++)
            {
                stringArray[i] = $"iterator - {i}";
                list.Add(stringArray[i]);
            }

            Console.WriteLine("list filled");
            DisplayList(list);

            Console.WriteLine("Delet odd items and revers list");
            for (var i = 0; i < count; i += 2)
            {
                list.Remove(stringArray[i]);
            }

            list.Reverse();
            DisplayList(list);

            Console.WriteLine("Sort again");
            list.Sort();
            DisplayList(list);

            var item = list[2];
            Console.WriteLine(list.ToString());
        }

        public static void DisplayList(MyList<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
    }
}
