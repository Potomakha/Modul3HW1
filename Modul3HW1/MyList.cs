﻿using System;
using System.Collections;
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
            if (Count.Equals(Capacity))
            {
                Capacity *= 2;
                var newItems = new T[Capacity];

                Array.Copy(_items, newItems, Count);
                _items = newItems;
            }

            _items[Count] = item;
            Count++;
        }

        public void AddRange(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            if (_items.Contains(item))
            {
                var index = -1;

                for (var i = 0; i < Count; i++)
                {
                    if (_items[i].Equals(item))
                    {
                        index = i;
                    }
                }

                return RemoveAt(index);
            }

            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < Count && index >= 0)
            {
                for (var i = index; i < Count - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }

                Count--;
                return true;
            }

            return false;
        }

        public void CutToCount()
        {
            var newItems = new T[Count];
            Capacity = Count;
            Array.Copy(_items, newItems, Count);
            _items = newItems;
        }
    }
}
