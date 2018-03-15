using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class LinkedListToDropOut
    {
        private LinkedList<int> list;

        public LinkedListToDropOut(int number)
        {
            if (number > 0)
            {
                list = Fill(number);
            }
            else throw new FormatException();
        }


        private LinkedList<int> Fill(int num)
        {
            list = new LinkedList<int>();
            for (int i = 0; i < num; i++)
            {
                list.AddLast(i + 1);
            }
            return list;
        }
        public int Remove
        {
            get
            {
                return MutualMethods.RemoveEachSecondItem(list);
            }
        }
    }
}
