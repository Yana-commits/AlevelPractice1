using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv2_Practise1
{
    public class MyArray<T> : IReadOnlyCollection<T>
    {
        private T[] array;

        private int currentIndex = 0;

        public int Count { get; private set; }

        public T[] Array { get => array; set => array = value; }

        public MyArray(int arrayLenth)
        {
            Array = new T[arrayLenth];
        }
        public T[] Append( T item)
        {
            if (Array == null)
            {
                return new T[] { item };
            }
            T[] result = new T[Array.Length + 1];
            Array.CopyTo(result, 0);
            result[Array.Length] = item;
            return result;
        }

        public T[] AppendArr(T[] list)
        {
          
            T[] result = new T[Array.Length + list.Length];
            for(int i =0;i < list.Length; i++)
            {
                 result[Array.Length+i] = (T)list[i];
            }
           
            return result;
        }

        public T[] Remove( T item)
        {
            T[] result = new T[Array.Length - 1];
            int index = result.Length;

            for (int i = 0; i < result.Length; i++)
            {
                if (Array[i].Equals(item))
                {
                    index = i;
                    continue;
                }

                if (i < index)
                {
                    result[i] = Array[i];
                }
                else if (i > index)
                {
                    result[i-1] = Array[i-1];
                }
            }

            return result;
        }
        public T[] RemoveIndex( int index)
        {
            T[] result = new T[Array.Length -1];

            for (int i = 0; i < result.Length; i++)
            {
                if (i < index)
                {
                    result[i] = Array[i];
                }
                else if (i > index)
                {
                    result[i - 1] = Array[i];
                }
            }
           
            return result;
        }

        public void Sort(IComparer<T> comparer)
        {
            System.Array.Sort(array, comparer);
        }

        public void First()
        {
            currentIndex = 0;
        }

        public void Next()
        {
            currentIndex++;
        }

        public T CurrentItem(T[] array)
        {
            if (!IsDone(array))
            {
                return array[currentIndex];
            } 
            else
            {
                throw new NotImplementedException("Error");
            }
        }

        public bool IsDone(T[] array)
        {
            return currentIndex >= array.Count();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
