using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort.Model
{
    public interface Sorter
    {
        List<int> Sort(List<int> list);
    }
}
