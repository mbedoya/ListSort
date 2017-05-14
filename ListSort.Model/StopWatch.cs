using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort.Model
{
    public class StopWatch
    {
        private DateTime startDate;

        public StopWatch()
        {
            startDate = DateTime.Now;
        }

        public static StopWatch StartNew()
        {
            return new StopWatch();
        }

        public double ElapsedSeconds()
        {
            return (DateTime.Now - startDate).TotalSeconds;
        }

        public double ElapsedMilliseconds()
        {
            return (DateTime.Now - startDate).TotalMilliseconds;
        }
    }
}
