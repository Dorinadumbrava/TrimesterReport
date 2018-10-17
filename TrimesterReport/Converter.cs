using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimesterReport
{
    static class Converter
    {
        static public int GroupByTrimester(DateTime date)
        {
            if (date.Month > 0 && date.Month <= 4)
            {
                return 1;
            }
            else if (date.Month > 4 && date.Month <= 8)
            {
                return 2;
            }
            else if (date.Month > 9 && date.Month <= 12)
            {
                return 3;
            }
            else
            {
                throw new Exception("Invalid month");
            }
        }

        
    }
}
