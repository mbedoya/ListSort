using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListSort.Model
{
    public class BubbleSort : Sorter
    {
        public List<int> Sort(List<int> list)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < list.Count-1; i++)
                {
                    if (list[i] > list[i+1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        sorted = false;
                    }
                }
            }

            return list;
        }
    }
}
