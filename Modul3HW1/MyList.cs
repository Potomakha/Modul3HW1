using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW1
{
    public class MyList<T>
    {
        private T[] _items;

        public MyList()
        {
            Capacity = 4;
            _items = new T[Capacity];
        }

        public MyList(int capacity)
        {
            Capacity = capacity;
            _items = new T[Capacity];
        }

        public MyList(IEnumerable<T> list)
        {
            _items = list.ToArray<T>();
        }

        public int Capacity { get; set; }
        public int Count { get; set; }
        public T this[int index] { get => _items[index]; set => _items[index] = value; }

        public void Add(T item)
        {
            if (Count < Capacity)
            {
                _items[Count] = item;
            }
            else
            {
                var newCapacity = Capacity * 2;
                var newItems = new T[newCapacity];

                Array.Copy(_items, newItems, Count);
                _items = newItems;
            }
        }
    }
}
