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
            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }

            Console.WriteLine("Delet odd items");
            for (var i = 0; i < count; i += 2)
            {
                list.Remove(stringArray[i]);
            }

            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }

            list.CutToCount();
            var item = list[2];
            Console.WriteLine(list.ToString());
        }
    }
}
