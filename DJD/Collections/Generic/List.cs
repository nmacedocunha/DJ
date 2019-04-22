using System;

namespace DJD.Collections.Generic
{
    public class List<T>
    {
        private int _count;
        private T[] _arrayList;

        public int Length
        {
            get { return _count; }
        }

        public List()
        {
            _count = 0;
            _arrayList = new T[_count];
        }

        public void AddItem(T item)
        {
            T[] array = new T[++_count];

            for (int i = 0; i < _arrayList.Length; i++)
            {
                array[i] = _arrayList[i];
            }

            array[array.Length - 1] = item;

            _arrayList = array;
        }

        public void Remove()
        {
            _count--;
            T[] array = new T[_count];

            for (int i = 1; i < _arrayList.Length; i++)
            {
                array[i - 1] = _arrayList[i];
            }

            _arrayList = array;
        }

        public T this[int i]
        {
            get
            {
                return _arrayList[i];
            }

        }
    }
}