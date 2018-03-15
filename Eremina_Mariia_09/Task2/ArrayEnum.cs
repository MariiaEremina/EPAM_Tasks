using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ArrayEnum<T> : IEnumerator<T>
    {
        public T[] arr;

        int position = -1;

        public ArrayEnum(T[] list)
        {
            arr = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < arr.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public T Current
        {
            get
            {
                try
                {
                    return arr[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }


        }
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                Dispose();

                disposed = true;
            }
        }

    }

}
