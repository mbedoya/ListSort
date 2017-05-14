using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort.Model
{
    public class SelectionSort : Sorter
    {
        private struct MinimumElement
        {
            public int Value;
            public int Index;
        }

        public List<int> Sort(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                return list;
            }

            for (int i = 0; i < list.Count; i++)
            {
                MinimumElement minimum;
                minimum.Index = i;
                minimum.Value = list[i];

                bool swapNeeded = false;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[j] < minimum.Value)
                    {
                        minimum.Value = list[j];
                        minimum.Index = j;
                        swapNeeded = true;
                    }
                }

                if (swapNeeded)
                {
                    int temp = list[i];
                    list[i] = minimum.Value;
                    list[minimum.Index] = temp;
                }
            }

            return list;
        }
    }
}
