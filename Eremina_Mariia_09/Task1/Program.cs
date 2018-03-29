using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            List<int> list = new List<int>();
            for (int i = 0; i < num; i++)
            {
                list.Add(i + 1);
            }

            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < num; i++)
            {
                linkedList.AddLast(i + 1);
            }

            var resultList = RemoveEachSecondItem(list);
            Print(resultList);

            var resultLinkedList = RemoveEachSecondItem(linkedList);
            Print(resultLinkedList);

            Console.ReadKey();
        }

        public static ICollection<T> RemoveEachSecondItem<T>(ICollection<T> list)
        {
            int offset = 0;
            int number = list.Count();
            IEnumerable<T> tmpList;
            while (number != 1)
            {
                tmpList = list.Where((num, index) => index % 2 != offset);
                list = list.Where(num => !tmpList.Contains(num)).ToArray();
                if (!((number % 2) == 0))
                {
                    if (offset == 0)
                    {
                        offset = 1;
                    }
                    else
                    {
                        offset = 0;
                    }
                }
                number = list.Count();
            }
            return list;
        }

        public static void Print<T>(ICollection<T> list)
        {
            foreach (T element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
