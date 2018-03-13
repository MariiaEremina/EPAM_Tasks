using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T> where T : new()

    {
        private T[] arr;
        private T[] arr1;

        public DynamicArray()
        {
            arr = new T[8];
            for (int i = 0; i < 8; i++)
            {
                arr[i] = default(T);
            }
        }

        public DynamicArray(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                arr = new T[number];
                for (int i = 0; i < number; i++)
                {
                    arr[i] = default(T);
                }
            }
        }

        public DynamicArray(T[] arr)
        {
            this.arr = arr;
        }

        public T this[int index]
        {
            get
            {
                if (index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Add(T item)
        {
            if (Length == Capacity)
            {
                int n = arr.Length;
                arr1 = arr;
                arr = new T[n * 2];
                //for (int i = 0; i < arr1.Length; i++)
                //{
                //    arr[i] = arr1[i];
                //}
                Fill(arr, arr1, 0, n, 0,0);
                arr[arr1.Length] = item;
            }
            else
            {
                int i = 0;
                while (!(arr[i].Equals(default(T))))
                {
                    i++;
                }
                arr[i] = item;
            }
        }

        public void AddRange(T[] item)
        {
            int l = item.Length;
            int l1 = Length;

            bool insert = false;
            if ((Capacity - Length) >= l)
            {
                int i = 0;
                int n = 0;
                while (((n + i) < arr.Length - 1) && (n != l - 1))
                {
                    while (!(arr[i].Equals(default(T))))
                    {
                        i++;
                    }
                    while ((arr[i + n].Equals(default(T))) && ((n + i) < arr.Length) && (n != l - 1))
                    {
                        n++;
                    }
                }
                if (n == l - 1)
                {
                    //for (int j = 0; j < l; j++)
                    //{
                    //    arr[j + i] = item[j];
                    //}
                    Fill(arr, item, 0, l, i, 0);
                    insert = true;
                }
            }
            if (!insert)
            {
                int len = arr.Length;
                while ((arr[len - 1].Equals(default(T))))
                {
                    len--;
                }
                arr1 = arr;
                arr = new T[len + l];
                //for (int j = 0; j < len; j++)
                //{
                //    arr[j] = arr1[j];
                //}
                Fill(arr, arr1, 0, len, 0, 0);
                //for (int j = 0; j < item.Length; j++)
                //{
                //    arr[j + len] = item[j];
                //}
                Fill(arr, item, 0, item.Length, len, 0);
            }

        }

        public bool Remove(int index)
        {
            if (index < arr.Length)
            {
                //for (int i = index + 1; i < arr.Length; i++)
                //{
                //    arr[i - 1] = arr[i];
                //}
                Fill(arr, arr, index + 1, arr.Length, -1, 0);
                arr[arr.Length - 1] = default(T);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insert(int index, T something)
        {
            if (index < arr.Length)
            {
                int len = arr.Length-1;
                while ((arr[len].Equals(default(T)))&& (len>0))
                {
                    len--;
                }
                if (len+1 == arr.Length)
                {
                    arr1 = arr;
                    arr = new T[len + 2];
                    //for (int i = 0; i < index; i++)
                    //{
                    //    arr[i] = arr1[i];
                    //}
                    Fill(arr, arr1, 0, index, 0, 0);
                    //for (int i = len+1; i > index; i--)
                    //{
                    //    arr[i] = arr1[i - 1];
                    //}
                    ReverseFill(arr, arr1, len + 1, index, 0, -1);

                }
                else
                {
                    //for (int i = len; i > index; i--)
                    //{
                    //    arr[i] = arr[i - 1];
                    //}
                    ReverseFill(arr, arr1, len, index, 0, -1);
                }
                arr[index] = something;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void Fill (T[]arr, T[]arr1, int startPoint, int stopPoint, int koeff1, int koeff2)
        {
            for (int i = startPoint; i < stopPoint; i++)
            {
                arr[i+koeff1] = arr1[i+koeff2];
            }
        }

        private void ReverseFill(T[] arr, T[] arr1, int startPoint, int stopPoint, int koeff1, int koeff2)
        {
            for (int i = startPoint; i > stopPoint; i--)
            {
                arr[i + koeff1] = arr1[i + koeff2];
            }
        }


        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        public int Length
        {
            get
            {
                int length = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!(arr[i].Equals(default(T))))
                    {
                        length++;
                    }
                }
                return length;
            }
        }

        public T[] Arr
        {
            get
            {
                return arr;
            }
        }
    }
}


