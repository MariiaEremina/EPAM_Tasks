using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     static class MutualMethods
    {
        //public static int RemoveEachSecondItem(ICollection<int> list)
        //{
        //    int n = 1;

        //    while (list.Count != 1)
        //    {
        //        int m = list.Count;
        //        List<int> rem = new List<int> { 0 };
        //        for (int i = n; i < m; i = i + 2)
        //        {
        //            var ar = list.ToArray();
        //            rem.Add(ar[i]);

        //        }
        //        rem.RemoveAt(0);
        //        for (int i = 0; i < rem.Count; i++)
        //        {
        //            list.Remove(rem[i]);
        //        }
        //        if (!((m % 2) == 0))
        //        {
        //            if (n == 0)
        //            {
        //                n = 1;
        //            }
        //            else
        //            {
        //                n = 0;
        //            }
        //        }
        //    }
        //    var arr = list.ToArray();
        //    return arr[0];
        //}

        public static int RemoveEachSecondItem(IEnumerable<int> list)
        {
            int n = 1;
            while (list.Count() != 1)
            {
                int m = list.Count();
                var ar = list.ToArray();
                for (int i = n; i < m; i = i + 2)
                {
                    ar[i] = 0;
                }
                list = list.Where(num => ar.Contains(num));
                if (!((m % 2) == 0))
                {
                    if (n == 0)
                    {
                        n = 1;
                    }
                    else
                    {
                        n = 0;
                    }
                }
            }
            return list.First();
        }


    }
}
