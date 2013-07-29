using System;
using System.Collections;

namespace Exceptions
{
    class SmartArray : System.Collections.IEnumerable
    {
          int[] arr;

        public SmartArray()
        {
            arr = new int[1];
        }

        public SmartArray(int n)
        {
            arr = new int[n];
        }

        public int this[int pos]
        {
            get
            {
                if (Math.Abs(pos) > this.arr.Length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return (pos > 0) ? arr[pos] : arr[this.arr.Length - pos];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
