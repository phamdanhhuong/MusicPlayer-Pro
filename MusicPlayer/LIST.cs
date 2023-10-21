using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class LIST<T> : IEnumerator, IEnumerable
    {
        T[] arr = new T[0];
        int count;
        int position = -1;
        public int Count { get { return count; } }
        public LIST(T[] arr)
        {
            this.arr = arr;
            this.count = arr.Length;
        }
        public LIST()
        {
            this.count = 0;
        }
        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            this.count++;
            arr[this.count - 1] = item;
        }
        public void Remove(T item)
        {
            int index = IndexOfItem(item);
            for (int i = index; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            this.count = arr.Length;
        }

        public int IndexOfItem(T item)
        {
            for (int i = 0; i < count; i++)
            {
                try
                {
                    if (arr[i].Equals(item))
                    {
                        return i;
                    }
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }

        public List<T> toList()
        {
            return arr.ToList();
        }

        /// <summary>
        /// Foreach
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < arr.Length);
        }
        //IEnumerable
        public void Reset()
        {
            position = -1;
        }
        //IEnumerable
        public object Current
        {
            get { return arr[position]; }
        }
    }
}
