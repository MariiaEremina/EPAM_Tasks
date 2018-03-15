using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ListToDropOut
    {
        private List<int> list;

        public ListToDropOut(int number)
        {
            if (number > 0)
            {
                list = Fill(number);
            }
            else throw new FormatException();
        }


        private List<int> Fill(int num)
        {
            list = new List<int>();
            for (int i = 0; i < num; i++)
            {
                list.Add(i+1);
            }
            return list;
        }

        //private static int RemoveEachSecondItem(List<int> list)
        //{
        //    int n = 1;

        //    while (list.Count != 1)
        //    {
        //        int m = list.Count;
        //        List<int> rem = new List<int> { 0 };
        //        for (int i = n; i < m; i = i + 2)
        //        {
        //            rem.Add(list[i]);
        //        }
        //        rem.RemoveAt(0);
        //        for (int i = 0; i < rem.Count; i++)
        //        {
        //            list.Remove(rem[i]);
        //        }
        //        if (!((m % 2) == 0))
        //        {
        //            if (n==0)
        //            {
        //                n = 1;
        //            }
        //            else
        //            {
        //                n = 0;
        //            }
        //        }
        //    }
        //    return list[0];
        //}

        

        public int Remove
            {
            get
            {
                return MutualMethods.RemoveEachSecondItem(list);
            }
        }

    }

}
